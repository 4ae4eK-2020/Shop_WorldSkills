
namespace Shop_WorldSkills
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Registry = new System.Windows.Forms.Button();
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.Second_Pass_TextBox = new System.Windows.Forms.TextBox();
            this.Email_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Second_Pass_Label = new System.Windows.Forms.Label();
            this.Authorization = new System.Windows.Forms.LinkLabel();
            this.Login_Exception_Label = new System.Windows.Forms.Label();
            this.Email_Exception_Label = new System.Windows.Forms.Label();
            this.Password_Exception_Label = new System.Windows.Forms.Label();
            this.Second_Pass_Exception_Label = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberExceprionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Registry
            // 
            this.Registry.BackColor = System.Drawing.SystemColors.Info;
            this.Registry.Font = new System.Drawing.Font("Consolas", 14F);
            this.Registry.Location = new System.Drawing.Point(10, 394);
            this.Registry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Registry.Name = "Registry";
            this.Registry.Size = new System.Drawing.Size(1200, 96);
            this.Registry.TabIndex = 0;
            this.Registry.Text = "Регистрация";
            this.Registry.UseVisualStyleBackColor = false;
            this.Registry.Click += new System.EventHandler(this.Registry_Click);
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.Font = new System.Drawing.Font("Consolas", 14F);
            this.Email_TextBox.Location = new System.Drawing.Point(15, 135);
            this.Email_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(1200, 35);
            this.Email_TextBox.TabIndex = 1;
            this.Email_TextBox.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Font = new System.Drawing.Font("Consolas", 14F);
            this.Password_TextBox.Location = new System.Drawing.Point(15, 190);
            this.Password_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(1200, 35);
            this.Password_TextBox.TabIndex = 1;
            this.Password_TextBox.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Second_Pass_TextBox
            // 
            this.Second_Pass_TextBox.Font = new System.Drawing.Font("Consolas", 14F);
            this.Second_Pass_TextBox.Location = new System.Drawing.Point(15, 245);
            this.Second_Pass_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Second_Pass_TextBox.Name = "Second_Pass_TextBox";
            this.Second_Pass_TextBox.Size = new System.Drawing.Size(1200, 35);
            this.Second_Pass_TextBox.TabIndex = 1;
            this.Second_Pass_TextBox.TextChanged += new System.EventHandler(this.Second_Pass_TextChanged);
            // 
            // Email_Label
            // 
            this.Email_Label.AutoSize = true;
            this.Email_Label.Font = new System.Drawing.Font("Consolas", 14F);
            this.Email_Label.Location = new System.Drawing.Point(15, 110);
            this.Email_Label.Name = "Email_Label";
            this.Email_Label.Size = new System.Drawing.Size(233, 28);
            this.Email_Label.TabIndex = 2;
            this.Email_Label.Text = "Электронная почта";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Font = new System.Drawing.Font("Consolas", 14F);
            this.Password_Label.Location = new System.Drawing.Point(15, 165);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(90, 28);
            this.Password_Label.TabIndex = 2;
            this.Password_Label.Text = "Пароль";
            // 
            // Second_Pass_Label
            // 
            this.Second_Pass_Label.AutoSize = true;
            this.Second_Pass_Label.Font = new System.Drawing.Font("Consolas", 14F);
            this.Second_Pass_Label.Location = new System.Drawing.Point(15, 221);
            this.Second_Pass_Label.Name = "Second_Pass_Label";
            this.Second_Pass_Label.Size = new System.Drawing.Size(220, 28);
            this.Second_Pass_Label.TabIndex = 2;
            this.Second_Pass_Label.Text = "Повторите пароль";
            // 
            // Authorization
            // 
            this.Authorization.AutoSize = true;
            this.Authorization.Font = new System.Drawing.Font("Consolas", 14F);
            this.Authorization.Location = new System.Drawing.Point(10, 350);
            this.Authorization.Name = "Authorization";
            this.Authorization.Size = new System.Drawing.Size(311, 28);
            this.Authorization.TabIndex = 3;
            this.Authorization.TabStop = true;
            this.Authorization.Text = "У меня уже есть аккаунт";
            this.Authorization.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Authorization_LinkClicked);
            // 
            // Login_Exception_Label
            // 
            this.Login_Exception_Label.AutoSize = true;
            this.Login_Exception_Label.Font = new System.Drawing.Font("Consolas", 14F);
            this.Login_Exception_Label.ForeColor = System.Drawing.Color.Red;
            this.Login_Exception_Label.Location = new System.Drawing.Point(93, 112);
            this.Login_Exception_Label.Name = "Login_Exception_Label";
            this.Login_Exception_Label.Size = new System.Drawing.Size(0, 28);
            this.Login_Exception_Label.TabIndex = 2;
            // 
            // Email_Exception_Label
            // 
            this.Email_Exception_Label.AutoSize = true;
            this.Email_Exception_Label.Font = new System.Drawing.Font("Consolas", 14F);
            this.Email_Exception_Label.ForeColor = System.Drawing.Color.Red;
            this.Email_Exception_Label.Location = new System.Drawing.Point(254, 110);
            this.Email_Exception_Label.Name = "Email_Exception_Label";
            this.Email_Exception_Label.Size = new System.Drawing.Size(0, 28);
            this.Email_Exception_Label.TabIndex = 2;
            // 
            // Password_Exception_Label
            // 
            this.Password_Exception_Label.AutoSize = true;
            this.Password_Exception_Label.Font = new System.Drawing.Font("Consolas", 14F);
            this.Password_Exception_Label.ForeColor = System.Drawing.Color.Red;
            this.Password_Exception_Label.Location = new System.Drawing.Point(111, 165);
            this.Password_Exception_Label.Name = "Password_Exception_Label";
            this.Password_Exception_Label.Size = new System.Drawing.Size(0, 28);
            this.Password_Exception_Label.TabIndex = 2;
            // 
            // Second_Pass_Exception_Label
            // 
            this.Second_Pass_Exception_Label.AutoSize = true;
            this.Second_Pass_Exception_Label.Font = new System.Drawing.Font("Consolas", 14F);
            this.Second_Pass_Exception_Label.ForeColor = System.Drawing.Color.Red;
            this.Second_Pass_Exception_Label.Location = new System.Drawing.Point(241, 221);
            this.Second_Pass_Exception_Label.Name = "Second_Pass_Exception_Label";
            this.Second_Pass_Exception_Label.Size = new System.Drawing.Size(0, 28);
            this.Second_Pass_Exception_Label.TabIndex = 2;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Consolas", 14F);
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(15, 306);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(1200, 35);
            this.PhoneNumberTextBox.TabIndex = 1;
            this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBox_Changed);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Consolas", 14F);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(15, 282);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(194, 28);
            this.PhoneNumberLabel.TabIndex = 2;
            this.PhoneNumberLabel.Text = "Номер телефона";
            // 
            // PhoneNumberExceprionLabel
            // 
            this.PhoneNumberExceprionLabel.AutoSize = true;
            this.PhoneNumberExceprionLabel.Font = new System.Drawing.Font("Consolas", 14F);
            this.PhoneNumberExceprionLabel.ForeColor = System.Drawing.Color.Red;
            this.PhoneNumberExceprionLabel.Location = new System.Drawing.Point(203, 282);
            this.PhoneNumberExceprionLabel.Name = "PhoneNumberExceprionLabel";
            this.PhoneNumberExceprionLabel.Size = new System.Drawing.Size(0, 28);
            this.PhoneNumberExceprionLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 538);
            this.Controls.Add(this.Authorization);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.Second_Pass_Label);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.Email_Label);
            this.Controls.Add(this.PhoneNumberExceprionLabel);
            this.Controls.Add(this.Second_Pass_Exception_Label);
            this.Controls.Add(this.Password_Exception_Label);
            this.Controls.Add(this.Email_Exception_Label);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.Login_Exception_Label);
            this.Controls.Add(this.Second_Pass_TextBox);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Email_TextBox);
            this.Controls.Add(this.Registry);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registry;
        private System.Windows.Forms.TextBox Email_TextBox;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.TextBox Second_Pass_TextBox;
        private System.Windows.Forms.Label Email_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label Second_Pass_Label;
        private System.Windows.Forms.LinkLabel Authorization;
        private System.Windows.Forms.Label Login_Exception_Label;
        private System.Windows.Forms.Label Email_Exception_Label;
        private System.Windows.Forms.Label Password_Exception_Label;
        private System.Windows.Forms.Label Second_Pass_Exception_Label;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label PhoneNumberExceprionLabel;
    }
}

