using Domain.Entities;
using Domain.IRepository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
    }
}
