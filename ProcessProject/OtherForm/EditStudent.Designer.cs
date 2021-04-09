
namespace ProcessProject.OtherForm
{
    partial class EditStudent
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
            this.bynCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.panelGender = new System.Windows.Forms.Panel();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.labelGender = new System.Windows.Forms.Label();
            this.timeBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelAvatar = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSaveDoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panelGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // bynCancel
            // 
            this.bynCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bynCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bynCancel.ForeColor = System.Drawing.Color.Black;
            this.bynCancel.Location = new System.Drawing.Point(735, 516);
            this.bynCancel.Name = "bynCancel";
            this.bynCancel.Size = new System.Drawing.Size(121, 43);
            this.bynCancel.TabIndex = 36;
            this.bynCancel.Text = "Cancel";
            this.bynCancel.UseVisualStyleBackColor = true;
            this.bynCancel.Click += new System.EventHandler(this.bynCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(735, 369);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 43);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(40, 18);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(162, 31);
            this.labelHeader.TabIndex = 34;
            this.labelHeader.Text = "Edit Student";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.White;
            this.picAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAvatar.Location = new System.Drawing.Point(461, 341);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(218, 218);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 33;
            this.picAvatar.TabStop = false;
            this.picAvatar.Click += new System.EventHandler(this.picAvatar_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(461, 189);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(395, 114);
            this.txtAddress.TabIndex = 32;
            this.txtAddress.Text = "";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(461, 113);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(395, 38);
            this.txtPhone.TabIndex = 31;
            // 
            // panelGender
            // 
            this.panelGender.Controls.Add(this.radFemale);
            this.panelGender.Controls.Add(this.radMale);
            this.panelGender.Controls.Add(this.labelGender);
            this.panelGender.Location = new System.Drawing.Point(25, 385);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(233, 84);
            this.panelGender.TabIndex = 30;
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
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(9, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(104, 31);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Gender";
            // 
            // timeBirthday
            // 
            this.timeBirthday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeBirthday.CustomFormat = "MMM-dd-yyyy";
            this.timeBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeBirthday.Location = new System.Drawing.Point(40, 341);
            this.timeBirthday.Name = "timeBirthday";
            this.timeBirthday.Size = new System.Drawing.Size(218, 38);
            this.timeBirthday.TabIndex = 29;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(40, 265);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(395, 38);
            this.txtLastName.TabIndex = 28;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(40, 189);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(395, 38);
            this.txtFirstName.TabIndex = 27;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(40, 113);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(395, 38);
            this.txtID.TabIndex = 26;
            // 
            // labelAvatar
            // 
            this.labelAvatar.AutoSize = true;
            this.labelAvatar.Location = new System.Drawing.Point(455, 306);
            this.labelAvatar.Name = "labelAvatar";
            this.labelAvatar.Size = new System.Drawing.Size(93, 31);
            this.labelAvatar.TabIndex = 25;
            this.labelAvatar.Text = "Avatar";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(455, 154);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(114, 31);
            this.labelAddress.TabIndex = 24;
            this.labelAddress.Text = "Address";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(455, 79);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(190, 31);
            this.labelPhone.TabIndex = 23;
            this.labelPhone.Text = "Phone number";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(34, 306);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(114, 31);
            this.labelBirthday.TabIndex = 22;
            this.labelBirthday.Text = "Birthday";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(34, 230);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(145, 31);
            this.labelLastName.TabIndex = 21;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(34, 154);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(142, 31);
            this.labelFirstName.TabIndex = 20;
            this.labelFirstName.Text = "First name";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(34, 79);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(42, 31);
            this.labelID.TabIndex = 19;
            this.labelID.Text = "ID";
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(735, 467);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(121, 43);
            this.btnRemove.TabIndex = 37;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSaveDoc
            // 
            this.btnSaveDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDoc.Location = new System.Drawing.Point(735, 418);
            this.btnSaveDoc.Name = "btnSaveDoc";
            this.btnSaveDoc.Size = new System.Drawing.Size(121, 43);
            this.btnSaveDoc.TabIndex = 38;
            this.btnSaveDoc.Text = "Save to .doc";
            this.btnSaveDoc.UseVisualStyleBackColor = true;
            this.btnSaveDoc.Click += new System.EventHandler(this.btnSaveDoc_Click);
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(880, 575);
            this.Controls.Add(this.btnSaveDoc);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.bynCancel);
            this.Controls.Add(this.btnEdit);
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
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "EditStudent";
            this.Text = "EditStudent";
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bynCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.DateTimePicker timeBirthday;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labelAvatar;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSaveDoc;
    }
}