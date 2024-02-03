using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pingfence
{
    public partial class QuickScan : Form
    {
        public QuickScan()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Create an instance of the Pingfence form
            Pingfence Pingfence = new Pingfence();

            // Show the Pingfence form
            Pingfence.Show();
        }

        private void QuickScan_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e) 
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 50;
            pictureBox1.Visible= true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


        }


        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            progressBar2.Increment(1);
            if (progressBar1.Value == 100 & progressBar2.Value == 100 )
            {
                timer1.Stop();
                MessageBox.Show("Scan Complete", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Visible = false;
            }
        }
    }
}
