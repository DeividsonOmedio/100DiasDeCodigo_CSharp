using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("Enderecos")]
    public class Address
    {
        public int Id { get; set; }
        public Client ClientId { get; set; } = new();
        public string Patio { get; set; } = string.Empty;
        public int Number { get; set; }
        public string? Complement { get; set; }
        public string? References { get; set; }
        public string District { get; set; } = string.Empty;
        public string? ZipCode { get; set; }
        public string City { get; set; } = string.Empty;
    }
}
