using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLtest
{
    public partial class Form1 : Form
    {
        string strConn = "Server=49.50.174.201;Database=s5671189;Uid=s5671189;Pwd=s5671189;Charset=utf8";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* //첫번재
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO staff (id_staff, name_staff) VALUES (2020, '계명이')", conn);
                cmd.ExecuteNonQuery();
            }
            */
            /* //두번째
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                string sql = "SELECT * FROM staff";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string str = string.Format("{0} : {1}", rdr["id_staff"], rdr["name_staff"]);
                    MessageBox.Show(str);
                }
                rdr.Close();
            }
            */
            //세번째
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE staff SET name_staff = '컴공이' WHERE id_staff = 2020", conn);
                cmd.ExecuteNonQuery();
            }

        }
    }
}
