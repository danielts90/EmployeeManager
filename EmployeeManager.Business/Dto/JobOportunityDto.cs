using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Validators;
using FluentValidation.Results;

namespace EmployeeManager.Business.Dto
{
    public class JobOportunityDto : DtoBase
    {
        public string? Name { get; set; }
        public string? FunctionDescription { get; set; }
        public string? CompanyName { get; set; }
        public decimal? Salary { get; set; }
        public override ValidationResult Validate()
        {
            var validator = new JobOportunityValidator();
            return validator.Validate(this);
        }

        protected override JobOportunity ToEntity()
        {
            return new JobOportunity
            {
                name = Name,
                company = CompanyName,
                function_description = FunctionDescription,
                salary = Salary
            };
        }
    }
}
