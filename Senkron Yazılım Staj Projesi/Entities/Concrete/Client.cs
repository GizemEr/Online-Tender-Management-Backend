using System.ComponentModel.DataAnnotations.Schema;
using TenderSystem.Core.Entities;

namespace TenderSystem.Entities.Concrete
{
    [Table("Clients")]
    public class Client : User, IEntity
    {
        public string UserName { get; set; }
    }
}
