namespace Entities.Entities
{
    public class AuctionModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Starts { get; set; } = DateTime.Now;
        public DateTime Ends { get; set; } = DateTime.Now.AddDays(7);
        public List<ItemModel> Items { get; set; } = [];
        public int UserId { get; set; }
    }
}
