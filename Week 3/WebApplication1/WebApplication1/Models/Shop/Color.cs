namespace WebApplication1.Models.Shop
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HexCode { get; set; }
        public string Description { get; set; }
        //public string IconURL { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
