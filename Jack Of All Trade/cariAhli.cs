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
    public partial class cariAhli : Form
    {
        private PictureBox pic = new PictureBox();

        //dataUser dtUser = new dataUser();
        MYDB db = new MYDB();

        public cariAhli()
        {
            InitializeComponent();
            getImage();
            
        }

        /*public void username()
        {
            string urname = stdEmail;
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnRiwayat2_Click(object sender, EventArgs e)
        {
            Form riwayat = new Riwayat();
            riwayat.Show();
            this.Close();
        }

        private void btnLapor2_Click(object sender, EventArgs e)
        {
            Form Lapor = new halLapor();
            Lapor.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBangunan_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkMontir_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkKunci_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Lebih10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void getImage()
        {
            db.openConnection();
            //DataTable table = new DataTable();
            MySqlCommand com = new MySqlCommand("select `img` from `ahli`", db.getConnection());
            //MySqlDataAdapter da = new MySqlDataAdapter();
            //da.SelectCommand = com;

            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                pic = new PictureBox();
                pic.Width = 258;
                pic.Height = 120;
                pic.BackgroundImageLayout = ImageLayout.Stretch;

                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic.BackgroundImage = bitmap;

                flowLayoutPanel1.Controls.Add(pic);
            }
            dr.Close();
            db.closeConnection();
            /* DataSet ds = new DataSet();
             da.Fill(ds, "`ahli`");

             int c = ds.Tables["ahli"].Rows.Count;

             if (c > 0)
             {
                 //BLOB is read into Byte array, then used to construct MemoryStream,
                 //then passed to PictureBox.
                 byte[] byteTry = new byte[0];
                 byteTry = (byte[])(ds.Tables["ahli"].Rows[c - 1]["img"]);
                 MemoryStream stmTry = new MemoryStream(byteTry);
                 Bitmap bitmap = new Bitmap(stmTry);

                 pic = new PictureBox();
                 pic.Width = 319;
                 pic.Height = 157;
                 pic.BackgroundImageLayout = ImageLayout.Stretch;

                 pic.Image = bitmap;
                 flowLayoutPanel1.Controls.Add(pic);
             }else
             {
                 MessageBox.Show("Wrong Username or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/
        }

        public void Elektro()
        {
            db.openConnection();
            //DataTable table = new DataTable();
            //MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand com = new MySqlCommand("SELECT `img` FROM `ahli` WHERE `nama` LIKE '%Elektronik%'", db.getConnection());

            //da.SelectCommand = com;
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                pic = new PictureBox();
                pic.Width = 258;
                pic.Height = 120;
                pic.BackgroundImageLayout = ImageLayout.Stretch;

                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic.BackgroundImage = bitmap;

                flowLayoutPanel1.Controls.Add(pic);
            }
            dr.Close();
            db.closeConnection();

        }

        public void Kuli()
        {
            db.openConnection();
            MySqlCommand com = new MySqlCommand("SELECT `img` FROM `ahli` WHERE `nama` LIKE '%Tukang Bangunan%'", db.getConnection());
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                pic = new PictureBox();
                pic.Width = 258;
                pic.Height = 120;
                pic.BackgroundImageLayout = ImageLayout.Stretch;

                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic.BackgroundImage = bitmap;

                flowLayoutPanel1.Controls.Add(pic);
            }
            dr.Close();
            db.closeConnection();
        }

        public void montir()
        {
            db.openConnection();
            MySqlCommand com = new MySqlCommand("SELECT `img` FROM `ahli` WHERE `nama` LIKE '%Montir%'", db.getConnection());

            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                pic = new PictureBox();
                pic.Width = 258;
                pic.Height = 120;
                pic.BackgroundImageLayout = ImageLayout.Stretch;

                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic.BackgroundImage = bitmap;

                flowLayoutPanel1.Controls.Add(pic);
            }
            dr.Close();
            db.closeConnection();
        }

        public void Kunci()
        {

            db.openConnection();
            MySqlCommand com = new MySqlCommand("SELECT `img` FROM `ahli` WHERE `nama` LIKE '%Ahli Kunci%'", db.getConnection());
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                pic = new PictureBox();
                pic.Width = 258;
                pic.Height = 120;
                pic.BackgroundImageLayout = ImageLayout.Stretch;

                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic.BackgroundImage = bitmap;

                flowLayoutPanel1.Controls.Add(pic);
            }
            dr.Close();
            db.closeConnection();
        }

        public void Jarak(int jarak)
        {
            db.openConnection();
            MySqlCommand com = new MySqlCommand("SELECT `img` FROM `ahli` WHERE `alamat` BETWEEN 0 and @scale", db.getConnection());
            com.Parameters.Add("@scale", MySqlDbType.Int32).Value = jarak;
            MySqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                pic = new PictureBox();
                pic.Width = 258;
                pic.Height = 120;
                pic.BackgroundImageLayout = ImageLayout.Stretch;

                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic.BackgroundImage = bitmap;

                flowLayoutPanel1.Controls.Add(pic);
            }
            dr.Close();
            db.closeConnection();
        }

        public void roleJarak(string role, int jarak)
        {
            
            db.openConnection();
            MySqlCommand com = new MySqlCommand("SELECT `img` FROM `ahli` WHERE `nama` LIKE '%@pekerjaan%' and `alamat` BETWEEN 0 and @scale", db.getConnection());
            com.Parameters.Add("@pekerjaan", MySqlDbType.VarChar).Value = role;
            com.Parameters.Add("@scale", MySqlDbType.Int32).Value = jarak;
            MySqlDataReader dr = com.ExecuteReader();
            flowLayoutPanel1.Controls.Clear();
            while (dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                pic = new PictureBox();
                pic.Width = 258;
                pic.Height = 120;
                pic.BackgroundImageLayout = ImageLayout.Stretch;

                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic.BackgroundImage = bitmap;

                flowLayoutPanel1.Controls.Add(pic);
            }
            dr.Close();
            db.closeConnection();
        }

        public void cekJarak()
        {
            if (kurang10.Checked && !checkBangunan.Checked && !checkMontir.Checked && !checkKunci.Checked && !checkElektronik.Checked)
            {
                int distance = 10000;
                Jarak(distance);
            }
            if (Kurang5.Checked && !checkBangunan.Checked && !checkMontir.Checked && !checkKunci.Checked && !checkElektronik.Checked)
            {
                int distance = 5000;
                Jarak(distance);
            }
            if (Kurang2.Checked && !checkBangunan.Checked && !checkMontir.Checked && !checkKunci.Checked && !checkElektronik.Checked)
            {
                int distance = 2000;
                Jarak(distance);
            }
            if (Kurang1.Checked && !checkBangunan.Checked && !checkMontir.Checked && !checkKunci.Checked && !checkElektronik.Checked)
            {
                int distance = 1000;
                Jarak(distance);
            }
            if (kurangSetengah.Checked && !checkBangunan.Checked && !checkMontir.Checked && !checkKunci.Checked && !checkElektronik.Checked)
            {
                int distance = 500;
                Jarak(distance);
            }
        }
        public void jr()
        {
            //MONTIR
            if (checkMontir.Checked && kurang10.Checked)
            {
                string role = "Montir";
                int distance = 10000;
                roleJarak(role, distance);
            }
            if (checkMontir.Checked && Kurang5.Checked)
            {
                string role = "Montir";
                int distance = 5000;
                roleJarak(role, distance);
            }
            if (checkMontir.Checked && Kurang2.Checked)
            {
                string role = "Montir";
                int distance = 2000;
                roleJarak(role, distance);
            }
            if (checkMontir.Checked && Kurang1.Checked)
            {
                string role = "Montir";
                int distance = 1000;
                roleJarak(role, distance);
            }

            if (checkMontir.Checked && kurangSetengah.Checked)
            {
                string role = "Montir";
                int distance = 500;
                roleJarak(role, distance);
            }

            //ELEKTRONIK
            if (checkElektronik.Checked && kurang10.Checked)
            {
                string role = "Elektronik";
                int distance = 10000;
                roleJarak(role, distance);
            }
            if (checkElektronik.Checked && Kurang5.Checked)
            {
                string role = "Elektronik";
                int distance = 5000;
                roleJarak(role, distance);
            }
            if (checkElektronik.Checked && Kurang2.Checked)
            {
                string role = "Elektronik";
                int distance = 2000;
                roleJarak(role, distance);
            }
            if (checkElektronik.Checked && Kurang1.Checked)
            {
                string role = "Elektronik";
                int distance = 1000;
                roleJarak(role, distance);
            }

            if (checkElektronik.Checked && kurangSetengah.Checked)
            {
                string role = "Elektronik";
                int distance = 500;
                roleJarak(role, distance);
            }

            //AHLI KUNCI
            if (checkKunci.Checked && kurang10.Checked)
            {
                string role = "Ahli Kunci";
                int distance = 10000;
                roleJarak(role, distance);
            }
            if (checkKunci.Checked && Kurang5.Checked)
            {
                string role = "Ahli Kunci";
                int distance = 5000;
                roleJarak(role, distance);
            }
            if (checkKunci.Checked && Kurang2.Checked)
            {
                string role = "Ahli Kunci";
                int distance = 2000;
                roleJarak(role, distance);
            }
            if (checkKunci.Checked && Kurang1.Checked)
            {
                string role = "Ahli Kunci";
                int distance = 1000;
                roleJarak(role, distance);
            }

            if (checkKunci.Checked && kurangSetengah.Checked)
            {
                string role = "Ahli Kunci";
                int distance = 500;
                roleJarak(role, distance);
            }

            //TUKANG BANGUNAN
            if (checkBangunan.Checked && kurang10.Checked)
            {
                string role = "Tukang Bangunan";
                int distance = 10000;
                roleJarak(role, distance);
            }
            if (checkBangunan.Checked && Kurang5.Checked)
            {
                string role = "Tukang Bangunan";
                int distance = 5000;
                roleJarak(role, distance);
            }
            if (checkBangunan.Checked && Kurang2.Checked)
            {
                string role = "Tukang Bangunan";
                int distance = 2000;
                roleJarak(role, distance);
            }
            if (checkBangunan.Checked && Kurang1.Checked)
            {
                string role = "Tukang Bangunan";
                int distance = 1000;
                roleJarak(role, distance);
            }

            if (checkBangunan.Checked && kurangSetengah.Checked)
            {
                string role = "Tukang Bangunan";
                int distance = 500;
                roleJarak(role, distance);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            if (checkMontir.Checked && !kurang10.Checked && !Kurang5.Checked && !Kurang2.Checked && !Kurang1.Checked && !kurangSetengah.Checked)
            {
                montir();
            }
            if (checkElektronik.Checked && !kurang10.Checked && !Kurang5.Checked && !Kurang2.Checked && !Kurang1.Checked && !kurangSetengah.Checked)
            {
                Elektro();
            }
            if (checkBangunan.Checked && !kurang10.Checked && !Kurang5.Checked && !Kurang2.Checked && !Kurang1.Checked && !kurangSetengah.Checked)
            {
                Kuli();
            }
            if (checkKunci.Checked && !kurang10.Checked && !Kurang5.Checked && !Kurang2.Checked && !Kurang1.Checked && !kurangSetengah.Checked)
            {
                Kunci();
            }
            cekJarak();
            jr();
            if (!checkBangunan.Checked && !checkMontir.Checked && !checkKunci.Checked && !checkElektronik.Checked
                && !kurang10.Checked && !Kurang5.Checked && !Kurang2.Checked && !Kurang1.Checked && !kurangSetengah.Checked)
            {
                getImage();
            }
            
            
        }

        private void cariAhli_Load(object sender, EventArgs e)
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

        private void btnAhli2_Click(object sender, EventArgs e)
        {

        }
    }
}

