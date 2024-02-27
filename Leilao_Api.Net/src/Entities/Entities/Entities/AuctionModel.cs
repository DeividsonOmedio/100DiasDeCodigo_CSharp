using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class AuctionModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Starts { get; set; }
        public DateTime Ends { get; set; }
        public List<ItemModel> Items { get; set; } = [];
    }
}
