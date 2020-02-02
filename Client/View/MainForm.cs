using System;
using System.Windows.Forms;
using Crisis.Model;

namespace Crisis.View
{
    public partial class MainForm : Form
    {
        private readonly IMessageSender msgSender;

        public MainForm(IMessageSender sender)
        {
            msgSender = sender;
            InitializeComponent();
        }

        public void ToChat(string text)
        {
            chatOutput.AppendText($"{Environment.NewLine}{text}");
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            msgSender.Send(new Messages.SpeechMessage { Text = chatInput.Text });
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
    }
}
