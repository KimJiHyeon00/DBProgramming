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
        }

        private List<List<string>> MarketColumnarDataStructure(String filename)
        {
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open), Encoding.Default); //지금은 상태경로 | c:\\ ->절대경로

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
            string str = ""; //두번째 컬럼 나타내기
            textBoxCSVViewer.Text = "";
            foreach (string value in data[columnIdx])
            {
                str += value + "\r\n"; //빠르게 업데이트
            }
            textBoxCSVViewer.Text = str;//텍스트박스 계속 업데이트하게 함
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

 
        Dictionary<string, int> headerIndexDict = new Dictionary<string, int>(); //딕셔너리 <key , value로 구성>
        
        private void SetHeaderList(string header)
        {
            var values = parseCSVLine(header);
            //foreach(string value in values)
            //listBoxHeaders.Items.Add(value);

            listBoxHeaders.Items.Clear();
            listBoxHeaders.Items.AddRange(values);

            for(int i =0; i < values.Length; i++)
            {
                string column = values[i];
                listBoxHeaders.Items.Add(column);
                headerIndexDict[column] = i;             
            }
        }

        //------------------------------- 과제 -----------------------------------------------------
        /*
          var values = parseCSVLine(line); //콤마 기준으로 단어들 뽑아줌
             "시장(구, 우리시장)" -> 콤마 없애는 코드 !!                        
             따옴표가 나오면 다음번의 따옴표가 나올때까지 하나의 문자로 묶어주면 끝 / 하나의 string으로 만들어줘라! 
         */
        
        private string[] parseCSVLine(string line)
        {
           /*
            //만드는 중...
            //1.콤마 기준으로 단어분리
            //string line = "시장(구, 우리시장)"; <- 이런식으로 나타나야함
            string[] word= line.Split(','); //line.Split(','); //-> 이 함수 써서 구현
            string[] word = values; //Split함수가 콤마기준으로 자른 문자열을 하나의 string 변수에 담아야한다.
         
            //2. 분리한 단어 체크 -> 반복문 돌면서 단어 체크

            //따옴표 열린상태 체크 함수 선언 = false;
            bool word = false;
           foreach(string word in values)
           {
                //만약 지금 문자에 "가 있다면 {
                if(word == ""){
                    //string 변수에 문자 담는다 +=         
                    string word[0] == ‘\”’ ;  //string[0].Equals 할때 “\””  가 아니라 ‘\”’ 로 바꾸니까 오류납니다..
                    //만약 지금 "가 열린 상태라면 {
                    if ( ???) {
                        //지금 만난 "은 닫힌 "이므로 한 묶음으로 묶어서 빼주기
                        string pharse = String.Join("", values);

                //열림 상태 체크 함수 = false;
                return string word;
            }
                else {   //열린상태가 아닌데 "가 있는거면
                    //열린 상태 체크 함수 = true;
                    string word = true;
            }
          }
            if( word =! ""){   //"가 없다면
                //만약 지금 "가 열린 상태라면 {
                if( ??? ){
                    //stirng 변수에 문자를 담기 +=
                    string values += word;
                }
            }
        }
            //String 변수이름[변수이름.length - 1] == “\””;   <<< 현재 string의 마지막 문자가 “ 이면 ~ -> 어디에 써야하는가요
          
            */
            return line.Split(','); //현재로써는 이게있어서 구동이 잘 된다.
        }


        //참고용!!!!
        /*
         with open('test01.csv', 'r') as reader:
        for line in reader:
        fields = line.split(',')
        print(fields)
         */

        // 먼저 콤마를 없애라 if (',' == true) 
        // 따옴표가 나오면 끝나는 따옴표 나올때까지 하나의 문자(string)로 묶어준다.
        // 한칸한칸씩 문자 읽으면서 콤마 처리해주고 따옴표 닫히는 부분까지 하나의 string(문자)으로 묶음
        // 10줄 이상의 라인들이 출력되어야함.


        //String pharse = sr; // 여기에 뭐가 들어가야되지?
        //pharse = pharse.Replace(",", "");

        /*
        StringBuilder sb = new StringBuilder();
        foreach (char c in values)
        {
            if (c == "")
            {


            }
         */

            //-------------------------------------------------------------------------------------------

            private List<List<string>> MakeRowbasedDataStructure()
        {
            StreamReader sr = new StreamReader(new FileStream("market.csv", FileMode.Open), Encoding.Default); //지금은 상태경로 | c:\\ ->절대경로

            var line = sr.ReadLine();
            SetHeaderList(line);

            List<List<string>> data = new List<List<string>>(); //<<>>리스트에 리스트를 담는 것
        
            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine(); //하나의 라인이 들어감
                var values = parseCSVLine(line); //콤마 기준으로 단어들 뽑아줌
                // "시장(구, 우리시장)" -> 콤마 없애는 코드 과제!!                         // |우리시장| |5일장| |대구시|...
                // 따옴표가 나오면 다음번의 따옴표가 나올때까지 하나의 문자로 묶어주면 끝 / 하나의 string으로 만들어줘라! 
                data.Add(values.ToList());
                 /*
                if (row++ == 10) //현재로써는 이 코드 없으면 구동안됌
                    break;  
                 */
            }
            sr.Close();
            return data;
        }
    

        private void printRowData_rowbased(List<List<string>> data, TextBox textbox)
        {
            string str = "";
            foreach (List<string> rowlist in data)
            {
                foreach (string value in rowlist)
                    str += value + "\t";
                str += "\r\n";
            }
            textbox.Text = str;
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

        List<List<string>> data; //멤버변수 빠져나옴

        private void buttonOpenCSV_Click(object sender, EventArgs e)
        {
            var FD = new OpenFileDialog();
            DialogResult dResult = FD.ShowDialog();

            if(dResult == DialogResult.OK)
            {
                string filename = FD.FileName;
                //MessageBox.Show(filename, "확인");

               data = MakeRowbasedDataStructure();
                printRowData_rowbased(data, textBoxCSVViewer);
            }

            /*
            List<List<string>> data = MakeRowbasedDataStructure();
            //printRowData_rowbased(data);
            printColumnData_rowbased(data, 1);
            

            //List<List<string>> data=  MarketColumnarDataStructure();
            //printColumnData_columnbased(data, 1);
            //printRowData_columnbased(data);
            */

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxSearchKeyword.Text;

            if(keyword == "")
            {
                MessageBox.Show("검색 키워드를 입력하세요", "확인");
                return;
            }
            
            if(listBoxHeaders.SelectedItem == null)
            {
                MessageBox.Show("검색대상 컬럼을 선택하세요", "확인");
                return;
            }
            string column = listBoxHeaders.SelectedItem.ToString();
            if(column == "")
            {
                MessageBox.Show("검색대상 컬럼을 선택하세요", "확인");
                return;
            }
           
            MessageBox.Show("키워드 = " +keyword+ "컬럼 = " +column, "확인");

            DoSearch(keyword, column);
        }
    

    private void DoSearch(string keyword, string column)
        {
            //1. 대상 컬럼 확인
            if(headerIndexDict.ContainsKey(column) == false)
            {
                MessageBox.Show("검색대상 컬럼을 선택하세요", "확인");
                return;
            }

            int targetColumnIndex = headerIndexDict[column]; // logN시간에 수행가능

            List<List<string>> resultData = new List<List<string>>();
            foreach(List<string> row in data)
            {
                string value = row[targetColumnIndex];
                if (value.Contains(keyword)) {
                    resultData.Add(row);
                }
            }
            printRowData_rowbased(resultData, textBoxSearchResult);
 
            //2. 대상 컬럼에서 키워드를 포함하는지 확인
        }

     
    }

}
