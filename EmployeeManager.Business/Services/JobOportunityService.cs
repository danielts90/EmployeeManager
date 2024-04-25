using EmployeeManager.Business.Dto;
using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Interfaces;

namespace EmployeeManager.Business.Services
{
    public class JobOportunityService : BaseService<JobOportunityDto, JobOportunity>, IJobOportunityService
    {
        public JobOportunityService(IJobOportunityRepository repository) : base(repository)
        {
        }
    }
}
