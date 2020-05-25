using System;
using System.Windows.Forms;
using Crisis.Model;
using Crisis.Messages.Client;
using System.Linq;

namespace Crisis.View
{
    public partial class MainForm : Form
    {

        private DateTime serverTime = DateTime.MinValue; //Approx
        private DateTime doomsdayTime = DateTime.MinValue;

        private readonly CrisisModel model;
        private readonly GMForm gmForm;

        public MainForm(CrisisModel model)
        {
            this.model = model;
            RegisterModelEvents();
            gmForm = new GMForm(model);
            InitializeComponent();
        }

        private void RegisterModelEvents()
        {
            model.OnHear += (name, rank, text, time) => chatOutput.AppendText($"{rank} {name} | {time}{Environment.NewLine}{text}{Environment.NewLine}");
            
            model.OnGmChanged += x =>
            {
                gmButton.Visible = x;
                if (!x)
                {
                    gmForm.Hide();
                }
            };

            model.OnTimeTurn += (time, turnend, turn) =>
            {
                serverTime = time;
                doomsdayTime = turnend;
                turnCountLabel.Text = $"Current turn{Environment.NewLine}{turn}";
                turnTimeLabel.Text = $"Turn ends at{Environment.NewLine}{turnend:HH:mm:ss}";
            };

            model.OnCharacterChanged += (name, rank, branch, faction) =>
            {
                characterLabel.Text = name;
                characterBox.Text = $"RANK{Environment.NewLine}{rank}{Environment.NewLine}{Environment.NewLine}" +
                $"BRANCH{Environment.NewLine}{branch}{Environment.NewLine}{Environment.NewLine}" +
                $"FACTION{Environment.NewLine}{faction}";
            };

            model.OnRoomChanged += (name, people) =>
            {
                roomLabel.Text = name;
                populationLabel.Text = people.Length.ToString();
                if (people.Length == 0)
                {
                    roomPeopleBox.Text = "Empty.";
                }
                else
                {
                    roomPeopleBox.Text = string.Join(Environment.NewLine, people);
                }
            };
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            model.Send(new SpeechMessage { Text = chatInput.Text });
            chatInput.Text = string.Empty;
        }

        private void chatInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendButton_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            serverTime = serverTime.AddMilliseconds(timer.Interval);
            timeLabel.Text = $"Current time{Environment.NewLine}{serverTime:HH:mm:ss}";
            var timeLeftToDoomsday = doomsdayTime - serverTime;
            doomsdayLabel.Text = $"Turn ends in{Environment.NewLine}{timeLeftToDoomsday:hh\\:mm\\:ss}";
        }

        private void gmButton_Click(object sender, EventArgs e)
        {
            gmForm.Show();
        }
    }
}
