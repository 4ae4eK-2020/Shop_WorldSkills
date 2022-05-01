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
    public partial class Form3 : Form
    {
        FormChanger formChanger = new FormChanger();

        public Form3()
        {
            InitializeComponent();
        }

        private void Category_Click(object sender, EventArgs e)
        {
            formChanger.VisitLink(FormType.Categoryes);
        }

        private void Product_Click(object sender, EventArgs e)
        {
            formChanger.VisitLink(FormType.Products);
        }

        private void Order_Click(object sender, EventArgs e)
        {
            formChanger.VisitLink(FormType.Orders);
        }
    }
}
