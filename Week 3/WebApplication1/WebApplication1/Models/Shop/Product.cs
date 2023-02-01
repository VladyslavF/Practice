namespace WebApplication1.Models.Shop
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string ImageUrl { get; set; }

        public int SizeId { get; set; }
        public Size Size { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public string? Description { get; set; }
        public string? Ingredients { get; set; }

        public string? Status { get; set; }
    }
}
