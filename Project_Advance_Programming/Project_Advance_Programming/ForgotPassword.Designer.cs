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
            this.bBack = new System.Windows.Forms.Button();
            this.bAccept = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lCorreo = new System.Windows.Forms.Label();
            this.lRecuperarcontrasenya = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // bAccept
            // 
            this.bAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.bAccept.Location = new System.Drawing.Point(294, 270);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(199, 33);
            this.bAccept.TabIndex = 15;
            this.bAccept.Text = "Accept";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbEmail.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbEmail.Location = new System.Drawing.Point(324, 217);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(226, 26);
            this.tbEmail.TabIndex = 14;
            this.tbEmail.Text = "Email...";
            // 
            // lCorreo
            // 
            this.lCorreo.AutoSize = true;
            this.lCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.lCorreo.Location = new System.Drawing.Point(224, 214);
            this.lCorreo.Name = "lCorreo";
            this.lCorreo.Size = new System.Drawing.Size(80, 29);
            this.lCorreo.TabIndex = 13;
            this.lCorreo.Text = "Email:";
            // 
            // lRecuperarcontrasenya
            // 
            this.lRecuperarcontrasenya.AutoSize = true;
            this.lRecuperarcontrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lRecuperarcontrasenya.Location = new System.Drawing.Point(240, 156);
            this.lRecuperarcontrasenya.Name = "lRecuperarcontrasenya";
            this.lRecuperarcontrasenya.Size = new System.Drawing.Size(299, 39);
            this.lRecuperarcontrasenya.TabIndex = 12;
            this.lRecuperarcontrasenya.Text = "Recover password";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lCorreo);
            this.Controls.Add(this.lRecuperarcontrasenya);
            this.Controls.Add(this.bBack);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lCorreo;
        private System.Windows.Forms.Label lRecuperarcontrasenya;
    }
}