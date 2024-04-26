using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Interfaces;
using Microsoft.Extensions.Configuration;

namespace EmployeeManager.Data.Repository
{
    public class JobOpportunityRepository : BaseRepository<JobOpportunity>, IJobOpportunityRepository
    {
        public JobOpportunityRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
