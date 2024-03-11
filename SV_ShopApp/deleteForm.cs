using SV_ShopApp.Model;

namespace SV_ShopApp
{
    public partial class deleteForm : Form
    {
        Form1 MainForm;
        Product gdelProduct;

        public deleteForm(Product deleteProduct, Form1 Form1)
        {
            String formName = "Termék törlése - ";
            String lblText = "Mekkora mennyiség vásárlását szeretné visszavonni a " + deleteProduct.Quantity.ToString() + " " + deleteProduct.Name + "(-ból/-ből)?";

            InitializeComponent();
            this.Text = formName + deleteProduct.Name + "[" + deleteProduct.Quantity + "]";
            setLabelText(lblText);

            MainForm = Form1;
            gdelProduct = deleteProduct;

            if (gdelProduct.Quantity == 1)
            {
                btnDelOne.Enabled = false;
            }
            else
            {
                btnDelOne.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setLabelText(string lblText)
        {
            lblMessage.Text = lblText;
        }

        private void btnDelOne_Click(object sender, EventArgs e)
        {
            deleteMessageShow("Biztosan törölni szeretne egy egységet a termékből?", 1);
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            deleteMessageShow("Biztosan törölni szeretné az említett terméket?", -1);
        }

        private void deleteMessageShow(String delText, int delCode)
        {
            DialogResult dialogResult = MessageBox.Show(delText, this.Text, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (delCode > 0)
                {
                    MainForm.deleteProduct(gdelProduct, 1);
                }
                else
                {
                    MainForm.deleteProduct(gdelProduct, -1);
                }
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}
