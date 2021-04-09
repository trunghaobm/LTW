
namespace ProcessProject
{
    partial class MainForm
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
            this.panelTab = new System.Windows.Forms.Panel();
            this.picLoginClick = new System.Windows.Forms.PictureBox();
            this.picStudentClick = new System.Windows.Forms.PictureBox();
            this.panelFormControl = new System.Windows.Forms.Panel();
            this.tmLog = new System.Windows.Forms.Timer(this.components);
            this.panelTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoginClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentClick)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTab
            // 
            this.panelTab.BackColor = System.Drawing.Color.Gray;
            this.panelTab.Controls.Add(this.picLoginClick);
            this.panelTab.Controls.Add(this.picStudentClick);
            this.panelTab.Location = new System.Drawing.Point(0, 0);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(200, 600);
            this.panelTab.TabIndex = 0;
            // 
            // picLoginClick
            // 
            this.picLoginClick.BackColor = System.Drawing.Color.Gray;
            this.picLoginClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLoginClick.Location = new System.Drawing.Point(0, 550);
            this.picLoginClick.Name = "picLoginClick";
            this.picLoginClick.Size = new System.Drawing.Size(200, 50);
            this.picLoginClick.TabIndex = 0;
            this.picLoginClick.TabStop = false;
            this.picLoginClick.Visible = false;
            this.picLoginClick.Click += new System.EventHandler(this.picLoginClick_Click);
            this.picLoginClick.Paint += new System.Windows.Forms.PaintEventHandler(this.picLoginClick_Paint);
            // 
            // picStudentClick
            // 
            this.picStudentClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStudentClick.Location = new System.Drawing.Point(0, 150);
            this.picStudentClick.Name = "picStudentClick";
            this.picStudentClick.Size = new System.Drawing.Size(200, 50);
            this.picStudentClick.TabIndex = 0;
            this.picStudentClick.TabStop = false;
            this.picStudentClick.Click += new System.EventHandler(this.picStudentClick_Click);
            this.picStudentClick.Paint += new System.Windows.Forms.PaintEventHandler(this.picStudentClick_Paint);
            // 
            // panelFormControl
            // 
            this.panelFormControl.BackColor = System.Drawing.Color.LightGray;
            this.panelFormControl.Location = new System.Drawing.Point(200, 0);
            this.panelFormControl.Name = "panelFormControl";
            this.panelFormControl.Size = new System.Drawing.Size(880, 600);
            this.panelFormControl.TabIndex = 1;
            // 
            // tmLog
            // 
            this.tmLog.Tick += new System.EventHandler(this.tmLog_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.Controls.Add(this.panelFormControl);
            this.Controls.Add(this.panelTab);
            this.Name = "MainForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLoginClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentClick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.Panel panelFormControl;
        private System.Windows.Forms.PictureBox picStudentClick;
        private System.Windows.Forms.PictureBox picLoginClick;
        private System.Windows.Forms.Timer tmLog;
    }
}

