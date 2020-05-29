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
            model.OnHear += (name, rank, text, time) => ChatOutput.AppendText($"{rank} {name} | {time}{Environment.NewLine}{text}{Environment.NewLine}");
            
            model.OnGmChanged += x =>
            {
                if (!(GMButton.Visible = x))
                {
                    gmForm.Hide();
                }
            };

            model.OnTimeTurn += (time, turnend, turn) =>
            {
                serverTime = time;
                doomsdayTime = turnend;
                TurnCountLabel.Text = $"Current turn{Environment.NewLine}{turn}";
                TurnTimeLabel.Text = $"Turn ends at{Environment.NewLine}{turnend:HH:mm:ss}";
            };

            model.OnCharacterChanged += (name, rank, branch, faction) =>
            {
                CharacterLabel.Text = name;
                if (rank != null) RankLabel.Text = rank;
                if (branch != null) BranchLabel.Text = branch;
                if (faction != null) FactionLabel.Text = faction;
            };

            model.OnRoomChanged += (area, name, people) =>
            {
                if (area != null) AreaLabel.Text = area;
                if (name != null) RoomLabel.Text = name;
                if (people != null)
                {
                    PopulationLabel.Text = people.Length.ToString();
                    if (people.Length == 0)
                    {
                        RoomPeopleBox.Text = "Empty.";
                    }
                    else
                    {
                        RoomPeopleBox.Text = string.Join(Environment.NewLine, people);
                    }
                }
                
            };
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            model.Send(new SpeechMessage(ChatInput.Text));
            ChatInput.Text = string.Empty;
        }

        private void ChatInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendButton_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            serverTime = serverTime.AddMilliseconds(Timer.Interval);
            TimeLabel.Text = $"Current time{Environment.NewLine}{serverTime:HH:mm:ss}";
            var timeLeftToDoomsday = doomsdayTime - serverTime;
            DoomsdayLabel.Text = $"Turn ends in{Environment.NewLine}{timeLeftToDoomsday:hh\\:mm\\:ss}";
        }

        private void GMButton_Click(object sender, EventArgs e)
        {
            gmForm.Show();
        }
    }
}
