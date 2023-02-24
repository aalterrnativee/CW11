using CW11.Models;
using CW11.Models.Enum;

namespace CW11.DataAccessLayer
{
    public class ProductRepository
    {
        public static List<ProductModel> Products { get; set; } = new List<ProductModel>();
    }
}
