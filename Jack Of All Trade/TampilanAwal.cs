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
    public partial class TampilanAwal : Form
    {

        public TampilanAwal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form form = new LamanLogin();
            form.Show();
            this.Hide();

        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            Form form1 = new Regristasi();
            form1.Show();
            this.Hide();
        }
    }
}
