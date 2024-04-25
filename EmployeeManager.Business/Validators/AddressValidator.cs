using EmployeeManager.Business.Dto;
using FluentValidation;

namespace EmployeeManager.Business.Validators
{
    public class AddressValidator : AbstractValidator<AddressDto>
    {
        public AddressValidator() 
        {
            RuleFor(x => x.City)
                .NotEmpty()
                .NotNull()
                .WithMessage("The field city is required");

            RuleFor(x => x.Uf)
                .NotEmpty()
                .NotNull()
                .WithMessage("The field UF is required")
                .Length(2).WithMessage("The value to field UF is invalid.");

            RuleFor(x => x.Street)
                .NotEmpty()
                .NotNull()
                .WithMessage("The field street is required");

            RuleFor(x => x.Number)
                .NotEmpty()
                .NotNull()
                .WithMessage("The field number is required, if the address haven't a number, put the value S/N");
        }
    }
}
