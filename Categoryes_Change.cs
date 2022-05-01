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
    public partial class Categoryes_Change : Form
    {
        public Categoryes_Change()
        {
            InitializeComponent();
        }

        private void Categoryes_Change_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "categoryContext.Categoryes". При необходимости она может быть перемещена или удалена.
            this.categoryesTableAdapter.Fill(this.categoryContext.Categoryes);
        }

        private void OldCategoryNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewCategoryNameTextBox_TextChanged(object sender, EventArgs e)
        {
            using(CategoryContext db = new CategoryContext())
            {
               DataTableCollection col = db.Tables;
                MessageBox.Show(col[0].TableName);
            }
        }

        private void CreateSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
