using EmployeeManager.Business.Dto;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManager.Business.Entities
{
    [Table("address")]
    public class Address : EntityBase
    {
        public string? Street { get; set; }
        public string? Number { get; set; }
        public string? City { get; set; }
        public string? Uf { get; set; }
        public string? Cep { get; set; }
        protected override AddressDto ToDto()
        {
            return new AddressDto
            {
                Id = Id,
                Street = Street,
                Number = Number,
                City = City,
                Uf = Uf,
                Cep = Cep
            };
        }
    }
}
