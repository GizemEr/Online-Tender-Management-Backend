using System;
using TenderSystem.Core.Entities;

namespace TenderSystem.Entities.Concrete
{
    public class Bid : IEntity
    {
        public int Id { get; set; }
        public int TenderId { get; set; }
        public int ClientId { get; set; }
        public decimal BidPrice { get; set; }
        public DateTime BidDate { get; set; }
    }
}
