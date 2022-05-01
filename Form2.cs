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
    public partial class Form2 : Form
    {
        FormChanger formChanger = new FormChanger();
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 f)
        {
            InitializeComponent();
        }

        private void Authorization_Click(object sender, EventArgs e)
        {
            using(UsersContext db = new UsersContext())
            {
                try
                {
                    UserStruct user = db.UserStructs.Where(u => u.Email == Email_TextBox.Text).FirstOrDefault();

                    if (user != null)
                    {
                        if(user.Password == Password_TextBox.Text)
                        {
                            formChanger.VisitLink(FormType.ChooseWhatChange);
                        }
                        else
                        {
                            MessageBox.Show("Неверный пароль");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Данный email не зарегистрирован");
                    }
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка авторизации. Причина:\n" + ex.Message);
                }
            }
        }
    }
}
