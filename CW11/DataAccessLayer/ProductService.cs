using CW11.DataAccessLayer.Extensions;
using CW11.Models;
using CW11.Models.Enum;

namespace CW11.DataAccessLayer
{
    public class ProductService : IProductService
    {
        public static int LastId { get; set; }

        public void Create(ProductModel product)
        {
            if (product.Id == 0)
            {
                product.Id = ++LastId;
            }
            product.AddedDate = DateTime.Now;

            var result = DateTimeExtensions.ToPersianDateTime(product.AddedDate);

            File.WriteAllText("C:\\Users\\alter\\OneDrive\\Desktop\\CW11\\CW11\\Date.txt", result);

            ProductRepository.Products.Add(product);
        }

        public List<ProductModel> ReadAll()
        {
            return ProductRepository.Products.ToList();
        }

        public ProductModel Read(int id)
        {
            return ProductRepository.Products.FirstOrDefault(p => p.Id == id);
        }

        public void Update(ProductModel product)
        {
            ProductModel updatedProduct = ProductRepository.Products.FirstOrDefault(p => p.Id == product.Id);

            updatedProduct.Name = product.Name;
            updatedProduct.Color = product.Color;
            updatedProduct.Model = product.Model;
            //updatedProduct.Category = product.Category;

            switch (Convert.ToString(product.Brand))
            {
                case "Samsung":
                    updatedProduct.Brand = Brand.Samsung;
                    break;
                case "Lenovo":
                    updatedProduct.Brand = Brand.Lenovo;
                    break;
                case "Asus":
                    updatedProduct.Brand = Brand.Asus;
                    break;
                case "Hwawei":
                    updatedProduct.Brand = Brand.huawei;
                    break;
            }

            updatedProduct.Brand = product.Brand;
        }

        public void Delete(int id)
        {
            ProductRepository.Products.Remove(Read(id));
        }
    }
}
