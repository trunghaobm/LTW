using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProcessProject.OtherClass;
using ProcessProject.OtherForm;
using ProcessProject.DB_Access;

namespace ProcessProject
{
    public partial class MainForm : Form
    {
        LoginForm login = new LoginForm();
        Student student = new Student();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            login.ShowDialog();
            if(login.accept == false)
            {
                this.Close();
            }
        }

        private void picStudentClick_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Microsoft Sans Serif", 25))
            {
                e.Graphics.DrawString("Sinh Viên", myFont, Brushes.Black, new Point(2, 2));
            }
        }

        private void picLoginClick_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Microsoft Sans Serif", 25))
            {
                e.Graphics.DrawString("Log in", myFont, Brushes.Black, new Point(2, 2));
            }
        }

        private void picLoginClick_Click(object sender, EventArgs e)
        {

            if (picLoginClick.BackColor == Color.Gray)
            {
                picLoginClick.BackColor = Color.LightGray;


                picStudentClick.BackColor = Color.Gray;
                panelFormControl.Controls.Clear();
                AllUser.OpenChildForm(login, panelFormControl);
            }
        }

        private void picStudentClick_Click(object sender, EventArgs e)
        {
            if (picStudentClick.BackColor == Color.Gray)
            {
                picStudentClick.BackColor = Color.LightGray;

                picLoginClick.BackColor = Color.Gray;
                panelFormControl.Controls.Clear();
                AllUser.OpenChildForm(student, panelFormControl);
            }
        }

        private void tmLog_Tick(object sender, EventArgs e)
        {
        }
    }
}
