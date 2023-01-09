using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Jack_Of_All_Trade
{
    public partial class halLapor : Form
    {
        public static string setHarga = "";

        public halLapor()
        {
            InitializeComponent();
        }
        
        MYDB db = new MYDB();
        dataUser dtUser = new dataUser();
        LamanLogin login = new LamanLogin();

        /*public void username()
        {
            string urname = lpEmail;
            db.openConnection();
            string query = ("SELECT `nama` FROM `users` WHERE `email` Like '" + "@Emil" + "'");
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            command.Parameters.Add("@Emil", MySqlDbType.VarChar).Value = urname;
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtUser.Text = reader.GetValue(0).ToString();
            }
        }*/

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnRiwayat1_Click(object sender, EventArgs e)
        {
            Form riwayat = new Riwayat();
            riwayat.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        string pilihan;
        public string kategori()
        {
            if (ckElektronik.Checked)
            {
                pilihan = "Elektronik";
                //halPembayaran price = new halPembayaran();
                //price.stdChoose = pilihan;
                
            } else if (ckKuli.Checked)
            {
                pilihan = "Tukang Bangunan";
                //halPembayaran price = new halPembayaran();
                //price.stdChoose = pilihan;
            }
            else if (ckMontir.Checked)
            {
                pilihan = "Montir";
                //halPembayaran price = new halPembayaran();
                //price.stdChoose = pilihan;
            }
            else if (ckKunci.Checked)
            {
                pilihan = "Ahli Kunci";
                //halPembayaran price = new halPembayaran();
                //price.stdChoose = pilihan;
            }

            return pilihan;
        }

        private void halLapor_Load(object sender, EventArgs e)
        {
            db.openConnection();
            String urname = LamanLogin.setEmail;
            MySqlCommand command = new MySqlCommand("SELECT `nama` FROM `users` WHERE `email`=@Emil", db.getConnection());
            command.Parameters.Add("@Emil", MySqlDbType.VarChar).Value = urname;
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtUser.Text = reader.GetValue(0).ToString();
            }
            reader.Close();
            db.closeConnection();
        }

        private void txtPengaduan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPengaduan_Clicked(object sender, EventArgs e)
        {
            if(txtPengaduan.Text == "Tulis masalah yang anda hadapi...")
            {
                txtPengaduan.Text = "";
                txtPengaduan.ForeColor = Color.Black;
            }
        }

        private void txtPengaduan_Leave(object sender, EventArgs e)
        {
            if (txtPengaduan.Text == "")
            {
                txtPengaduan.Text = "Tulis masalah yang anda hadapi...";
                txtPengaduan.ForeColor = Color.DarkGray;
            }
        }

        private void btnLapor_Click(object sender, EventArgs e)
        {
            string desk = txtPengaduan.Text;
            string pilihan = kategori();
            setHarga = kategori();

            if (pictureBox1.Image != null)
            {
                //btnLapor
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                if (desk.Trim().Equals("") || !ckElektronik.Checked || !ckKuli.Checked || !ckKunci.Checked || !ckMontir.Checked)
                {
                    MessageBox.Show("Data not completed",
                        "Wrong Data",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    if (dtUser.Lapor(pilihan, desk, img))
                    {
                        MessageBox.Show("Laporan Berhasil!!\nSilahkan Lanjutkan ke pembayaran",
                            "Sukses lapor",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Form bayar = new halPembayaran();
                        bayar.Show();
                        this.Close();
                    }
                }
            }
            else
            {
                if (desk.Trim().Equals(""))
                {
                    MessageBox.Show("Data not completed",
                        "Wrong Data",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    if (dtUser.Lapor2(pilihan, desk))
                    {
                        MessageBox.Show("Laporan Berhasil!!\nSilahkan Lanjutkan ke pembayaran",
                            "Sukses lapor",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Form bayar = new halPembayaran();
                        bayar.Show();
                        this.Close();
                    }
                }
            }
        }

        private void btnUnggah_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPengaduan.Text = ofd.FileName;
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void btnAhli1_Click(object sender, EventArgs e)
        {
            Form ahli = new cariAhli();
            ahli.Show();
            this.Close();
        }

        private void ckElektronik_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckElektronik_Click(object sender, EventArgs e)
        {
            if (ckElektronik.Checked)
            {
                ckElektronik.BackColor = Color.Blue;
                ckElektronik.ForeColor = Color.White;
                ckMontir.Visible = false;
                ckKunci.Visible = false;
                ckKuli.Visible = false;
            }
            else
            {
                ckElektronik.BackColor = Color.White;
                ckElektronik.ForeColor = Color.Blue;
                ckMontir.Visible = true;
                ckKunci.Visible = true;
                ckKuli.Visible = true;
            }
        }

        private void ckKuli_Click(object sender, EventArgs e)
        {
            if (ckKuli.Checked)
            {
                ckKuli.BackColor = Color.Blue;
                ckKuli.ForeColor = Color.White;
                ckMontir.Visible = false;
                ckKunci.Visible = false;
                ckElektronik.Visible = false;
            } else
            {
                ckKuli.BackColor = Color.White;
                ckKuli.ForeColor = Color.Blue;
                ckMontir.Visible = true;
                ckKunci.Visible = true;
                ckElektronik.Visible = true;
            }
        }

        private void ckKunci_Click(object sender, EventArgs e)
        {
            if (ckKunci.Checked)
            {
                ckKunci.BackColor = Color.Blue;
                ckKunci.ForeColor = Color.White;
                ckMontir.Visible = false;
                ckElektronik.Visible = false;
                ckKuli.Visible = false;
            }
            else
            {
                ckKunci.BackColor= Color.White;
                ckKunci.ForeColor= Color.Blue;
                ckMontir.Visible = true;
                ckElektronik.Visible = true;
                ckKuli.Visible = true;
            }
        }

        private void ckMontir_Click(object sender, EventArgs e)
        {
            if (ckMontir.Checked)
            {
                ckMontir.BackColor = Color.Blue;
                ckMontir.ForeColor = Color.White;
                ckElektronik.Visible = false;
                ckKunci.Visible = false;
                ckKuli.Visible = false;
            }
            else
            {
                ckMontir.BackColor= Color.White;
                ckMontir.ForeColor= Color.Blue;
                ckElektronik.Visible = true;
                ckKunci.Visible = true;
                ckKuli.Visible = true;
            }
        }
    }
}
