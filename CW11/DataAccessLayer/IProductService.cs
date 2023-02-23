using CW11.Models;

namespace CW11.DataAccessLayer
{
    public interface IProductService
    {
        void Create(ProductModel product);
        List<ProductModel> ReadAll();
        ProductModel Read(int id);
        void Update(ProductModel product);
        void Delete(int id);
    }
}
