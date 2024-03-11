using Microsoft.Data.Sqlite;
using SV_ShopApp.Model;
using SQLitePCL;
using System.Data;

namespace SV_ShopApp.ModelView
{

    public class SQLServices
    {
        public SQLServices()
        {
            Batteries.Init();
        }

        static String ProductTable = "tblProduct";
        static String CategoryTable = "tblCategory";

        static String AppPath = System.AppDomain.CurrentDomain.BaseDirectory;
        static String DbFilePath = AppPath + "\\Data\\dbTest.db";
        static SqliteConnection sqlCon = new SqliteConnection($"Data Source={DbFilePath};");
       
        public Product SQLsearchForID(String  prodID)
        {
            Product FoundedProduct = new Product();

            sqlCon.Open();
            
                String query = "SELECT Id,Name,Price FROM " + ProductTable + " WHERE Id=@id";
                SqliteCommand sqlCmd = new SqliteCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@id", prodID);

                SqliteDataReader read = sqlCmd.ExecuteReader();

                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        FoundedProduct.Id = read.GetValue(0).ToString();
                        FoundedProduct.Name = read.GetValue(1).ToString();
                        FoundedProduct.Price = Convert.ToInt32(read.GetValue(2).ToString());
                    }
                }
                read.Close();

            Console.WriteLine(FoundedProduct.Id + " "+ FoundedProduct.Name + " " + FoundedProduct.Price.ToString());

            sqlCon.Close();
            return FoundedProduct;
        }
    }
}
