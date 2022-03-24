namespace Project_Advance_Programming
{
    partial class ForgotPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbSecretCode = new System.Windows.Forms.TextBox();
            this.bChangePassword = new System.Windows.Forms.Button();
            this.tbRepeatPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.lRepeatPassword = new System.Windows.Forms.Label();
            this.lNewPassword = new System.Windows.Forms.Label();
            this.bSaveChanges = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to recover the password?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "SecretCode:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(330, 123);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(262, 20);
            this.tbUserName.TabIndex = 3;
            // 
            // tbSecretCode
            // 
            this.tbSecretCode.Location = new System.Drawing.Point(330, 184);
            this.tbSecretCode.Name = "tbSecretCode";
            this.tbSecretCode.Size = new System.Drawing.Size(262, 20);
            this.tbSecretCode.TabIndex = 4;
            this.tbSecretCode.UseSystemPasswordChar = true;
            // 
            // bChangePassword
            // 
            this.bChangePassword.Location = new System.Drawing.Point(416, 230);
            this.bChangePassword.Name = "bChangePassword";
            this.bChangePassword.Size = new System.Drawing.Size(75, 23);
            this.bChangePassword.TabIndex = 5;
            this.bChangePassword.Text = "CHANGE";
            this.bChangePassword.UseVisualStyleBackColor = true;
            this.bChangePassword.Click += new System.EventHandler(this.bChangePassword_Click);
            // 
            // tbRepeatPassword
            // 
            this.tbRepeatPassword.Location = new System.Drawing.Point(330, 309);
            this.tbRepeatPassword.Name = "tbRepeatPassword";
            this.tbRepeatPassword.Size = new System.Drawing.Size(262, 20);
            this.tbRepeatPassword.TabIndex = 9;
            this.tbRepeatPassword.UseSystemPasswordChar = true;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(330, 250);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(262, 20);
            this.tbNewPassword.TabIndex = 8;
            this.tbNewPassword.UseSystemPasswordChar = true;
            // 
            // lRepeatPassword
            // 
            this.lRepeatPassword.AutoSize = true;
            this.lRepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRepeatPassword.Location = new System.Drawing.Point(195, 308);
            this.lRepeatPassword.Name = "lRepeatPassword";
            this.lRepeatPassword.Size = new System.Drawing.Size(126, 18);
            this.lRepeatPassword.TabIndex = 7;
            this.lRepeatPassword.Text = "RepeatPassword:";
            // 
            // lNewPassword
            // 
            this.lNewPassword.AutoSize = true;
            this.lNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNewPassword.Location = new System.Drawing.Point(212, 249);
            this.lNewPassword.Name = "lNewPassword";
            this.lNewPassword.Size = new System.Drawing.Size(109, 18);
            this.lNewPassword.TabIndex = 6;
            this.lNewPassword.Text = "NewPassword:";
            // 
            // bSaveChanges
            // 
            this.bSaveChanges.Location = new System.Drawing.Point(404, 355);
            this.bSaveChanges.Name = "bSaveChanges";
            this.bSaveChanges.Size = new System.Drawing.Size(111, 23);
            this.bSaveChanges.TabIndex = 10;
            this.bSaveChanges.Text = "SAVE CHANGES";
            this.bSaveChanges.UseVisualStyleBackColor = true;
            this.bSaveChanges.Click += new System.EventHandler(this.bSaveChanges_Click);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(27, 25);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(27, 23);
            this.bBack.TabIndex = 11;
            this.bBack.Text = "<";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bSaveChanges);
            this.Controls.Add(this.tbRepeatPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.lRepeatPassword);
            this.Controls.Add(this.lNewPassword);
            this.Controls.Add(this.bChangePassword);
            this.Controls.Add(this.tbSecretCode);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbSecretCode;
        private System.Windows.Forms.Button bChangePassword;
        private System.Windows.Forms.TextBox tbRepeatPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label lRepeatPassword;
        private System.Windows.Forms.Label lNewPassword;
        private System.Windows.Forms.Button bSaveChanges;
        private System.Windows.Forms.Button bBack;
    }
}