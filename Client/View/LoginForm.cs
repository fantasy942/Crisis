using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crisis.View
{
    public partial class LoginForm : Form
    {
        public string Username => username.Text;
        public string Password => "";

        public event Action LoginPressed;

        public LoginForm()
        {
            InitializeComponent();
            Error = string.Empty;
        }

        private void login_Click(object sender, EventArgs e)
        {
            LoginPressed();
        }

        public string Error
        {
            get => errorStatus.Text;
            set => errorStatus.Text = value;
        }
    }
}
