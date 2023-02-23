using CW11.Models;
using CW11.Models.Enum;

namespace CW11.DataAccessLayer
{
    public class ProductRepository
    {
        public static List<ProductModel> Products { get; set; } = new List<ProductModel>
        {
            new ProductModel
            {
            Id = 1,
            Name = "Sonic",
            Color = "Black",
            Model = "Master",
            Brand = Brand.Asus,
            Category = Category.Laptop
        },
            new ProductModel
            {
                Id = 2,
                Name = "Galaxy",
                Color = "Gold",
                Model = "S10",
                Brand = Brand.Samsung,
                Category = Category.Mobile
            }
        };
    }
}
