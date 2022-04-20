
namespace Shop_WorldSkills
{
    partial class Form2
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
            this.Password_Label = new System.Windows.Forms.Label();
            this.Email_Label = new System.Windows.Forms.Label();
            this.Password_Exception_Label = new System.Windows.Forms.Label();
            this.Email_Exception_Label = new System.Windows.Forms.Label();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.Authorization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Font = new System.Drawing.Font("Consolas", 14F);
            this.Password_Label.Location = new System.Drawing.Point(12, 255);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(90, 28);
            this.Password_Label.TabIndex = 5;
            this.Password_Label.Text = "Пароль";
            // 
            // Email_Label
            // 
            this.Email_Label.AutoSize = true;
            this.Email_Label.Font = new System.Drawing.Font("Consolas", 14F);
            this.Email_Label.Location = new System.Drawing.Point(12, 200);
            this.Email_Label.Name = "Email_Label";
            this.Email_Label.Size = new System.Drawing.Size(233, 28);
            this.Email_Label.TabIndex = 6;
            this.Email_Label.Text = "Электронная почта";
            // 
            // Password_Exception_Label
            // 
            this.Password_Exception_Label.AutoSize = true;
            this.Password_Exception_Label.Font = new System.Drawing.Font("Consolas", 14F);
            this.Password_Exception_Label.ForeColor = System.Drawing.Color.Red;
            this.Password_Exception_Label.Location = new System.Drawing.Point(108, 255);
            this.Password_Exception_Label.Name = "Password_Exception_Label";
            this.Password_Exception_Label.Size = new System.Drawing.Size(0, 28);
            this.Password_Exception_Label.TabIndex = 7;
            // 
            // Email_Exception_Label
            // 
            this.Email_Exception_Label.AutoSize = true;
            this.Email_Exception_Label.Font = new System.Drawing.Font("Consolas", 14F);
            this.Email_Exception_Label.ForeColor = System.Drawing.Color.Red;
            this.Email_Exception_Label.Location = new System.Drawing.Point(251, 200);
            this.Email_Exception_Label.Name = "Email_Exception_Label";
            this.Email_Exception_Label.Size = new System.Drawing.Size(0, 28);
            this.Email_Exception_Label.TabIndex = 8;
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Font = new System.Drawing.Font("Consolas", 14F);
            this.Password_TextBox.Location = new System.Drawing.Point(12, 280);
            this.Password_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(1200, 35);
            this.Password_TextBox.TabIndex = 3;
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.Font = new System.Drawing.Font("Consolas", 14F);
            this.Email_TextBox.Location = new System.Drawing.Point(12, 225);
            this.Email_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(1200, 35);
            this.Email_TextBox.TabIndex = 4;
            // 
            // Authorization
            // 
            this.Authorization.BackColor = System.Drawing.SystemColors.Info;
            this.Authorization.Font = new System.Drawing.Font("Consolas", 14F);
            this.Authorization.Location = new System.Drawing.Point(12, 421);
            this.Authorization.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Authorization.Name = "Authorization";
            this.Authorization.Size = new System.Drawing.Size(1200, 96);
            this.Authorization.TabIndex = 9;
            this.Authorization.Text = "Авторизация";
            this.Authorization.UseVisualStyleBackColor = false;
            this.Authorization.Click += new System.EventHandler(this.Authorization_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 673);
            this.Controls.Add(this.Authorization);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Email_Label);
            this.Controls.Add(this.Password_Exception_Label);
            this.Controls.Add(this.Email_Exception_Label);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Email_TextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label Email_Label;
        private System.Windows.Forms.Label Password_Exception_Label;
        private System.Windows.Forms.Label Email_Exception_Label;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.TextBox Email_TextBox;
        private System.Windows.Forms.Button Authorization;
    }
}