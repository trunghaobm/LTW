
namespace ProcessProject.OtherForm
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelFormControl = new System.Windows.Forms.Panel();
            this.panelBarControl = new System.Windows.Forms.Panel();
            this.picAddNewStudent = new System.Windows.Forms.PictureBox();
            this.picShowStudent = new System.Windows.Forms.PictureBox();
            this.panelBarControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormControl
            // 
            this.panelFormControl.BackColor = System.Drawing.Color.LightGray;
            this.panelFormControl.Location = new System.Drawing.Point(0, 25);
            this.panelFormControl.Name = "panelFormControl";
            this.panelFormControl.Size = new System.Drawing.Size(880, 575);
            this.panelFormControl.TabIndex = 1;
            // 
            // panelBarControl
            // 
            this.panelBarControl.BackColor = System.Drawing.Color.Gray;
            this.panelBarControl.Controls.Add(this.picAddNewStudent);
            this.panelBarControl.Controls.Add(this.picShowStudent);
            this.panelBarControl.Location = new System.Drawing.Point(0, 0);
            this.panelBarControl.Name = "panelBarControl";
            this.panelBarControl.Size = new System.Drawing.Size(880, 25);
            this.panelBarControl.TabIndex = 0;
            // 
            // picAddNewStudent
            // 
            this.picAddNewStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddNewStudent.Location = new System.Drawing.Point(75, 0);
            this.picAddNewStudent.Name = "picAddNewStudent";
            this.picAddNewStudent.Size = new System.Drawing.Size(75, 25);
            this.picAddNewStudent.TabIndex = 1;
            this.picAddNewStudent.TabStop = false;
            this.picAddNewStudent.Click += new System.EventHandler(this.picAddNewStudent_Click);
            this.picAddNewStudent.Paint += new System.Windows.Forms.PaintEventHandler(this.picAddNewStudent_Paint);
            // 
            // picShowStudent
            // 
            this.picShowStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShowStudent.Location = new System.Drawing.Point(0, 0);
            this.picShowStudent.Name = "picShowStudent";
            this.picShowStudent.Size = new System.Drawing.Size(75, 25);
            this.picShowStudent.TabIndex = 0;
            this.picShowStudent.TabStop = false;
            this.picShowStudent.Click += new System.EventHandler(this.picShowStudent_Click);
            this.picShowStudent.Paint += new System.Windows.Forms.PaintEventHandler(this.picShowStudent_Paint);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(880, 600);
            this.Controls.Add(this.panelBarControl);
            this.Controls.Add(this.panelFormControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panelBarControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFormControl;
        private System.Windows.Forms.Panel panelBarControl;
        private System.Windows.Forms.PictureBox picShowStudent;
        private System.Windows.Forms.PictureBox picAddNewStudent;
    }
}