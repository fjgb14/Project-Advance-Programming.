namespace Project_Advance_Programming
{
    partial class MainProfessor
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
            this.lWelcomeProfessor = new System.Windows.Forms.Label();
            this.dgvEXAM_STUDENT = new System.Windows.Forms.DataGridView();
            this.linklCreateAExam = new System.Windows.Forms.LinkLabel();
            this.bExit = new System.Windows.Forms.Button();
            this.BProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEXAM_STUDENT)).BeginInit();
            this.SuspendLayout();
            // 
            // lWelcomeProfessor
            // 
            this.lWelcomeProfessor.AutoSize = true;
            this.lWelcomeProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWelcomeProfessor.Location = new System.Drawing.Point(302, 25);
            this.lWelcomeProfessor.Name = "lWelcomeProfessor";
            this.lWelcomeProfessor.Size = new System.Drawing.Size(225, 29);
            this.lWelcomeProfessor.TabIndex = 0;
            this.lWelcomeProfessor.Text = "Welcome Professor";
            // 
            // dgvEXAM_STUDENT
            // 
            this.dgvEXAM_STUDENT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEXAM_STUDENT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEXAM_STUDENT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEXAM_STUDENT.Location = new System.Drawing.Point(101, 101);
            this.dgvEXAM_STUDENT.Name = "dgvEXAM_STUDENT";
            this.dgvEXAM_STUDENT.Size = new System.Drawing.Size(601, 226);
            this.dgvEXAM_STUDENT.TabIndex = 1;
            // 
            // linklCreateAExam
            // 
            this.linklCreateAExam.AutoSize = true;
            this.linklCreateAExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklCreateAExam.Location = new System.Drawing.Point(101, 373);
            this.linklCreateAExam.Name = "linklCreateAExam";
            this.linklCreateAExam.Size = new System.Drawing.Size(103, 16);
            this.linklCreateAExam.TabIndex = 2;
            this.linklCreateAExam.TabStop = true;
            this.linklCreateAExam.Text = "Create a exam...";
            this.linklCreateAExam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklCreateAExam_LinkClicked);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(627, 366);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 23);
            this.bExit.TabIndex = 3;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // BProfile
            // 
            this.BProfile.Location = new System.Drawing.Point(363, 366);
            this.BProfile.Name = "BProfile";
            this.BProfile.Size = new System.Drawing.Size(75, 23);
            this.BProfile.TabIndex = 4;
            this.BProfile.Text = "Profile";
            this.BProfile.UseVisualStyleBackColor = true;
            this.BProfile.Click += new System.EventHandler(this.BProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "The grade of the students exam.";
            // 
            // MainProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BProfile);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.linklCreateAExam);
            this.Controls.Add(this.dgvEXAM_STUDENT);
            this.Controls.Add(this.lWelcomeProfessor);
            this.Name = "MainProfessor";
            this.Text = "MainProfessor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEXAM_STUDENT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEXAM_STUDENT;
        private System.Windows.Forms.LinkLabel linklCreateAExam;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button BProfile;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lWelcomeProfessor;
    }
}