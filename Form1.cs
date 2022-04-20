using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_WorldSkills
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            if (Email_TextBox.Text == "")
            {
                Email_Exception_Label.Text = "Это поле обязательно для заполнения";
            }
            else
            {
                Email_Exception_Label.Text = "";
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (Password_TextBox.Text == "")
            {
                Password_Exception_Label.Text = "Это поле обязательно для заполнения";
            }
            else
            {
                Password_Exception_Label.Text = "";
            }
        }

        private void Second_Pass_TextChanged(object sender, EventArgs e)
        {
            if (Second_Pass_TextBox.Text == "")
            {
                Second_Pass_Exception_Label.Text = "Это поле обязательно для заполнения";
            }
            else
            {
                Second_Pass_Exception_Label.Text = "";
            }

            if (Password_TextBox.Text != Second_Pass_TextBox.Text)
            {
                Second_Pass_Exception_Label.Text = "Пароли не совпадают";
            }
        }

        private void Authorization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно открыть дынную ссылку. Причина:\n" + ex.Message);
            }
        }

        private void Registry_Click(object sender, EventArgs e)
        {
            CheckEmail();
            using (UsersContext db = new UsersContext())
            {
                User user = new User { Email = Email_TextBox.Text, Password = Password_TextBox.Text };
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show($"Пользователь {db.Users.ToList().Last().Email} был добавлен");
            }
        }

        private bool CheckEmail()
        {

            bool canEmailUsed = false;
            using (UsersContext db = new UsersContext())
            {
                foreach (User user in db.Users)
                {
                    if (user.Email == Email_TextBox.Text)
                    {
                        canEmailUsed = false;
                    }
                    else
                    {
                        canEmailUsed = true;
                        return canEmailUsed;
                    }
                }
                return canEmailUsed;
            }
        }

        private void VisitLink()
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
        }
    }
}
