using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using TenderSystem.Core.Entities;

namespace TenderSystem.Entities.Concrete
{
    [Table("Admins")]
    public class Admin : User, IEntity
    {
    }
}