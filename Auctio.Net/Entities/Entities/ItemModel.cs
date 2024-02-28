using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("Items")]
    public class ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public ConditionItemEnum Condition { get; set; }
        public decimal BasePrice { get; set; }
        public int AuctionId { get; set; }
        [JsonIgnore]
        public AuctionModel? Auction { get; set; }
    }
}
