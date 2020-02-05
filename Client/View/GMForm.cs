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
    public partial class GMForm : Form
    {
        private readonly MessageAction Send;

        public GMForm(MessageAction send)
        {
            Send = send;
            InitializeComponent();
        }

        private void GMForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
