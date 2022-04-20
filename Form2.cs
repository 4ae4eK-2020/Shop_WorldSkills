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
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 f)
        {
            InitializeComponent();

            f.BackColor = Color.Yellow;
        }

        private void Authorization_Click(object sender, EventArgs e)
        {
            using(UsersContext db = new UsersContext())
            {
                try
                {
                    User user = db.Users.Where(u => u.Email == Email_TextBox.Text && u.Password == Password_TextBox.Text).FirstOrDefault();

                    if (user != null)
                    {
                        MessageBox.Show($"Пользователь {Email_TextBox.Text} успешно авторизован.");
                    }
                    else
                    {
                        MessageBox.Show("Неверный email или пароль");
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
