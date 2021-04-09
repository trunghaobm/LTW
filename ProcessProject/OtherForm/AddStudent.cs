using ProcessProject.DB_Access;
using ProcessProject.OtherClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessProject.OtherForm
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    picAvatar.Image = new Bitmap(open.FileName);
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void picAvatar_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Microsoft Sans Serif", 15))
            {
                e.Graphics.DrawString("Click to add a picture", myFont, Brushes.Gray, new Point(2, 2));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudenAccess stdac = new StudenAccess();
            try
            {
                student std = new student
                {
                    C01_id = int.Parse(txtID.Text),
                    C02_firtsname = txtFirstName.Text,
                    C03_lastname = txtLastName.Text,
                    C04_birthday = timeBirthday.Value,
                    C05_gender = radMale.Checked,
                    C06_phonenumber = txtPhone.Text,
                    C07_address = txtAddress.Text,
                    C08_avatar = new Binary(AllUser.ImageToBinary(picAvatar.Image))
                };
                stdac.Add(std);
                MessageBox.Show("Done");
                this.txtID.Text = "";
                this.txtFirstName.Text = "";
                this.txtLastName.Text = "";
                this.timeBirthday.Value = DateTime.Today;
                this.radMale.Checked = true;
                this.txtPhone.Text = "";
                this.txtAddress.Text = "";
                this.picAvatar.Image = null;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
