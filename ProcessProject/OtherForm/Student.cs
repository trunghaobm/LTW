using ProcessProject.OtherClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessProject.OtherForm
{
    public partial class Student : Form
    {
        private AddStudent addStudent = new AddStudent();
        private ShowStudent showStudent = new ShowStudent();

        public Student()
        {
            InitializeComponent();
        }

        private void _Load()
        {
            picShowStudent.BackColor = Color.LightGray;
            picAddNewStudent.BackColor = Color.Gray;
            AllUser.OpenChildForm(showStudent, panelFormControl);
        }

        private void Student_Load(object sender, EventArgs e)
        {
            panelFormControl.Controls.Clear();
            _Load();
        }

        private void picShowStudent_Paint(object sender, PaintEventArgs e)
        {
            AllUser.PanitEvent(e, "Show", "Microsoft Sans Serif", 14, Brushes.Black, new Point(2, 2));
        }

        private void picAddNewStudent_Paint(object sender, PaintEventArgs e)
        {
            AllUser.PanitEvent(e, "Add", "Microsoft Sans Serif", 14, Brushes.Black, new Point(2, 2));
        }

        private void picShowStudent_Click(object sender, EventArgs e)
        {
            panelFormControl.Controls.Clear();
            _Load();
        }

        private void picAddNewStudent_Click(object sender, EventArgs e)
        {
            picAddNewStudent.BackColor = Color.LightGray;
            picShowStudent.BackColor = Color.Gray;

            panelFormControl.Controls.Clear();
            AllUser.OpenChildForm(addStudent, panelFormControl);
        }
    }
}
