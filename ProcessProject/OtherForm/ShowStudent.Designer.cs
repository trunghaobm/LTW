
namespace ProcessProject.OtherForm
{
    partial class ShowStudent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowStudent));
            this.dgvShowStudent = new System.Windows.Forms.DataGridView();
            this.panelFormControl = new System.Windows.Forms.Panel();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.picReload = new System.Windows.Forms.PictureBox();
            this.timeSearch = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStudent)).BeginInit();
            this.panelFormControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowStudent
            // 
            this.dgvShowStudent.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvShowStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShowStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowStudent.Location = new System.Drawing.Point(0, 0);
            this.dgvShowStudent.Name = "dgvShowStudent";
            this.dgvShowStudent.Size = new System.Drawing.Size(880, 575);
            this.dgvShowStudent.TabIndex = 0;
            this.dgvShowStudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowStudent_CellDoubleClick);
            // 
            // panelFormControl
            // 
            this.panelFormControl.Controls.Add(this.picSearch);
            this.panelFormControl.Controls.Add(this.picReload);
            this.panelFormControl.Controls.Add(this.dgvShowStudent);
            this.panelFormControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormControl.Location = new System.Drawing.Point(0, 0);
            this.panelFormControl.Name = "panelFormControl";
            this.panelFormControl.Size = new System.Drawing.Size(880, 575);
            this.panelFormControl.TabIndex = 1;
            // 
            // picSearch
            // 
            this.picSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSearch.BackgroundImage")));
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(829, 550);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(25, 25);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 2;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // picReload
            // 
            this.picReload.Image = ((System.Drawing.Image)(resources.GetObject("picReload.Image")));
            this.picReload.Location = new System.Drawing.Point(855, 550);
            this.picReload.Name = "picReload";
            this.picReload.Size = new System.Drawing.Size(25, 25);
            this.picReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReload.TabIndex = 1;
            this.picReload.TabStop = false;
            this.picReload.Click += new System.EventHandler(this.picReload_Click);
            // 
            // timeSearch
            // 
            this.timeSearch.Interval = 1;
            // 
            // ShowStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(880, 575);
            this.Controls.Add(this.panelFormControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowStudent";
            this.Text = "ShowStudent";
            this.Load += new System.EventHandler(this.ShowStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStudent)).EndInit();
            this.panelFormControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelFormControl;
        private System.Windows.Forms.PictureBox picReload;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Timer timeSearch;
        public System.Windows.Forms.DataGridView dgvShowStudent;
    }
}