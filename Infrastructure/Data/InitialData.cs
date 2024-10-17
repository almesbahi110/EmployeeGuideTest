using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public static class InitialData
    {
        public static async void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobType>().HasData(
                GetJobTypes()
            ); 
            modelBuilder.Entity<Employee>().HasData(
                GetEmployees()
            );

        }
        #region JobType
        private static List<JobType> GetJobTypes()
        {
            return new List<JobType> {
            new JobType
                {
                    Id = 1,
                    Name = "Devloper C#",
                },
                new JobType
                {
                    Id = 2,
                    Name = "Devloper ASP.NET Core",
                }, 
                new JobType
                {
                    Id = 3,
                    Name = "Devloper Angular",
                },
            
            };
        }
        #endregion

        #region Employee
        private static List<Employee> GetEmployees()
        {
            return new List<Employee> {
                new Employee
                {
                    Id = 1,
                    Name = "Mohammed Al-Mesbahi",
                    JobTypeId= 1,
                },
                new Employee
                {
                    Id = 2,
                    Name = "Ali ali",
                    JobTypeId = 2
                },
                new Employee
                {
                    Id = 3,
                    Name = "ali 2",
                    JobTypeId= 3
                }, 
            };
        }
        #endregion
    }
}
