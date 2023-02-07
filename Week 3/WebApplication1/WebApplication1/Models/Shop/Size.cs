namespace WebApplication1.Models.Shop
{
    public class Size
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number_size { get; set; }
        public ICollection<Product_Sizes> Product_Sizes { get; set; }
    }
}
