﻿namespace leilao.api.Entities
{
    public class OfertaModel
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal Price { get; set; }
        public int ItemId { get; set; }
        public int UserId { get; set; }
    }
}
