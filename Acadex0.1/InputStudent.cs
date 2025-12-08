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
            Toolset.MakeRounded(panel1,10);
        }

        private Student student ;

        private void InputStudent_Load(object sender, EventArgs e)
        {
            foreach (var s in DataBase1.Students)
            {
                // Display format: "ID - Name - Section - Subject"
                comboBox1.Items.Add($"{s.ID} - {s.name} - {s.section} - {s.subject}");
            }
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                // Get selected index directly
                student = DataBase1.Students[comboBox1.SelectedIndex];
                if (StudentLists.isInStudents(student))
                {

                    MessageBox.Show("Student Already in the Dashboard");
                }
                else
                {
                    StudentLists.Students.Add(student);
                    this.Hide();
                    SubmitClicked?.Invoke();
                }
            }
            else
            {
                MessageBox.Show("Please select a student from the list.");
            }
        }



        public event Action SubmitClicked;

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "") label2.Text="";
            else label2.Text= "Enter Student Number";
        }
    }
}
