using System.ComponentModel;
using System.Data;
using SV_ShopApp.Model;

namespace SV_ShopApp.ModelView
{
    

    public class ProductServices
    {

        Form1 MainForm;
        public int allSumPrice { get; set; }
        private static BindingList<Product> productList;
        SQLServices theSQLServices;


        public ProductServices(Form1 mainForm)
        {
            productList = new BindingList<Product>();
            productList.ListChanged += ProductList_ListChanged;
            MainForm = mainForm;
            theSQLServices = new SQLServices();
        }

        //Lista elemeinek változására össz érték frissítés
        private void ProductList_ListChanged(object? sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    getAllSumPrice();
                    break;
                case ListChangedType.ItemChanged:
                    getAllSumPrice();

                    break;
                case ListChangedType.ItemDeleted:
                    getAllSumPrice();

                    break;
                default:
                    break;
            }
            MainForm.refresh();
        }

        public void NewProduct(String Id, int Count)
        {
            Product newProduct = searchProduct(Id);
            if (newProduct != null)
            {
                newProduct.Quantity+=Count;
            }
            else {
               newProduct =  theSQLServices.SQLsearchForID(Id);
                if (newProduct.Name==null)
                {
                    MessageBox.Show("Hiba! Nem található termék ezzel a kóddal!");
                }
                else
                {
                    newProduct.Quantity = Count;
                    productList.Add(newProduct);
                } 
            }
            refreshSum(newProduct);

        }

        public BindingList<Product> getList()
        {
            return productList;
        }

        public Product searchProduct(string searchId)
        {
            try
            {
                    Product FoundedProduct = new Product();
                    FoundedProduct = productList.FirstOrDefault(FoundedProduct => FoundedProduct.Id == searchId);
                    return FoundedProduct;
            }
            catch (Exception e)
            {
                MessageBox.Show("Nem található ilyen termék.",Application.ProductName,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool deleteProduct(Product deleteProduct, int count)
        {
            bool isDeleted = false;
            Product checkProduct = searchProduct(deleteProduct.Id);
            if (checkProduct != null)
            {
                if (count ==-1)
                {
                    productList.Remove(checkProduct);
                }
                else if (count>0)
                {
                    checkProduct.Quantity -= count;
                    refreshSum(checkProduct);
                }

                isDeleted = true;
            }
            else
            {
               
            }
            return isDeleted;
        }

        public DataTable getDataTable()
        {
            DataTable dt = new DataTable();
            return dt;
        }

        private bool refreshSum(Product theProduct)
        {
            bool isRefreshed = false;

            //Termék összértékének kiszámítása
                theProduct.SumPrice = theProduct.Price * theProduct.Quantity;

            isRefreshed = true;
            return isRefreshed;
        }

        public int getAllSumPrice()
        {
            allSumPrice = 0;
            foreach (Product product in productList) {
                refreshSum(product);
                allSumPrice += product.SumPrice;
            }

            return allSumPrice;
        }
    } 
}

