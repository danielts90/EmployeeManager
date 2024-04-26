using EmployeeManager.Business.Dto;
using Dapper.Contrib.Extensions;

namespace EmployeeManager.Business.Entities
{
    [Table("job_oportunity")]
    public class JobOportunity : EntityBase
    {
        public string? name { get; set; }
        public string? function_description { get; set; }
        public string? company { get; set; }
        public decimal? salary { get; set; }
        protected override JobOportunityDto ToDto()
        {
            return new JobOportunityDto
            {
                Id = id,
                Name = name,
                FunctionDescription = function_description,
                Salary = salary,
                CompanyName = company,
            };
        }
    }
}
