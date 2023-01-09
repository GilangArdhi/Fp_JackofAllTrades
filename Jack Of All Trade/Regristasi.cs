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

        dataUser dtUser = new dataUser();

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
            string name = boxNama.Text;
            string gender = boxGender.Text; 
            string location = lokasiUsers.Text;
            string city = boxKotaAsal.Text;
            string hp = boxTelp.Text;
            int nohp = (int)Convert.ToInt64(boxTelp.Text);
            string email = boxEmail.Text;
            string pass = boxPassword.Text;
            string confpass = confirmPass.Text;

            if (name.Trim().Equals("") && gender.Trim().Equals("") && location.Trim().Equals("") && city.Trim().Equals("") && email.Trim().Equals("") && pass.Trim().Equals("") && hp.Trim().Equals(""))
            {
                MessageBox.Show("Data not completed",
                    "Wrong Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            } 
            else if (confpass != pass)
            {
                MessageBox.Show("Make sure your password",
                    "Wrong Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (dtUser.addUsers(name, gender, location, city, nohp, email, pass))
                {
                    MessageBox.Show("new Account Successfully!",
                        "New Genre",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    //dgGenres.DataSource = genre.GenresList();
                }
                else
                {
                    MessageBox.Show("Genre Not Added",
                        "Add Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                Form form3 = new LamanLogin();
                form3.Show();
                this.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form form3 = new TampilanAwal();
            form3.Show();
            this.Close();
        }

        private void boxTelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Regristasi_Load(object sender, EventArgs e)
        {

        }
    }
}
