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
        FormChanger formChanger = new FormChanger();

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Form2 f)
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

        private void PhoneNumberTextBox_Changed(object sender, EventArgs e)
        {
            if (PhoneNumberTextBox.Text == "")
            {
                PhoneNumberExceprionLabel.Text = "Это поле обязательно для заполнения";
            }
            else
            {
                PhoneNumberExceprionLabel.Text = "";
            }
        }

        private void Authorization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                formChanger.VisitLink(FormType.Authorization);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно открыть дынную ссылку. Причина:\n" + ex.Message);
            }
        }

        private void Registry_Click(object sender, EventArgs e)
        {
            if (CheckEmail() == true)
            {
               UsersContext db = new UsersContext();
                
                    UserStruct user = new UserStruct
                    {
                        Email = Email_TextBox.Text,
                        Password = Password_TextBox.Text,
                        PhoneNumber = PhoneNumberTextBox.Text
                    };
                    db.UserStructs.Add(user);
                    db.SaveChanges();
                MessageBox.Show(user.id.ToString());
                //formChanger.VisitLink(FormType.ChooseWhatChange);

            }
            else
            {
                MessageBox.Show("Пользователь с данным email уже существует.Пожалуйста, авторизируйтесь или введите другой email.");
            }
            
        }

        private bool CheckEmail()
        {

            bool canEmailUsed = true;
            using (UsersContext db = new UsersContext())
            {
                foreach (UserStruct user in db.UserStructs)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
