using EmployeeManager.Business.Dto;
using Dapper.Contrib.Extensions;

namespace EmployeeManager.Business.Entities
{
    [Table("job_opportunity")]
    public class JobOpportunity : EntityBase
    {
        public string? name { get; set; }
        public string? function_description { get; set; }
        public string? company { get; set; }
        public decimal? salary { get; set; }
        protected override JobOpportunityDto ToDto()
        {
            return new JobOpportunityDto
            {
                Id = Id,
                Name = name,
                FunctionDescription = function_description,
                Salary = salary,
                CompanyName = company,
            };
        }
    }
}
