using Infrastructure.Data;
using Infrastructure.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class JobTypeRepository : Repository<JobType>, IJobTypeRepository
    {
        public JobTypeRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }

}