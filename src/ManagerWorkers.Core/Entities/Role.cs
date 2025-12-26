
namespace ManagerWorkers.Core.Entities
{
    public class Role : EntityBase
    {

        public int RoleCode { get; set; }

        public string RoleName { get; set; } = String.Empty;

        public ICollection<User> Users { get; set; } = new List<User>();

    }
}
