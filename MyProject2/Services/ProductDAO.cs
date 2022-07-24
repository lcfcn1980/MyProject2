using MyProject2.Models;
using MySql.Data.MySqlClient;

namespace MyProject2.Services
{
    public class ProductDAO : iProductDataService
    {
        string connectionString = "server=YOURSERVER;user=YOURUSERID;password=YOURPASSWORD;database=YOURDATABASE";

        public int Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            List<ProductModel> foundProducts = new List<ProductModel>();
            string sqlStatement = "SELECT ID, ProductCode, PRICE, OWNER FROM dbo.Products";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(sqlStatement, connection);
                try
                {
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        foundProducts.Add(new ProductModel { Id = (int)reader[0], ProductCode = (string)reader[1], Price = (decimal)reader[2], Owner = (string)reader[3] });
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return foundProducts;
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
