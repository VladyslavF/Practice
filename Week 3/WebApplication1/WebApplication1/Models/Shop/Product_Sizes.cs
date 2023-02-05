namespace WebApplication1.Models.Shop
{
    public class Product_Sizes
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }
    }
}
