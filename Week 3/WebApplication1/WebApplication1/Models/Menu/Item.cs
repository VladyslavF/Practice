namespace WebApplication1.Models.Menu
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Links> Links { get; set; }

    }
}
