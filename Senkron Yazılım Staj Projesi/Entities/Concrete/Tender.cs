using System;
using TenderSystem.Core.Entities;

namespace TenderSystem.Entities.Concrete
{
    public class Tender : IEntity   
    {
        
        public int Id { get; set; }
        public int AdminId { get; set; }
        public int TenderNo { get; set; }
        public string TenderTitle { get; set; }
        public int CategoryId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal StartPrice { get; set; }
        public int TenderStatusId { get; set; }
        public int WinnerClientId { get; set; }
    }
}
