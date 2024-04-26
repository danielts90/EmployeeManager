using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Validators;
using FluentValidation.Results;

namespace EmployeeManager.Business.Dto
{
    public class JobOpportunityDto : DtoBase
    {
        public string? Name { get; set; }
        public string? FunctionDescription { get; set; }
        public string? CompanyName { get; set; }
        public decimal? Salary { get; set; }
        public override ValidationResult Validate()
        {
            var validator = new JobOpportunityValidator();
            return validator.Validate(this);
        }

        protected override JobOpportunity ToEntity()
        {
            return new JobOpportunity
            {
                name = Name,
                company = CompanyName,
                function_description = FunctionDescription,
                salary = Salary
            };
        }
    }
}
