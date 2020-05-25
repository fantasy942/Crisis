using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crisis.View
{
    public partial class LoginForm : Form
    {
        private TaskCompletionSource<(string name, string pwd)> loginPressed;

        public string Error
        {
            get => errorStatus.Text;
            set => errorStatus.Text = value;
        }

        public LoginForm()
        {
            InitializeComponent();
            Error = string.Empty;
        }

        public async Task<(string username, string password)> LoginAsync()
        {
            loginPressed = new TaskCompletionSource<(string, string)>();
            return await loginPressed.Task;
        }

        private void login_Click(object sender, EventArgs e)
        {
            loginPressed?.SetResult((emailBox.Text, passwordBox.Text));
        }
    }
}
