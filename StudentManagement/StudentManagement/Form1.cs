using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        string strConn = "Server=49.50.174.201;Database=s5671189;Uid=s5671189;Pwd=s5671189;Charset=utf8";

        private bool loadCompleted_ = false;
        public Form1()
        {
            InitializeComponent();
            InitVariable();
            InitVariable(); //두번 호출해줘도 clear했기때문에 한번씩만 나옴
        }

        private void InitVariable()
        {
            comboBoxStudent2Gender.Items.Clear();
            comboBoxStudent2Gender.Items.Add("남자");
            comboBoxStudent2Gender.Items.Add("여자");

            string[] genderData = { "남자", "여자" }; //배열 선언
            comboBoxStudent3Gender.Items.Clear();
            comboBoxStudent3Gender.Items.AddRange(genderData);

            comboBoxStudent1Gender.SelectedIndex = 1;
            comboBoxStudent2Gender.SelectedIndex = 1;
            comboBoxStudent3Gender.SelectedIndex = 1;
        }
        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            LoadStudent();
            SaveStudent();
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
            //MessageBox.Show("ComboBox 1 selected index changed...", "확인");
        }
        private void comboBoxStudent1Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }

        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
           //SaveStudent();
        }
        #endregion



        #region Student 2 Event handlers
        private void textBoxStudent2ID_TextChanged(object sender, EventArgs e)
        {
            SaveStudent();
        }
        private void textBoxStudent2Name_TextChanged(object sender, EventArgs e)
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

        #endregion


        private void LoadStudent()
        {
            /*
            StreamReader sr = new StreamReader(new FileStream("Student.dat", FileMode.Open));

            textBoxStudent1Name.Text = sr.ReadLine();
            textBoxStudent1ID.Text = sr.ReadLine();
            comboBoxStudent1Gender.Text = sr.ReadLine();

            textBoxStudent2Name.Text = sr.ReadLine();
            textBoxStudent2ID.Text = sr.ReadLine();
            comboBoxStudent2Gender.Text = sr.ReadLine();

            textBoxStudent3Name.Text = sr.ReadLine();
            textBoxStudent3ID.Text = sr.ReadLine();
            comboBoxStudent3Gender.Text = sr.ReadLine();

            sr.Close();
            */

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
                /*
                while (rdr.Read())
                {
                    str = rdr["name"] + " " + rdr["id"] + " " + rdr["gender"];
                    str2 = sdr["name"] + " " + sdr["id"] + " " + sdr["gender"];
                    str3 = tdr["name"] + " " + tdr["id"] + " " + tdr["gender"];


                    //~~~textbox.Text =rdr["name"] 이런식으로 코드 바꾸기 -> 불러오기 할려면
                }
                rdr.Close();
                */
                //MessageBox.Show(str);

                /*
                rdr.Close();
                sdr.Close();
                tdr.Close();
                */

            
            /* 
            Stream rs = new FileStream("student.stu", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            StudentInfo studentInfo = (StudentInfo)deserializer.Deserialize(rs);

            rs.Close();

            textBoxStudent1Name.Text = studentInfo.name_;
            textBoxStudent1ID.Text = studentInfo.sid_;
            comboBoxStudent1Gender.Text = studentInfo.gender_;

            textBoxStudent2Name.Text = studentInfo.name_;
            textBoxStudent2ID.Text = studentInfo.sid_;
            comboBoxStudent2Gender.Text = studentInfo.gender_;

            textBoxStudent3Name.Text = studentInfo.name_;
            textBoxStudent3ID.Text = studentInfo.sid_;
            comboBoxStudent3Gender.Text = studentInfo.gender_;
            */

        }
        /*
        StreamReader sr = new StreamReader(new FileStream("Student.dat", FileMode.Open)); 

        textBoxStudent1Name.Text = sr.ReadLine();
        textBoxStudent1ID.Text = sr.ReadLine();
        comboBoxStudent1Gender.Text = sr.ReadLine();

        textBoxStudent2Name.Text = sr.ReadLine();
        textBoxStudent2ID.Text = sr.ReadLine();
        comboBoxStudent2Gender.Text = sr.ReadLine();

        textBoxStudent3Name.Text = sr.ReadLine();
        textBoxStudent3ID.Text = sr.ReadLine();
        comboBoxStudent3Gender.Text = sr.ReadLine();

        sr.Close();
        */

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


            //StudentInfo 기록하는 부분 --> 객체단위로     / 이부분 없어도 되나요?
            /*
            Stream ws = new FileStream("student.stu", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();

            serializer.Serialize(ws, studentInfo);
            ws.Close();


            StreamWriter sw = new StreamWriter(new FileStream("Student.dat", FileMode.Create));

            sw.WriteLine(studentInfo.name_);
            sw.WriteLine(studentInfo.sid_);
            sw.WriteLine(studentInfo.gender_);
            //
            */
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

            //sw.Close();
        }

    }
}


/*
sw.WriteLine(textBoxStudent1Name.Text);
sw.WriteLine(textBoxStudent1ID.Text);
sw.WriteLine(comboBoxStudent1Gender.Text);

sw.WriteLine(textBoxStudent2Name.Text);
sw.WriteLine(textBoxStudent2ID.Text);
sw.WriteLine(comboBoxStudent2Gender.Text);

sw.WriteLine(textBoxStudent3Name.Text);
sw.WriteLine(textBoxStudent3ID.Text);
sw.WriteLine(comboBoxStudent3Gender.Text);
*/

/*

  본 문서는 stu파일 0.1 포맷에 관한 것이다.
  revision 0.1 3030.09.22- 작성자 김지현

  stu 파일 구조:
  stu파일은 간단하게 단일 라인마다 텍스트가 기록되어 있으며 값은 다음의 순서로 기록됨.
  학생1이름
  학생1학번
  학생1성별
  학생2이름
  학생2학번
  학생2성별
  학생3이름
  학생3학번
  학생3성별

*/
