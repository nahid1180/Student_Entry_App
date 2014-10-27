using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEntryApp
{
    class Department
    {
        public string Code { set; get; }
        public string DepartmentName { set; get; }
        public List<Student> StudentList { set; get; }

        public Department()
        {
            StudentList= new List<Student>();
        }

        public Department(string code, string departmentname):this()
        {
            Code = code;
            DepartmentName = departmentname;
        }

        //private int reg = 0;
        //private string msg;
        public void AddStudent(Student aStudent)
        {
            //if (aStudent.RegNo == reg.ToString())
            //{
               
            //    msg = "Please change";
            //    reg = 0;
            //}
            //else
            //{
                StudentList.Add(aStudent);
            //    reg = Convert.ToInt32(aStudent.RegNo);
            //}
            //reg++;

        }

    }
}
