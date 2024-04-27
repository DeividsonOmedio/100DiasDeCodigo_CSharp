using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("Vendas")]
    public class Sale
    {
        public int Id { get; set; }
        public Product ProductId { get; set; } = new();
        public decimal SaleValue { get; set; }
        public decimal Discount { get; set; }
        public DateTime DateSale { get; set; }
        public StatusPaymentEnum StatusPayment { get; set; }
        public StatusSaleEnum StatusSale { get; set; }
        public TypePaymentEnum? TypePayment { get; set; }
        public TypeSaleEnum TypeSale { get; set; }
        public Address? AddressDelivery { get; set; }
        public string Note { get; set; } = string.Empty;
        public Employee EmployeeId { get; set; } = new();
        public Client ClientId { get; set; } = new();
    }
}
