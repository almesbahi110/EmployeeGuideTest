using Application.IService;
using Application.model;
using Application.Service.Base;
using AutoMapper;
using Domain.IRepository.Base;

namespace Application.Service
{
    public class JobTypeService : BaseService<JobType, JobTypeDto>, IJobTypeService
    {
        public JobTypeService(IJobTypeRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        protected override async Task ValidationInsertRequest(JobTypeDto dto)
        {
            await Task.CompletedTask;
        }
    }
}