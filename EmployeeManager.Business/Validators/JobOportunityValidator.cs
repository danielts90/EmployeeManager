using EmployeeManager.Business.Dto;
using FluentValidation;

namespace EmployeeManager.Business.Validators
{
    public class JobOpportunityValidator : AbstractValidator<JobOpportunityDto>
    {
        public JobOpportunityValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("The field Name is required.");

            RuleFor(x => x.FunctionDescription)
                .NotEmpty()
                .NotNull()
                .WithMessage("The field function description is required.");

            RuleFor(x => x.CompanyName)
                .NotEmpty()
                .NotNull()
                .WithMessage("The field Company Name is required.");


            RuleFor(x => x.Salary)
                .NotNull()
                .WithMessage("The field Salary is required.")
                .GreaterThanOrEqualTo(1412)
                .WithMessage("The salary needs to be greater or equal a minimum salary");
        }
    }
}
