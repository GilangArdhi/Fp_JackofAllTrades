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
using System.Drawing.Imaging;

namespace Jack_Of_All_Trade
{
    public partial class Percobaan : Form
    {
        public string lpEmail { get; set; }
        public string riwayatEmail { get; set; }
        public string stdEmail { get; set; }
        public string stdChoose { get; set; }  

        private PictureBox pic = new PictureBox();
        public Percobaan()
        {
            InitializeComponent();
            getImage();
            //lodPrice();
        }

        MYDB db2 = new MYDB();
        dataUser dataUser = new dataUser();
        halLapor hlLapor = new halLapor();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void lodPrice()
        {
            label1.Text = stdChoose;
        }

        /*public void loadHarga()
        {
            string role = stdChoose;
            db2.openConnection();
            string query = ("SELECT `harga` FROM `price_product` WHERE `kategori` Like '" + "@category" + "'");
            MySqlCommand command = new MySqlCommand(query, db2.getConnection());
            command.Parameters.Add("@category", MySqlDbType.VarChar).Value = role;
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtTarif.Text = reader.GetValue(0).ToString();
            }
        }*/

        private void getImage()
        {
            db2.openConnection();
            //DataTable table = new DataTable();
            MySqlCommand com = new MySqlCommand("select `img` from `ahli`", db2.getConnection());
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
            db2.closeConnection();

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

        private void Percobaan_Load(object sender, EventArgs e)
        {
            label1.Text = stdEmail;

            String role = stdChoose;
            string un = hlLapor.kategori();


            label3.Text = lpEmail;
            label4.Text = riwayatEmail;

            db2.openConnection();
            //string query2 = ("INSERT INTO `price_product`(`kategori`) VALUES (@category)");
            //string query = ("SELECT `harga` FROM `price_product` WHERE `kategori` Like '%" + "Montir" + "%'");
            MySqlCommand command = new MySqlCommand("SELECT `harga` FROM `price_product` WHERE `kategori`= @kate", db2.getConnection());
            command.Parameters.Add("@kate", MySqlDbType.VarChar).Value = role;
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                label2.Text = reader.GetValue(0).ToString();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new halLapor();
            form.Show();
            this.Close();
        }
    }
}
