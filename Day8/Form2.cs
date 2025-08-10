using Day8.Q2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Day8
{
    public partial class Form2 : Form
    {
        List<Student> students = new List<Student>();
        int selected = -1;
        public Form2()
        {
            InitializeComponent();

            students.Add(new Student("Ali", 12345679811, new DateTime(2000,12,1)));
            students.Add(new Student("Mohammad", 12345679812, new DateTime(2004,3,17)));

            stdView.Columns.Add("Name");
            stdView.Columns.Add("Phone");
            stdView.Columns.Add("Birthdate");

            AdjustStudentsView();

            stdView.MouseClick += stdView_MouseClick;

        }
        private void stdView_MouseClick(object sender, MouseEventArgs e)
        {
            if (stdView.SelectedItems.Count > 0)
            {
                ListViewItem selected = stdView.SelectedItems[0];
                this.selected = selected.Index;
                DisplayData();
            }
        }

        void AdjustStudentsView()
        {
            stdView.Items.Clear();
            foreach (Student student in students)
            {
                ListViewItem item = new ListViewItem(student.Name);
                item.SubItems.Add(student.Phone.ToString());
                item.SubItems.Add(student.Birthdate.ToString());
                stdView.Items.Add(item);
            }
        }

        private void addStd_Click(object sender, EventArgs e)
        {
            if (!checkData()) { return; }

            Student student = new Student(txtStdName.Text, long.Parse(txtStdPhone.Text), StdBirthDate.Value);

            bool stdFlag = true;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].IsItACopy(student))
                {
                    students[i] = student;
                    stdFlag = false;
                    break;
                }
            }

            if (stdFlag) students.Add(student);

            AdjustStudentsView();

            ResetForm();
        }

        private bool checkData()
        {
            if (this.txtStdName.Text == null || this.txtStdName.Text == string.Empty)
                return false;

            if (this.txtStdPhone.Text == null || this.txtStdPhone.Text == string.Empty || this.txtStdPhone.Text.Length != 11)
                return false;

            bool flag = long.TryParse(this.txtStdPhone.Text, out long phoneNumber);

            if (!flag) return false;

            if (this.StdBirthDate.Value > DateTime.Now)
                return false;

            return true;
        }

        private void SaveStdBtn_Click(object sender, EventArgs e)
        {
            if (!checkData()) { return; }

            bool stdFlag = true;
            for (int i = 0; i < students.Count; i++)
            {
                if(i != selected && students[i].Phone.ToString() == txtStdPhone.Text)
                {
                    stdFlag = false;
                    break; 
                }
            }
            if(stdFlag)
            {
                students[selected].Name = txtStdName.Text;
                students[selected].Birthdate = StdBirthDate.Value;
                students[selected].Phone = long.Parse(txtStdPhone.Text);
            }

            AdjustStudentsView();
        }

        private void DisplayData()
        {
            Student student = students[selected];

            txtStdName.Text = student.Name;
            txtStdPhone.Text = student.Phone.ToString();
            StdBirthDate.Text = student.Birthdate.ToString();
        }

        private void ResetForm()
        {
            txtStdName.Text = txtStdPhone.Text =  string.Empty;
            StdBirthDate.Value = DateTime.Now;
        }
    }
}
