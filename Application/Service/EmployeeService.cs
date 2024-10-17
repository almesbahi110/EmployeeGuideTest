using Application.IService;
using Application.model;
using Application.Service.Base;
using AutoMapper;
using Domain.Entities;
using Domain.IRepository;
namespace Application.Service
{
    public class EmployeeService : BaseService<Employee, EmployeeDto>, IEmployeeService
    {
        public EmployeeService(IEmployeeRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
        protected override async Task ValidationInsertRequest(EmployeeDto dto)
        {
            await Task.CompletedTask;
        }
    }
}
