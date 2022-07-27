using System.ComponentModel.DataAnnotations.Schema;
using TenderSystem.Core.Entities;

namespace TenderSystem.Entities.Concrete
{
    public abstract class User : IEntity
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }

    }
}
