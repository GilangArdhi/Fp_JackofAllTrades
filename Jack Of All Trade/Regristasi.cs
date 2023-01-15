using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jack_Of_All_Trade
{
    public partial class Regristasi : Form
    {
        public Regristasi()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnSelanjutnya_Click(object sender, EventArgs e)
        {
            Form form3 = new halLapor();
            form3.Show();
            this.Hide();
        }
    }
}
