using Application.model;
using AutoMapper;
using Domain.Entities;
namespace Application.Common.Mapper
{
    public class LibraryProfile: Profile
    {
        public LibraryProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<JobType, JobTypeDto>().ReverseMap();
        }
    }
}