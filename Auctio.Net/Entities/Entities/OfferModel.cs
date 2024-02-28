using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class OfferModel
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal Price { get; set; }
        public int ItemId { get; set; }
        public int UserId { get; set; }
    }
}