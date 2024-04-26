using EmployeeManager.Business.Dto;
using Dapper.Contrib.Extensions;

namespace EmployeeManager.Business.Entities
{
    [Table("employee")]
    public class Employee : EntityBase
    {
        public string? name { get; set; }
        public string? mother_name { get; set; }
        public string? father_name { get; set; }
        public string? cpf { get; set; }
        public DateTime? birthdate { get; set; }
        public  long? address_id { get; set; }

        protected override EmployeeDto ToDto()
        {
            return new EmployeeDto
            {
                Id = id,
                Name = name,
                MotherName = mother_name,
                FatherName = father_name,
                Addres_Id = address_id,
                BirthDate = birthdate
            };
        }
    }
}
