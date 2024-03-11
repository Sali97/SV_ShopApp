using SV_ShopApp.Model;
using SV_ShopApp.ModelView;
using System.ComponentModel;

namespace SV_ShopApp
{
    public partial class Form1 : Form
    {
        InputValidator inputValid = new InputValidator();
        ProductServices theProdService;
        BindingList<Product> bindProdList;

        public Form1()
        {
            theProdService = new ProductServices(this);
            InitializeComponent();
        }



        public void deleteProduct(Product deleteProduct, int count)
        {
            theProdService.deleteProduct(deleteProduct, count);
            refresh();
        }

        public void addMultiProd(Product theProd)
        {
            theProdService.NewProduct(theProd.Id, theProd.Quantity);
            refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            theProdService.NewProduct("0001", 1);
            theProdService.NewProduct("0002", 2);
            theProdService.NewProduct("0005", 8);
            theProdService.NewProduct("0004", 11);
            theProdService.NewProduct("0003", 3);
            theProdService.NewProduct("0002", 5);
            theProdService.NewProduct("0001", 2);
            refresh();

            InitializeDataGrid();
            //InitizalizeBindings();
        }

        private void InitizalizeBindings()
        {
            bindProdList = theProdService.getList();
            dataGridView1.DataSource = bindProdList;
        }

        private void InitializeDataGrid()
        {
            if (dataGridView1.Columns.Contains("Törlés"))
            {
                dataGridView1.Columns.Remove("Törlés");
            }
            //Adatok megjelenítésének felhasználóbaráttá tétele
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Name"].HeaderText = "Terméknév";
            dataGridView1.Columns["Quantity"].HeaderText = "db";
            dataGridView1.Columns["Price"].HeaderText = "Egységár (HUF)";
            dataGridView1.Columns["SumPrice"].HeaderText = "Ár (HUF)";

            //Törlés gomb hozzáadása
            dataGridView1.Columns.Add(generateDelButton());
        }

        public void refresh()
        {
            getListToDataGrid();

            lblAllSumPrice.Text = theProdService.getAllSumPrice().ToString();
        }

        public void getListToDataGrid()
        {
            dataGridView1.DataSource = null;

            //Adatok bekérése a táblába
            dataGridView1.DataSource = theProdService.getList();
            InitializeDataGrid();
        }

        public DataGridViewButtonColumn generateDelButton()
        {
            DataGridViewButtonColumn dataGridDelBtn = new DataGridViewButtonColumn();
            dataGridDelBtn.Name = "Törlés";
            dataGridDelBtn.Text = "Törlés";
            dataGridDelBtn.UseColumnTextForButtonValue = true;
            dataGridDelBtn.HeaderText = "";

            return dataGridDelBtn;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Törlés gomb "Click" esemény beállítása 
            RowIndex>0,mert ha nem akkor címsorra is reagál, mely hibát dob ki*/
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                if (dataGridView1[e.ColumnIndex, e.RowIndex].Value == "Törlés")
                {
                    Product rowProduct = theProdService.searchProduct(dataGridView1[0, e.RowIndex].Value.ToString());

                    Form DeleteForm = new deleteForm(rowProduct, this);
                    DeleteForm.ShowDialog();
                }
            }
        }

        private void btnMultiAdd_Click(object sender, EventArgs e)
        {
            Form MultiAddForm = new MultiAddForm(this);
            MultiAddForm.ShowDialog();

            refresh();
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (inputValid.checkInput(textBox1.Text))
                {
                    theProdService.NewProduct(textBox1.Text, 1);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Hiba a termékkód megadásánál!");
                }
                textBox1.Clear();
            }
        }
    }
}