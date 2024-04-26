using EmployeeManager.Business.Dto;
using FluentValidation;

namespace EmployeeManager.Business.Validators
{
    public class EmployeeValidator : AbstractValidator<EmployeeDto>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("The field Name is required");

            RuleFor(x => x.MotherName)
                .NotEmpty()
                .NotNull()
                .WithMessage("The field Mother's name is required");

            RuleFor(x => x.FatherName)
                .NotEmpty()
                .NotNull()
                .WithMessage("The field Father's name is required");

            RuleFor(x => x.Cpf)
                .NotEmpty()
                .NotNull()
                .WithMessage("The field cpf is required.")
                .Length(11)
                .WithMessage("The field cpf needs to have 11 characters");




        }
    }
}
