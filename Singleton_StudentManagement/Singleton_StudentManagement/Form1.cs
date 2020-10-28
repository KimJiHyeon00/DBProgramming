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
using StudentManagement;

namespace Singleton_StudentManagement
{
    public partial class Form1 : Form
    {
        string strConn = "Server=49.50.174.201;Database=s5671189;Uid=s5671189;Pwd=s5671189;Charset=utf8";

        private bool loadCompleted_ = false;

        //학생정보 체크박스 확인
        //private int isloadChecked = 0;
        private bool isloadChecked = false;

        //전공부터 출력 체크박스 확인
        //private int isMajorChecked = 0;
        private bool isMajorChecked = false;

        //학생 삭제 확인
        int[] delStudent = new int[3];

        //빈상자
        bool[] tmp = new bool[3];

        public Form1()
        {
            InitializeComponent();
            InitVariable();
        }
        private void InitVariable()
        {
            comboBoxStudent2Gender.Items.Clear();
            comboBoxStudent2Gender.Items.Add("남자");
            comboBoxStudent2Gender.Items.Add("여자");

            string[] genderData = { "남자", "여자" };
            comboBoxStudent3Gender.Items.Clear();
            comboBoxStudent3Gender.Items.AddRange(genderData);

            comboBoxStudent1Gender.SelectedIndex = 1;
            comboBoxStudent2Gender.SelectedIndex = 1;
            comboBoxStudent3Gender.SelectedIndex = 1;

           if(isloadChecked == true)
            {
                checkBoxLoadSet.Checked = true;
                LoadStudent();
            }
            if (isMajorChecked == true)
            {
                checkBoxMajorSet.Checked = true;
                LoadStudent();
            }

            // 이전 체크박스가 체크되었다면, 체크박스 체크 후 Load 실행.
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM student_checked", conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (Convert.ToInt32(rdr["checked"]) == 1)
                    {
                        checkBoxLoadSet.Checked = true;
                        LoadStudent();
                    }
                }
                rdr.Close();
            }

        }

        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            LoadStudent();
            loadCompleted_ = true;

        }


        #region Student 1 Event handlers
        private void textBoxStudent1Name_TextChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }
        private void textBoxStudent1ID_TextChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }
        private void comboBoxStudent1Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }
        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            //SaveStudent();



        }
        private void buttonStudent1Delete_Click(object sender, EventArgs e)
        {
            textBoxStudent1Name.Text = String.Empty;
            textBoxStudent1ID.Text = String.Empty;
            comboBoxStudent1Gender.Text = String.Empty;

            delStudent[0] = 1;
            //String query = "delete from student where num=1";
            tmp[0] = false;

            //삭제하는 코드
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM student WHERE SaveStudent", conn);
                cmd.ExecuteNonQuery();
              
            }
            // Form 화면 초기화
            textBoxStudent1Name.Text = "학생정보없음";
            textBoxStudent1ID.Text = "";
            comboBoxStudent1Gender.SelectedIndex = 0;
           

            MessageBox.Show("삭제했습니다.");

        }

        #endregion



        #region Student 2 Event handlers
        private void textBoxStudent2Name_TextChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }
        private void textBoxStudent2ID_TextChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }
        private void comboBoxStudent2Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }
        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {
            //SaveStudent();
        }
        private void buttonStudent2Delete_Click(object sender, EventArgs e)
        {
            textBoxStudent2Name.Text = String.Empty;
            textBoxStudent2ID.Text = String.Empty;
            comboBoxStudent2Gender.Text = String.Empty;

            delStudent[1] = 1;
            tmp[1] = false;

            //삭제하는 코드
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM student WHERE SaveStudent", conn);
                cmd.ExecuteNonQuery();
            }
            // Form 화면 초기화
            textBoxStudent2Name.Text = "학생정보없음";
            textBoxStudent2ID.Text = "";
            comboBoxStudent2Gender.SelectedIndex = 0;

            MessageBox.Show("삭제했습니다.");
        }

        #endregion



        #region Student 3 Event handlers
        private void textBoxStudent3Name_TextChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }
        private void textBoxStudent3ID_TextChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void comboBoxStudent3Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }
        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {
            //SaveStudent();
        }
        private void buttonStudent3Delete_Click(object sender, EventArgs e)
        {
            textBoxStudent3Name.Text = String.Empty;
            textBoxStudent3ID.Text = String.Empty;
            comboBoxStudent3Gender.Text = String.Empty;

            delStudent[2] = 1;
            tmp[2] = false;
            //삭제하는 코드
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM student WHERE SaveStudent", conn);
                cmd.ExecuteNonQuery();
            }
            // Form 화면 초기화
            textBoxStudent3Name.Text = "학생정보없음";
            textBoxStudent3ID.Text = "";
            comboBoxStudent3Gender.SelectedIndex = 0;
         
            MessageBox.Show("삭제했습니다.");
        }


        #endregion



        
        private void LoadStudent()
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                string query = "select * from student";
                string second = "select * from student";
                string third = "select * from student";

                string str = "";
                string str2 = "";
                string str3 = "";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlCommand sd = new MySqlCommand(second, conn);
                MySqlCommand td = new MySqlCommand(third, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    str = rdr["name"] + " " + rdr["id"] + " " + rdr["gender"];
                }
                rdr.Close();


                MySqlDataReader sdr = sd.ExecuteReader();
                while (sdr.Read())
                {
                    str2 = sdr["name"] + " " + sdr["id"] + " " + sdr["gender"];
                }
                sdr.Close();


                MySqlDataReader tdr = td.ExecuteReader();
                while (tdr.Read())
                {
                    str3 = tdr["name"] + " " + tdr["id"] + " " + tdr["gender"];
                }
                tdr.Close();
            } 

        }

        #region Major Add handlers
        private void textBoxMajor_TextChanged(object sender, EventArgs e) //전공입력부분
        {
            AddMajor();
        }

        private void buttonMajorAdd_Click(object sender, EventArgs e) //전공추가부분
        {
            string keyword = textBoxMajor.Text;

            if (keyword == "")
            {
                MessageBox.Show("신규전공을 입력하세요", "확인");
                return;
            }
        }

        private void AddMajor()
        {
            StudentInfo studentInfo = new StudentInfo();
            studentInfo.major_ = textBoxMajor.Text;

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = "INSERT INTO student(major) VALUES('" + studentInfo.major_+ "');";
               
                MySqlCommand cmd = new MySqlCommand(query, conn);
               
                cmd.ExecuteNonQuery();
              
                MessageBox.Show("전공추가완료");
            }
        }
        #endregion


        private void SaveStudent()
        {
            if (loadCompleted_ == false)
                return;

            StudentInfo studentInfo = new StudentInfo();
            studentInfo.name_ = textBoxStudent1Name.Text;
            studentInfo.sid_ = textBoxStudent1ID.Text;
            studentInfo.gender_ = comboBoxStudent1Gender.SelectedItem.ToString();

            studentInfo.name2_ = textBoxStudent2Name.Text;
            studentInfo.sid2_ = textBoxStudent2ID.Text;
            studentInfo.gender2_ = comboBoxStudent2Gender.SelectedItem.ToString();


            studentInfo.name3_ = textBoxStudent3Name.Text;
            studentInfo.sid3_ = textBoxStudent3ID.Text;
            studentInfo.gender3_ = comboBoxStudent3Gender.SelectedItem.ToString();

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                string query = "INSERT INTO student(name, id, gender) VALUES('" + studentInfo.name_ + "' , " + studentInfo.sid_ + ", '" + studentInfo.gender_ + "');";
                string second = "INSERT INTO student(name, id, gender) VALUES('" + studentInfo.name2_ + "' , " + studentInfo.sid2_ + ", '" + studentInfo.gender2_ + "');";
                string third = "INSERT INTO student(name, id, gender) VALUES('" + studentInfo.name3_ + "' , " + studentInfo.sid3_ + ", '" + studentInfo.gender3_ + "');";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlCommand sd = new MySqlCommand(second, conn);
                MySqlCommand td = new MySqlCommand(third, conn);

                cmd.ExecuteNonQuery();
                sd.ExecuteNonQuery();
                td.ExecuteNonQuery();

                MessageBox.Show("저장완료");
            }
        }

        private void checkBoxLoadSet_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLoadSet.Checked) // 체크하면 true, 아니면 false 
                isloadChecked = 1;
            else
                isloadChecked = 0;

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE student_checked SET checked = '" + isloadChecked + "'", conn);
                cmd.ExecuteNonQuery();
            }
        }

        private void checkBoxMajorSet_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMajorSet.Checked)
                isMajorChecked = 1;
            else
                isMajorChecked = 0;

            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE student_checked SET checked = '" + isMajorChecked + "'", conn);
                cmd.ExecuteNonQuery();
            }
        }

        
    }
}