using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acadex0._1
{
    public partial class Student_InfoPanel : UserControl
    {
        public Student student;

        public Student_InfoPanel()
        {
            InitializeComponent();
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            SwitchToStudentList?.Invoke();
        }

        public void updateInfo() {
            this.StudentName.Text = student.name;
            this.StudentSection.Text = student.section;
            this.StudentID.Text = student.ID;
            this.StudentSubject.Text = student.subject;

        }


        private void clearGradeAdding() {
            Activity_Name.Text = "";
            Activity_Grade.Text = "";
        }
        public event Action SwitchToStudentList;

        private void button1_Click(object sender, EventArgs e)
        {
            clearGradeAdding();
        }
    }
}
