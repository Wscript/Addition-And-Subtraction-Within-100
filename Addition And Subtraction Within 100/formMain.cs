using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addition_And_Subtraction_Within_100
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            textBoxMinutes.Enabled = true;
            textBoxMinutes.Focus();
            textBoxMinutes.Text = "1";
            textBoxResult.Enabled = false;

        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
