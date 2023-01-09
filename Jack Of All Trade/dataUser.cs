using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;

namespace Jack_Of_All_Trade
{
    internal class dataUser
    {
        MYDB db = new MYDB();

        public Boolean addUsers(string name, string gender, string location, string city, int nohp, string email, string pass)
        {
            string query = "INSERT INTO `users`(`nama`, `gender`, `alamat`, `kota_asal`, `notelp`, `email`, `password`) " +
                "VALUES (@nama_user, @gender_user, @alamat_user, @kota_user, @notelp_user, @email_user, @password_user)";

            MySqlParameter[] parameters = new MySqlParameter[7];
            parameters[0] = new MySqlParameter("@nama_user", MySqlDbType.VarChar);
            parameters[0].Value = name;

            parameters[1] = new MySqlParameter("@gender_user", MySqlDbType.VarChar);
            parameters[1].Value = gender;

            parameters[2] = new MySqlParameter("@alamat_user", MySqlDbType.VarChar);
            parameters[2].Value = location;

            parameters[3] = new MySqlParameter("@kota_user", MySqlDbType.VarChar);
            parameters[3].Value = city;

            parameters[4] = new MySqlParameter("@notelp_user", MySqlDbType.Int64);
            parameters[4].Value = nohp;

            parameters[5] = new MySqlParameter("@email_user", MySqlDbType.VarChar);
            parameters[5].Value = email;

            parameters[6] = new MySqlParameter("@password_user", MySqlDbType.VarChar);
            parameters[6].Value = pass;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean hargaJasa(string kategori)
        {
            string query = "SELECT `harga` FROM `price_product` WHERE `kategori`=@category";

            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@category", MySqlDbType.VarChar);
            parameters[0].Value = kategori;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean Lapor(string kategori, string masalah, byte[] img)
        {
            string query = "INSERT INTO laporan(`kategori`, `deskripsi`, `gambar`) " +
                "VALUES (@jenis, @problem, @gambar)";

            MySqlParameter[] parameters = new MySqlParameter[3];
            parameters[0] = new MySqlParameter("@jenis", MySqlDbType.VarChar);
            parameters[0].Value = kategori;

            parameters[1] = new MySqlParameter("@problem", MySqlDbType.VarChar);
            parameters[1].Value = masalah;

            parameters[2] = new MySqlParameter("image", MySqlDbType.Blob);
            parameters[2].Value = img;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean Lapor2(string kategori, string masalah)
        {
            string query = "INSERT INTO laporan(`kategori`, `deskripsi`) " +
                "VALUES (@jenis, @problem)";

            MySqlParameter[] parameters = new MySqlParameter[2];
            parameters[0] = new MySqlParameter("@jenis", MySqlDbType.VarChar);
            parameters[0].Value = kategori;

            parameters[1] = new MySqlParameter("@problem", MySqlDbType.VarChar);
            parameters[1].Value = masalah;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public DataTable historyList()
        {
            DataTable table = new DataTable();
            table = db.getData("SELECT `id` as `No`, `kategori` as `Kategori`, `deskripsi` as `Masalah` , `tanggalmasuk` AS `Tanggal Lapor`  FROM `laporan`", null);

            return table;
        }
    }
}
