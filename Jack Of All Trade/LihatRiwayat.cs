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

namespace Jack_Of_All_Trade
{
    public partial class Riwayat : Form
    {
        public Riwayat()
        {
            InitializeComponent();
        }

        MYDB db = new MYDB();
        dataUser dtUser = new dataUser();

        /*public void username()
        {
            string urname = riwayatEmail;
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

        private void HalamanStory_Load(object sender, EventArgs e)
        {
            dgHistory.DataSource = dtUser.historyList();
            dgHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dgHistory.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial",
               9, FontStyle.Bold);
            dgHistory.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgHistory.EnableHeadersVisualStyles = false;

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
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
