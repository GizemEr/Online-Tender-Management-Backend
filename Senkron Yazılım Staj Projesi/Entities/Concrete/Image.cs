using TenderSystem.Core.Entities;

namespace TenderSystem.Entities.Concrete
{
    public class Image : IEntity
    {
        public int Id { get; set; }
        public int TenderId { get; set; }
        public byte[] Picture { get; set; }
    }
}
