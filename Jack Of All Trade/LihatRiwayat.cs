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
    public partial class Riwayat : Form
    {
        public Riwayat()
        {
            InitializeComponent();
        }

        private void HalamanStory_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAhli3_Click(object sender, EventArgs e)
        {
            Form ahli = new cariAhli();
            ahli.Show();
            this.Close();
        }

        private void btnLapor3_Click(object sender, EventArgs e)
        {
            Form Lapor = new halLapor();
            Lapor.Show();
            this.Hide();
        }
    }
}
