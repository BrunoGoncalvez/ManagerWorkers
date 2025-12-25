using System;

namespace ManagerWorkers.Core.Entities
{
    public class User : EntityBase
    {

        public string Name { get; set; } = String.Empty;

        public string Email { get; set; } = String.Empty;

        public string Password { get; set; } = String.Empty;

        public DateTime CreatedIn { get; set; }

    }
}
