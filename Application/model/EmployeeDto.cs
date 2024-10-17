using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.model
{
    public class EmployeeDto : BaseDtoWithNameEntity
    {
        public long JobTypeId { get; set; }
    }
}
