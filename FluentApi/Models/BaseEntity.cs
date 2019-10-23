using System;
using System.Collections.Generic;
using System.Text;

namespace GroundzKeeper.Data
{
    public class BaseEntity
    {
        public Guid TenantId { get; set; }
        public bool IsSoftDeleted { get; set; } = false;
    }
}
