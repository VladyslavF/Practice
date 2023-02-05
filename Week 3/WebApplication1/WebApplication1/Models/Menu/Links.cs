namespace WebApplication1.Models.Menu
{
    public class Links
    {
        //public string;
        public int Id { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }

        public string Name { get; set; }
        public string Url { get; set; }
    }
}
