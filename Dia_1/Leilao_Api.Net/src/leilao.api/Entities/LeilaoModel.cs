using System.Text.Json.Serialization;

namespace leilao.api.Entities
{
    public class LeilaoModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Starts { get; set; }
        public DateTime Ends { get; set; }
        public List<ItemModel> Items { get; set; } = [];
    }
}
