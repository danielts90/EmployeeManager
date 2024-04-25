using EmployeeManager.Business.Dto;
using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Interfaces;

namespace EmployeeManager.Api.Controllers
{
    public class JobOportunityController : BaseController<JobOportunityDto, JobOportunity>
    {
        public JobOportunityController(IJobOportunityService service) : base(service)
        {
        }
    }
}
