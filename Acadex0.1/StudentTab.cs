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
        private void StudentTab_Load(object sender, EventArgs e)
        {
            StudentName.Text= name;
            StudentID.Text= ID;
            StudentSection.Text= section;
            StudentSubject.Text= subject;
        }

        private void StudentName_Click(object sender, EventArgs e)
        {
            lookToStudent?.Invoke();
        }

        public event Action lookToStudent;
    }

}
