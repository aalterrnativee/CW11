using CW11.Models.Enum;

namespace CW11.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
