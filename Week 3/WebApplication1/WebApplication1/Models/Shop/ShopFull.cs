namespace WebApplication1.Models.Shop
{
    public class ShopFull
    {
        public IEnumerable<Product> products { get; set; }
        public IEnumerable<Category> categories { get; set; }
        public IEnumerable<Color> colors { get; set; }      
        public IEnumerable<Size> sizes { get; set; }
    }
}
