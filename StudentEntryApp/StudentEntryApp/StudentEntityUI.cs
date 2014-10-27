using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEntryApp
{
    public partial class StudentEntityUI : Form
    {
        private Department aDepartment;
        private Student aStudent;

        public StudentEntityUI()
        {
            InitializeComponent();
        }

        private void savedepartmentInfoButton_Click(object sender, EventArgs e)
        {
            aDepartment = new Department(codeTextBox.Text,deaprtmentNameTextBox.Text);

            MessageBox.Show("Department has been created");
        }

        
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            aStudent = new Student();
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Name = studentNameTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aDepartment.AddStudent(aStudent);
            MessageBox.Show(aStudent.Name + "'s information has been stored");          
        }

        

        private void detailsButton_Click(object sender, EventArgs e)
        {
            string info = "Dept. Id" + aDepartment.Code + "\tName" + aDepartment.DepartmentName + "\n";
            info += "Reg No\t" + "Name\t" + "Email\n";
            
            foreach (Student aStudent in aDepartment.StudentList)
            {                
                    string studentInfo = aStudent.RegNo + "\t" + aStudent.Name + "\t" + aStudent.Email + "\n";
                    info += studentInfo;              
            }
            MessageBox.Show(info);
        }
    }
}
