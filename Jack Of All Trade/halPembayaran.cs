using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Jack_Of_All_Trade
{
    public partial class halPembayaran : Form
    {
        public halPembayaran()
        {
            InitializeComponent();
            //loadHarga();
        }

        MYDB db = new MYDB();

        /*public void loadHarga()
        {
            string role = stdChoose;
            db.openConnection();
            string query = ("SELECT `harga` FROM `price_product` WHERE `kategori` Like '"+ "@category" + "'");
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            command.Parameters.Add("@category", MySqlDbType.VarChar).Value = role;
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtTarif.Text = reader.GetValue(0).ToString();
            }
        }*/


        private void halPembayaran_Load(object sender, EventArgs e)
        {
            String role = halLapor.setHarga;
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT `harga` FROM `price_product` WHERE `kategori`=@kate", db.getConnection());
            command.Parameters.Add("@kate", MySqlDbType.VarChar).Value = role;
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtTarif.Text = reader.GetValue(0).ToString();
            }
            reader.Close();
            db.closeConnection();
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transaksi Berhasil!!\nSilahkan Tunggu Ahli datang!",
                        "Transaki Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            Form balek = new Riwayat();
            balek.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form back = new halLapor();
            back.Show();
            this.Close();
        }
    }
}
