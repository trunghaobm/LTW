using ProcessProject.DB_Access;
using ProcessProject.OtherClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessProject.OtherForm
{
    public partial class ShowStudent : Form
    {
        private StudenAccess student = new StudenAccess();
        private Find search = new Find();
        private EditStudent std = new EditStudent();
        private myDBDataContext db = new myDBDataContext();
        DataGridViewImageColumn avt = new DataGridViewImageColumn();

        public ShowStudent()
        {
            InitializeComponent();
        }

        private void _Load()
        {
            //var img = (from image in db.students
            //           select image);

            dgvShowStudent.DataSource = student.getAllStudents();

            //foreach (var imgi in img)
            //{
            //    avt.Image = AllUser.byteArrayToImage(imgi.C08_avatar.ToArray());
            //}
            //avt.HeaderText = "Image";
            //avt.Name = "img";
            //avt.Width = 100;
            //dgvShowStudent.Columns.Add(avt);
        }

        private void _Load(string key)
        {
            dgvShowStudent.DataSource = student.getStudents(key);        
        }

        private void ShowStudent_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void dgvShowStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvShowStudent.CurrentCell.RowIndex;
            std = new EditStudent(int.Parse(dgvShowStudent.Rows[index].Cells[0].Value.ToString()));
            AllUser.OpenChildForm(std, panelFormControl);
            _Load();
        }

        private void picReload_Click(object sender, EventArgs e)
        {
            this.panelFormControl.Controls.Remove(dgvShowStudent);
            this.panelFormControl.Controls.Add(dgvShowStudent);
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            search.ShowDialog();
            _Load(search.txtSearch.Text);
        }
    }
}
