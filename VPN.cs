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
    public partial class VPN : Form
    {
        public VPN()
        {
            InitializeComponent();
        }


        private void button8_Click_1(object sender, EventArgs e)
        {
            Pingfence pingfence = new Pingfence();
            this.Hide();
            pingfence.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Define the URL you want to redirect to
            string websiteUrl = "https://www.pingfence.com";

            // Open the URL in the default browser
            System.Diagnostics.Process.Start(websiteUrl);
        }
    }
}
