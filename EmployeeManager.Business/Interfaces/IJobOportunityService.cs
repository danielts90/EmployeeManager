using EmployeeManager.Business.Dto;
using EmployeeManager.Business.Entities;

namespace EmployeeManager.Business.Interfaces
{
    public interface IJobOpportunityService : IBaseService<JobOpportunityDto, JobOpportunity> 
    {
        Task CreateFake(int quantity);
    }
}
