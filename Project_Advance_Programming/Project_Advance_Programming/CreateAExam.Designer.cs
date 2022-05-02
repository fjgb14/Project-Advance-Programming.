namespace Project_Advance_Programming
{
    partial class CreateAExam
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
            this.bEXIT = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodeExam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNameExam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bEXIT
            // 
            this.bEXIT.Location = new System.Drawing.Point(106, 298);
            this.bEXIT.Name = "bEXIT";
            this.bEXIT.Size = new System.Drawing.Size(89, 33);
            this.bEXIT.TabIndex = 11;
            this.bEXIT.Text = "EXIT";
            this.bEXIT.UseVisualStyleBackColor = true;
            this.bEXIT.Click += new System.EventHandler(this.bEXIT_Click);
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(605, 298);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(89, 33);
            this.bNext.TabIndex = 10;
            this.bNext.Text = "NEXT";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Code Exam";
            // 
            // tbCodeExam
            // 
            this.tbCodeExam.Location = new System.Drawing.Point(279, 202);
            this.tbCodeExam.Name = "tbCodeExam";
            this.tbCodeExam.Size = new System.Drawing.Size(231, 20);
            this.tbCodeExam.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name Exam";
            // 
            // tbNameExam
            // 
            this.tbNameExam.Location = new System.Drawing.Point(279, 125);
            this.tbNameExam.Name = "tbNameExam";
            this.tbNameExam.Size = new System.Drawing.Size(231, 20);
            this.tbNameExam.TabIndex = 6;
            // 
            // CreateAExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bEXIT);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCodeExam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNameExam);
            this.Name = "CreateAExam";
            this.Text = "CreateAExam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEXIT;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodeExam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameExam;
    }
}