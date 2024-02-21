

using leilao.api.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace leilao.api.Entities
{
    [Table("Items")]
    public class ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public CondicaoEnum Condition { get; set; }
        public decimal BasePrice { get; set; }
        public int AuctionId { get; set; }
        [JsonIgnore]
        public LeilaoModel? Auction { get; set; }
    }
}
