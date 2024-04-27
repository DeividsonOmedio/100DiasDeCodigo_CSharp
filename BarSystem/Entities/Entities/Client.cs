using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("Clientes")]
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Cpf { get; set; }
        public string? Networks { get; set; }
    }
}
