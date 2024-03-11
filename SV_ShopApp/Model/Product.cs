namespace SV_ShopApp.Model
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int SumPrice { get; set; }

        public Product()
        {
            SumPrice = Quantity * Price;
        }
    }
}
