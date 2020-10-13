using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace MarketBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            int a = 3; //일부러 적음
            double b = 15;
        }

        private List<List<string>> MarketColumnarDataStructure()
        {
            StreamReader sr = new StreamReader(new FileStream("market.csv", FileMode.Open), Encoding.Default); //지금은 상태경로 | c:\\ ->절대경로

            String str = "";

            var line = sr.ReadLine();
            var headers = line.Split(',');


            List<List<string>> data = new List<List<string>>(); //<<>>리스트에 리스트를 담는 것
            foreach (String header in headers)
            {
                List<string> list = new List<string>(); // 빈 리스트에 칼럼들을 채워넣겠다는 뜻
                list.Add(header); //리스트라는 컬렉션에 header 텍스트가 젤 첫번재로 들어감
                data.Add(list);
            }

            //textBoxCSVViewer.Text += header + "\t";

            int row = 0;          
            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine(); //하나의 라인이 들어감
                var values = line.Split(','); //콤마 기준으로 단어들 뽑아줌
                // |우리시장| |5일장| |대구시|...
                
                for (int i=0; i<values.Length; i++)
                {
                    data[i].Add(values[i]);
                }
                if (row++ == 10)
                    break;
                //str += values[0] + "\r\n"; //values의 0번째 컬럼만 출력해줌
                //textBoxCSVViewer.Text += line + "\r\n"; //파일이 라인 단위로 출력됌
            }

            //textBoxCSVViewer.Text = str;

            sr.Close();
            return data;
        }

        private void printColumnData_columnbased(List<List<string>> data, int columnIdx)
        {
            string str = ""; //두번째 컬럼 나차내기
            textBoxCSVViewer.Text = "";
            foreach (string value in data[columnIdx])
            {
                str += value + "\r\n"; //빠르게 업데이트
            }
            textBoxCSVViewer.Text = str;//텍스트박스 걔속 업데이트하게 함
        }

        private void printRowData_columnbased(List<List<string>> data)
        {
            string str = "";
            for (int row = 0 ; row < data[0].Count; row++) //첫번째 리스트 길이만큼 출력
            { 
                foreach(List<string> list in data)
                {
                    str += list[row] + "\t";
                }
                str += "\r\n";
            }
            textBoxCSVViewer.Text = str;
        }
        private string[] parseCSVLine(string line)
        {
            return line.Split(',');
        }
        private List<List<string>> MakeRowbasedDataStructure()
        {
            StreamReader sr = new StreamReader(new FileStream("market.csv", FileMode.Open), Encoding.Default); //지금은 상태경로 | c:\\ ->절대경로

            var line = sr.ReadLine();
           
            List<List<string>> data = new List<List<string>>(); //<<>>리스트에 리스트를 담는 것
        
            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine(); //하나의 라인이 들어감
                var values = parseCSVLine(line); //콤마 기준으로 단어들 뽑아줌
                // "시장(구, 우리시장)" -> 콤마 없애는 코드 과제!!                            // |우리시장| |5일장| |대구시|...
                // 따옴표가 나오면 다음번의 따옴표가 나올때까지 하나의 문자로 묶어주면 끝 / 하나의 string으로 만들어줘라! 
                data.Add(values.ToList());
                 /*
                if (row++ == 10) //현재로써는 이 코드 없으면 구동안됌
                    break;  
                 */

                //지금 커밋해봐도되는거죠? 네네!
            }
            sr.Close();
            return data;
        }

        private void printRowData_rowbased(List<List<string>> data)
        {
            string str = "";
            foreach (List<string> rowlist in data)
            {
                foreach (string value in rowlist)
                    str += value + "\t";
                str += "\r\n";
            }
            textBoxCSVViewer.Text = str;
        }
    
        private void printColumnData_rowbased(List<List<string>> data, int colIdx)
        {
            string str = "";
            foreach (List<string> rowlist in data)
            {
                str += rowlist[colIdx] + "\r\n";
            }
            textBoxCSVViewer.Text = str;
        }

        private void buttonOpenCSV_Click(object sender, EventArgs e)
        {
            List<List<string>> data = MakeRowbasedDataStructure();
            //printRowData_rowbased(data);
            printColumnData_rowbased(data, 1);
            

            //List<List<string>> data=  MarketColumnarDataStructure();
            //printColumnData_columnbased(data, 1);
            //printRowData_columnbased(data);

        }
    }
}
