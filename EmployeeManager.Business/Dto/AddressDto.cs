using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Validators;
using FluentValidation.Results;

namespace EmployeeManager.Business.Dto
{
    public class AddressDto : DtoBase
    {
        public string? Street { get; set; }
        public string? Number { get; set; }
        public string? City { get; set; }
        public string? Uf { get; set; }
        public string? Cep { get; set; }
        public override ValidationResult Validate()
        {
            var validator = new AddressValidator();
            return validator.Validate(this);
        }

        protected override Address ToEntity()
        {
            return new Address()
            {
                Id = Id,
                street = Street,
                number = Number,
                city = City,
                uf = Uf,
                cep = Cep
            };
        }
    }
}
