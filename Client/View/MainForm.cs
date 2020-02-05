using System;
using System.Windows.Forms;
using Crisis.Model;
using Crisis.Messages.Client;
using Crisis.Messages.Server;

namespace Crisis.View
{
    public partial class MainForm : Form
    {
        private TimeSpan serverTimeDifference = TimeSpan.Zero;
        private DateTime doomsdayTime = DateTime.MinValue;

        private readonly CrisisModel model;
        private readonly GMForm gmForm;

        public MainForm(CrisisModel sender)
        {
            model = sender;
            gmForm = new GMForm(model.Send);
            InitializeComponent();
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
            const int limit = 500;
            for (int i = 0; i < limit && model.TryPopMessage(out Messages.Message msg); i++)
            {
                if (msg is HearMessage hmsg)
                {
                    chatOutput.AppendText($"{hmsg.Rank} {hmsg.Name} | {hmsg.Time}{Environment.NewLine}{hmsg.Text}{Environment.NewLine}");
                }
                else if (msg is GMChangedMessage gmsg)
                {
                    gmButton.Visible = gmsg.IsGM;
                    if (!gmsg.IsGM)
                    {
                        gmForm.Hide();
                    }
                }
                else if (msg is TimeTurnMessage ttmsg)
                {
                    serverTimeDifference = DateTime.UtcNow.Subtract(ttmsg.Time);
                    doomsdayTime = ttmsg.TurnEnd;
                    turnCountLabel.Text = $"Current turn{Environment.NewLine}{ttmsg.Turn}";
                    turnTimeLabel.Text = $"Turn ends at{Environment.NewLine}{ttmsg.TurnEnd:HH:mm:ss}";
                }
            }

            var serverTime = DateTime.UtcNow + serverTimeDifference;
            timeLabel.Text = $"Current time{Environment.NewLine}{serverTime:HH:mm:ss}";
            var timeLeftToDoomsday = doomsdayTime - serverTime;
            doomsdayLabel.Text = $"Turn ends in{Environment.NewLine}{timeLeftToDoomsday.ToString(timeLeftToDoomsday > TimeSpan.FromMinutes(1) ? @"hh\:mm\:ss" : @"ss\.ff")}";
        }

        private void gmButton_Click(object sender, EventArgs e)
        {
            gmForm.Show();
        }
    }
}
