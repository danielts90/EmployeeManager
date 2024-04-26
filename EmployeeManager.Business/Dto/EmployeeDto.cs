using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Validators;
using FluentValidation.Results;

namespace EmployeeManager.Business.Dto
{
    public class EmployeeDto : DtoBase
    {
        public string? Name { get; set; }
        public string? MotherName { get; set; }
        public string? FatherName { get; set; }
        public string? Cpf { get; set; }
        public DateTime? BirthDate { get; set; }
        public long? Addres_Id { get; set; }
        public override ValidationResult Validate()
        {
            var validations = new EmployeeValidator();
            return validations.Validate(this);
        }

        protected override Employee ToEntity()
        {
            return new Employee
            {
                name = Name,
                mother_name = MotherName,
                father_name = FatherName,
                cpf = Cpf,
                birthdate = BirthDate,
                address_id = Addres_Id
            };
        }
    }
}
