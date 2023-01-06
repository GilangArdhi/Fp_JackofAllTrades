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
    public partial class cariAhli : Form
    {
        public cariAhli()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnRiwayat2_Click(object sender, EventArgs e)
        {
            Form riwayat = new Riwayat();
            riwayat.Show();
            this.Hide();
        }

        private void btnLapor2_Click(object sender, EventArgs e)
        {
            Form Lapor = new halLapor();
            Lapor.Show();
            this.Hide();
        }
    }
}
