using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Interfaces;
using Microsoft.Extensions.Configuration;

namespace EmployeeManager.Data.Repository
{
    public class JobOportunityRepository : BaseRepository<JobOportunity>, IJobOportunityRepository
    {
        public JobOportunityRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
