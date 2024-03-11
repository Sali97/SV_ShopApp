using SV_ShopApp.Model;
using SV_ShopApp.ModelView;

namespace SV_ShopApp
{
    public partial class MultiAddForm : Form
    {
        SQLServices theSqlService = new SQLServices();
        InputValidator inputValid = new InputValidator();
        Form1 MainForm;
        Product theProduct = new Product();

        String formName = "Termék hozzáadása - ";

        public MultiAddForm(Form1 form1)
        {
            InitializeComponent();

            MainForm = form1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshProd()
        {
            theProduct.Id = textBox1.Text;
            theProduct.Quantity = Convert.ToInt32(numericUpDown1.Value);
            lblPrice.Text = (theProduct.Price * theProduct.Quantity).ToString();
            refreshTitle(theProduct.Name);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            refreshProd();

            MainForm.addMultiProd(theProduct);
            this.Close();
        }

        private void refreshTitle(String prodName)
        {
            this.Text = formName + prodName;
        }

        private void reset()
        {
            numericUpDown1.Enabled = false;
            btnAdd.Enabled = false;
            lblPrice.Text = "0";
            refreshTitle("");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (inputValid.checkInput(textBox1.Text))
            {
                theProduct = theSqlService.SQLsearchForID(textBox1.Text);
                if (theProduct.Name != null)
                {
                    numericUpDown1.Enabled = true;
                    btnAdd.Enabled = true;
                    refreshProd();
                }
                else
                {
                    reset();
                }
            }
            else
            {
                reset();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            refreshProd();
        }
    }
}
