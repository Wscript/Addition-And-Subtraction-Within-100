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
        static int timerTickCounter = 0;

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
            int intMinutes = 0;
            bool isNumber = int.TryParse(textBoxMinutes.Text, out intMinutes);
            timerTickCounter = timerTickCounter + 1;
            if (timerTickCounter / 60 == intMinutes)
            {
                timer.Stop();
            }
            else
            {
                labelScore.Text = timerTickCounter.ToString();
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int intMinutes = 0;
            if (int.TryParse(textBoxMinutes.Text, out intMinutes))
            {
                timer.Interval = 1000;
                timer.Start();
                textBoxMinutes.Enabled = false;
                textBoxResult.Enabled = true;
                textBoxResult.Focus();
                labelScore.Text = "0";

                buttonStart.Enabled = false;
            }
        }

        private void textBoxMinutes_TextChanged(object sender, EventArgs e)
        {
            int intMinutes = 0;
            if (int.TryParse(textBoxMinutes.Text, out intMinutes))
            {
                labelTime.Text = intMinutes.ToString() + ":00";
            }
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
