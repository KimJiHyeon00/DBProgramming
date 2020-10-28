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

namespace studentSQL //market프로젝트에 있어야할 내용
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strconn = "Server=49.50.174.201;Database=s5671189;Uid=s5671189;Pwd=s5671189;Charset=utf8;";
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "INSERT INTO student(name, gender) values('박길동', '남자')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = "select * from student";
                MySqlCommand cmd = new MySqlCommand(query, conn);
               
                /*
                while (str.Read()){
                    string str = rdr["id"] + " " + rdr["nam"] + " " + rdr["gender"];
                    MessageBox.Show(str);
                }       
                rdr.Close();
                */
            }
        }
    }
}
