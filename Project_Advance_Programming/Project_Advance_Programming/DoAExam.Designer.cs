namespace Project_Advance_Programming
{
    partial class DoAExam
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
            this.bExit = new System.Windows.Forms.Button();
            this.bSTART = new System.Windows.Forms.Button();
            this.tbCodeExam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(350, 321);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(90, 31);
            this.bExit.TabIndex = 8;
            this.bExit.Text = "EXIT";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bSTART
            // 
            this.bSTART.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSTART.Location = new System.Drawing.Point(350, 239);
            this.bSTART.Name = "bSTART";
            this.bSTART.Size = new System.Drawing.Size(90, 31);
            this.bSTART.TabIndex = 7;
            this.bSTART.Text = "START";
            this.bSTART.UseVisualStyleBackColor = true;
            this.bSTART.Click += new System.EventHandler(this.bSTART_Click);
            // 
            // tbCodeExam
            // 
            this.tbCodeExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodeExam.Location = new System.Drawing.Point(292, 163);
            this.tbCodeExam.Name = "tbCodeExam";
            this.tbCodeExam.Size = new System.Drawing.Size(206, 29);
            this.tbCodeExam.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter the code to perform the exam ";
            // 
            // DoAExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bSTART);
            this.Controls.Add(this.tbCodeExam);
            this.Controls.Add(this.label2);
            this.Name = "DoAExam";
            this.Text = "DoAExam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bSTART;
        private System.Windows.Forms.TextBox tbCodeExam;
        private System.Windows.Forms.Label label2;
    }
}