using MyProject2.Models;

namespace MyProject2.Services
{
    public interface iProductDataService
    {
        List<ProductModel> GetAllProducts();
        List<ProductModel> SearchProducts(string searchTerm);
        ProductModel GetProductById(int id);

        int Insert(ProductModel product);
        int Delete(ProductModel product);
        int Update(ProductModel product);
    }
}
