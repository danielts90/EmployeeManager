using EmployeeManager.Api.Helpers;
using EmployeeManager.Business.Dto;
using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManager.Api.Controllers
{
    public class JobOpportunityController : BaseController<JobOpportunityDto, JobOpportunity>
    {
        private readonly IJobOpportunityService _jobOpportunityService;
        public JobOpportunityController(IJobOpportunityService jobOpportunityService) : base(jobOpportunityService)
        {
            _jobOpportunityService = jobOpportunityService;
        }
        
        [HttpPost]
        [Route("CreateFake")]
        public async Task<IActionResult> CreateEmployees(int quantity)
        {
            await _jobOpportunityService.CreateFake(quantity);
            return Ok(new CustomResponse<string>(true, "Opportunities inserted", ""));
        }
        
    }
}
