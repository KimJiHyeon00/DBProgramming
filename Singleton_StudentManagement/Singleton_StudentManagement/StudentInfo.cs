using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{

    [Serializable]
    class StudentInfo
    {

        public string name_ { get; set; }  //이름 -> 객체지향언어라서 private / 구글스타일이라서 _ 붙임
        public string name2_ { get; set; }
        public string name3_ { get; set; }


        public string sid_ { get; set; } //학번
        public string sid2_ { get; set; }
        public string sid3_ { get; set; }


        public string gender_ { get; set; } //성별
        public string gender2_ { get; set; }
        public string gender3_ { get; set; }

        //get, set을 통해서 변수 접근가능하게 한다.

        public string major_ { get; set; }
        

    }
}
