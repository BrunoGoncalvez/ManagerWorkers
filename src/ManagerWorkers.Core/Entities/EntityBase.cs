using System;

namespace ManagerWorkers.Core.Entities
{
    public class EntityBase
    {

        public Guid Id { get; set; }

        public EntityBase()
        {
            Id = Guid.NewGuid();
        }

    }
}
