
namespace ProcessProject.OtherForm
{
    partial class AddStudent
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelAvatar = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.timeBirthday = new System.Windows.Forms.DateTimePicker();
            this.panelGender = new System.Windows.Forms.Panel();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bynCancel = new System.Windows.Forms.Button();
            this.panelGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 74);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(42, 31);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(12, 149);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(142, 31);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(12, 225);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(145, 31);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(12, 301);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(114, 31);
            this.labelBirthday.TabIndex = 3;
            this.labelBirthday.Text = "Birthday";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(9, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(104, 31);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Gender";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(433, 74);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(190, 31);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "Phone number";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(433, 149);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(114, 31);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "Address";
            // 
            // labelAvatar
            // 
            this.labelAvatar.AutoSize = true;
            this.labelAvatar.Location = new System.Drawing.Point(433, 301);
            this.labelAvatar.Name = "labelAvatar";
            this.labelAvatar.Size = new System.Drawing.Size(93, 31);
            this.labelAvatar.TabIndex = 7;
            this.labelAvatar.Text = "Avatar";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(18, 108);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(395, 38);
            this.txtID.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(18, 184);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(395, 38);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(18, 260);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(395, 38);
            this.txtLastName.TabIndex = 10;
            // 
            // timeBirthday
            // 
            this.timeBirthday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeBirthday.CustomFormat = "MMM-dd-yyyy";
            this.timeBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeBirthday.Location = new System.Drawing.Point(18, 336);
            this.timeBirthday.Name = "timeBirthday";
            this.timeBirthday.Size = new System.Drawing.Size(218, 38);
            this.timeBirthday.TabIndex = 11;
            // 
            // panelGender
            // 
            this.panelGender.Controls.Add(this.radFemale);
            this.panelGender.Controls.Add(this.radMale);
            this.panelGender.Controls.Add(this.labelGender);
            this.panelGender.Location = new System.Drawing.Point(3, 380);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(233, 84);
            this.panelGender.TabIndex = 12;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(106, 35);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(122, 35);
            this.radFemale.TabIndex = 6;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Location = new System.Drawing.Point(10, 35);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(90, 35);
            this.radMale.TabIndex = 5;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(439, 108);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(395, 38);
            this.txtPhone.TabIndex = 13;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(439, 184);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(395, 114);
            this.txtAddress.TabIndex = 14;
            this.txtAddress.Text = "";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.White;
            this.picAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAvatar.Location = new System.Drawing.Point(439, 336);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(218, 218);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 15;
            this.picAvatar.TabStop = false;
            this.picAvatar.Click += new System.EventHandler(this.picAvatar_Click);
            this.picAvatar.Paint += new System.Windows.Forms.PaintEventHandler(this.picAvatar_Paint);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(18, 13);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(163, 31);
            this.labelHeader.TabIndex = 16;
            this.labelHeader.Text = "Add Student";
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(713, 462);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 43);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bynCancel
            // 
            this.bynCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bynCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bynCancel.ForeColor = System.Drawing.Color.Black;
            this.bynCancel.Location = new System.Drawing.Point(713, 511);
            this.bynCancel.Name = "bynCancel";
            this.bynCancel.Size = new System.Drawing.Size(121, 43);
            this.bynCancel.TabIndex = 18;
            this.bynCancel.Text = "Cancel";
            this.bynCancel.UseVisualStyleBackColor = true;
            this.bynCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(880, 575);
            this.Controls.Add(this.bynCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.panelGender);
            this.Controls.Add(this.timeBirthday);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelAvatar);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelAvatar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker timeBirthday;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button bynCancel;
    }
}