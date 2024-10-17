using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee : BaseWithNameEntity
    {
        public long JobTypeId { get; set; }
        public JobType? JobType { get; set; }

    }

}
