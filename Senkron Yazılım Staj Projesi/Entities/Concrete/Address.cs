using TenderSystem.Core.Entities;

namespace TenderSystem.Entities.Concrete
{
    public class Address : IEntity
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string AddressDetail { get; set; }
    }
}
