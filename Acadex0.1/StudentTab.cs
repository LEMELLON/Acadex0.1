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
    public partial class StudentTab : UserControl
    {
        public StudentTab()
        {
            InitializeComponent();
        }
        public string ID;
        public string name;
        public string section;
        public string subject;
        public int StudentListLoc;

        private bool removeMode = false;
        private void StudentTab_Load(object sender, EventArgs e)
        {
            updateTab();
            removeModeOff();
        }
        public void updateTab() {
            StudentName.Text = name;
            StudentID.Text = ID;
            StudentSection.Text = section;
            StudentSubject.Text = subject;
        }

        public event Action<int> OpenStudentInfo;
        public event Action<int> removeStudentInfo;

        public void removeModeOn() {
            remove.Show();
            removeMode = true;
        }

        public void removeModeOff()
        {
            remove.Hide();
            removeMode = false;
        }

        private void Tab_Clicked(object sender, EventArgs e)
        {
            OpenStudentInfo?.Invoke(StudentListLoc);
             
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (removeMode) removeStudentInfo?.Invoke(StudentListLoc);
        }
    }

}
