namespace CW11.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public System.Enum Brand { get; set; }
        public System.Enum Category { get; set; }
    }
}
