//using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryFile_StudentManagement
{
    public partial class Form1 : Form
    {
        //string strConn = "Server=49.50.174.201;Database=s5671189;Uid=s5671189;Pwd=s5671189;Charset=utf8";

        private bool loadCompleted_ = false;
        public Form1()
        {
            InitializeComponent();
            InitVariable();
        }

        private void InitVariable()
        {
            comboBoxStudent1Gender_Binary.Items.Clear();
            comboBoxStudent1Gender_Binary.Items.Add("남자");
            comboBoxStudent1Gender_Binary.Items.Add("여자");

            comboBoxStudent2Gender_Binary.Items.Clear();
            comboBoxStudent2Gender_Binary.Items.Add("남자");
            comboBoxStudent2Gender_Binary.Items.Add("여자");

            string[] genderData = { "남자", "여자" }; //배열 선언
            comboBoxStudent3Gender_Binary.Items.Clear();
            comboBoxStudent3Gender_Binary.Items.AddRange(genderData);

        }

        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            BinaryLoadStudent();
            BinarySaveStudent();
            loadCompleted_ = true;
           
            
        }


        // -----------------------------------------------------------------------------------------------


        #region Student 1 Event handlers

        private void textBoxStudent1Name_Binary_TextChanged(object sender, EventArgs e)
        {
            BinarySaveStudent();
        }

        private void textBoxStudent1ID_Binary_TextChanged(object sender, EventArgs e)
        {
            BinarySaveStudent();
        }

        private void comboBoxStudent1Gender_Binary_SelectedIndexChanged(object sender, EventArgs e)
        {
            BinarySaveStudent();
        }

        private void buttonStudent1Save_Binary_Click(object sender, EventArgs e)
        {
            
            BinarySaveStudent();
        }
        private void buttonStudent1Delete_Binary_Click(object sender, EventArgs e)
        {
           
        }

        #endregion


        // -------------------------------------------------------------------------------------------------


        #region Student 2 Event handlers
        private void textBoxStudent2Name_Binary_TextChanged(object sender, EventArgs e)
        {
            BinarySaveStudent();
        }
        private void textBoxStudent2ID_Binary_TextChanged(object sender, EventArgs e)
        {
            BinarySaveStudent();
        }
        private void comboBoxStudent2Gender_Binary_SelectedIndexChanged(object sender, EventArgs e)
        {
            BinarySaveStudent();
        }

        private void buttonStudent2Save_Binary_Click(object sender, EventArgs e)
        {
            BinarySaveStudent();
        }
        #endregion


        // --------------------------------------------------------------------------------------------------


        #region Student 3 Event handlers
        private void textBoxStudent3Name_Binary_TextChanged(object sender, EventArgs e)
        {
            BinarySaveStudent();
        }
        private void textBoxStudent3ID_Binary_TextChanged(object sender, EventArgs e)
        {
            BinarySaveStudent();
        }

        private void comboBoxStudent3Gender_Binary_SelectedIndexChanged(object sender, EventArgs e)
        {
            BinarySaveStudent();
        }

        private void buttonStudent3Save_Binary_Click(object sender, EventArgs e)
        {
            BinarySaveStudent();
        }
        #endregion


        // -----------------------------------------------------------------------------------------------

        private void BinarySaveStudent()
        {
            if (loadCompleted_ == false) //로드가 아직 되지 않은 상황이라면 return을 시켜주면 아래코드가 실행되지 않기 떄문에 정상적인 코드가 실행된다.
                return;

            BinaryWriter bw = new BinaryWriter(new FileStream("StudentFile.dat", FileMode.Create), Encoding.UTF8);


            bw.Write(textBoxStudent1Name_Binary.Text);
            bw.Write(textBoxStudent1ID_Binary.Text);
            bw.Write(comboBoxStudent1Gender_Binary.Text);

            bw.Write(textBoxStudent2Name_Binary.Text);
            bw.Write(textBoxStudent2ID_Binary.Text);
            bw.Write(comboBoxStudent2Gender_Binary.Text);

            bw.Write(textBoxStudent3Name_Binary.Text);
            bw.Write(textBoxStudent3ID_Binary.Text);
            bw.Write(comboBoxStudent3Gender_Binary.Text);

            bw.Close();
        }
        /*
           본 문서는 student 데이터 파일 버전 0.1 포맷에 관한 것이다.
           revision 0.1 2020.09.26 - 작성자 김지현

          위 파일은 헤더와 데이터로 구성이 된다.
          헤더는 첫 4바이트 값으로 아래의 내용을 포함한다. 

          *student 데이터 파일 구조:
          student 파일은 간단하게 단일 라인마다 텍스트로 기록되어 있으며 바이너리 파일로 저장된다.
          데이터 값은 다음의 순서로 기록됨.
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


        private void BinaryLoadStudent()
        {
            //FileStream fs = File.Create("StudentFile.dat"); 
            //fs.Close();

            BinaryReader br = new BinaryReader(new FileStream("StudentFile.dat", FileMode.Open));

            String name1 = br.ReadString();
            String id1 = br.ReadString();
            String gender1 = br.ReadString();

            String name2 = br.ReadString();
            String id2 = br.ReadString();
            String gender2 = br.ReadString();

            String name3 = br.ReadString();
            String id3 = br.ReadString();
            String gender3 = br.ReadString();


            textBoxStudent1Name_Binary.Text = name1;
            textBoxStudent1ID_Binary.Text = id1;
            comboBoxStudent1Gender_Binary.Text = gender1;

            textBoxStudent2Name_Binary.Text = name2;
            textBoxStudent2ID_Binary.Text = id2;
            comboBoxStudent2Gender_Binary.Text = gender2;

            textBoxStudent3Name_Binary.Text = name3;
            textBoxStudent3ID_Binary.Text = id3;
            comboBoxStudent3Gender_Binary.Text = gender3;

            /* 콘솔창 출력
            Console.WriteLine("학생1이름 = " + name1);
            Console.WriteLine("학생1나이 = " + id1);
            Console.WriteLine("학생1성별= " + gender1);
            
            Console.WriteLine("학생2이름 = " + name2);
            Console.WriteLine("학생2나이 = " + id2);
            Console.WriteLine("학생2성별= " + gender2);

            Console.WriteLine("학생3이름 = " + name3);
            Console.WriteLine("학생3나이 = " + id3);
            Console.WriteLine("학생3성별= " + gender3);
            */

            br.Close();

        }

       
    }
}

