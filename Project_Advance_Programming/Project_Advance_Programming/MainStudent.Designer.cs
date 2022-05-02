namespace Project_Advance_Programming
{
    partial class MainStudent
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
            this.BProfile = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.linkDoAExam = new System.Windows.Forms.LinkLabel();
            this.dgvEXAM_STUDENT = new System.Windows.Forms.DataGridView();
            this.labelWelcomeStudent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEXAM_STUDENT)).BeginInit();
            this.SuspendLayout();
            // 
            // BProfile
            // 
            this.BProfile.Location = new System.Drawing.Point(362, 384);
            this.BProfile.Name = "BProfile";
            this.BProfile.Size = new System.Drawing.Size(75, 23);
            this.BProfile.TabIndex = 9;
            this.BProfile.Text = "Profile";
            this.BProfile.UseVisualStyleBackColor = true;
            this.BProfile.Click += new System.EventHandler(this.BProfile_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(629, 384);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 23);
            this.bExit.TabIndex = 8;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // linkDoAExam
            // 
            this.linkDoAExam.AutoSize = true;
            this.linkDoAExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDoAExam.Location = new System.Drawing.Point(100, 387);
            this.linkDoAExam.Name = "linkDoAExam";
            this.linkDoAExam.Size = new System.Drawing.Size(81, 16);
            this.linkDoAExam.TabIndex = 7;
            this.linkDoAExam.TabStop = true;
            this.linkDoAExam.Text = "Do a exam...";
            this.linkDoAExam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDoAExam_LinkClicked);
            // 
            // dgvEXAM_STUDENT
            // 
            this.dgvEXAM_STUDENT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEXAM_STUDENT.Location = new System.Drawing.Point(103, 119);
            this.dgvEXAM_STUDENT.Name = "dgvEXAM_STUDENT";
            this.dgvEXAM_STUDENT.Size = new System.Drawing.Size(601, 226);
            this.dgvEXAM_STUDENT.TabIndex = 6;
            // 
            // labelWelcomeStudent
            // 
            this.labelWelcomeStudent.AutoSize = true;
            this.labelWelcomeStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeStudent.Location = new System.Drawing.Point(285, 26);
            this.labelWelcomeStudent.Name = "labelWelcomeStudent";
            this.labelWelcomeStudent.Size = new System.Drawing.Size(203, 29);
            this.labelWelcomeStudent.TabIndex = 5;
            this.labelWelcomeStudent.Text = "Welcome Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Your exam grades";
            // 
            // MainStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BProfile);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.linkDoAExam);
            this.Controls.Add(this.dgvEXAM_STUDENT);
            this.Controls.Add(this.labelWelcomeStudent);
            this.Name = "MainStudent";
            this.Text = "MainStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEXAM_STUDENT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BProfile;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.LinkLabel linkDoAExam;
        private System.Windows.Forms.DataGridView dgvEXAM_STUDENT;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelWelcomeStudent;
    }
}