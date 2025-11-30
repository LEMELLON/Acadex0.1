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
    public partial class InputStudent : Form
    {
        public InputStudent()
        {
            InitializeComponent();
        }

        private void InputStudent_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            clearTextFeild();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student studendt = new Student(inputName.Text, inputID.Text, inputSection.Text, inputSubject.Text);
            StudentLists.Students.Add(studendt);
            this.Hide();
            clearTextFeild();
            SubmitClicked?.Invoke();
        }


        public event Action SubmitClicked;

        private void clearTextFeild() {
            inputName.Text = "";
            inputID.Text = "";
            inputSection.Text = "";
            inputSubject.Text = "";
        }
    }
}
