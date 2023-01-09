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
    public partial class LamanLogin : Form
    {
        public static string setEmail = "";
        public LamanLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }


        private void RememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void LamanLogin_Clicked(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email...";
                txtEmail.ForeColor = Color.DarkGray;
            }

            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password...";
                txtPassword.ForeColor = Color.DarkGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtEmail_Clicked(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email...")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Clicked(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password...")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            MYDB db = new MYDB();

            String username = txtEmail.Text;
            String password = txtPassword.Text;


            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(
                "SELECT * FROM `users` WHERE `email`= @usn and `password`= @pass", db.getConnection());
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {

                setEmail = txtEmail.Text;

                /*cariAhli nmuser = new cariAhli();
                nmuser.stdEmail = txtEmail.Text;
                /*Riwayat history = new Riwayat();
                history.riwayatEmail = txtEmail.Text;
                history.ShowDialog();
                history.Close();
                //halLapor Lapor = new halLapor();
                //Percobaan Lapor = new Percobaan();
                //Lapor.lpEmail = username;
                //Lapor.stdEmail = username;
                //Lapor.riwayatEmail = username;
                //Lapor.ShowDialog();*/

                MessageBox.Show("Login Success", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form Lapor = new halLapor();
                Lapor.Show();
                this.Close();
            }
            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form form3 = new TampilanAwal();
            form3.Show();
            this.Close();
        }
    }
}
