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
    public partial class FullScan : Form
    {
        public FullScan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            //pictureBox1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            progressBar2.Increment(1);
            if (progressBar1.Value == 100 & progressBar2.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("Scan Complete", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //pictureBox1.Visible = false;

            }
        }

    }
}
