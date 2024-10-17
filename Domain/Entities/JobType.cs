using Domain.Entities;
using Domain.Entities.Base;

public class JobType : BaseWithNameEntity
{
    public ICollection<Employee> Employees { get; set; }
}