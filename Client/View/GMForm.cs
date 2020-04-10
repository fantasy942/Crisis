using System.Windows.Forms;
using Crisis.Model;

namespace Crisis.View
{
    public partial class GMForm : Form
    {
        private readonly CrisisModel model;

        public GMForm(CrisisModel model)
        {
            this.model = model;
            InitializeComponent();
        }

        private void GMForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
