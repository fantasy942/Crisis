using System;
using System.Windows.Forms;
using Crisis.Model;
using Crisis.Messages.Client;
using Crisis.Messages.Server;

namespace Crisis.View
{
    public partial class MainForm : Form
    {
        private readonly CrisisModel model;

        public MainForm(CrisisModel sender)
        {
            model = sender;
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
            }
        }
    }
}
