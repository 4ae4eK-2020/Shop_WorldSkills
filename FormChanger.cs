namespace Shop_WorldSkills
{
    public enum FormType
    {
        Registration,
        Authorization,
        ChooseWhatChange,
        Categoryes,
        Orders,
        Products
    }
    public partial class FormChanger
    {
        public void VisitLink(FormType form)
        {
            switch (form)
            {
                case FormType.Registration:
                    Form1 form1 = new Form1();
                    form1.Show();
                    break;

                case FormType.Authorization:
                    Form2 form2 = new Form2();
                    form2.Show();
                    break;

                case FormType.ChooseWhatChange:
                    Form3 form3 = new Form3();
                    form3.Show();
                    break;

                case FormType.Categoryes:
                    Categoryes_Change category = new Categoryes_Change();
                    category.Show();
                    break;

                case FormType.Orders:
                    Orders_Change order = new Orders_Change();
                    order.Show();
                    break;

                case FormType.Products:
                    Products_Change product = new Products_Change();
                    product.Show();
                    break;
            }
        }
    }
}
