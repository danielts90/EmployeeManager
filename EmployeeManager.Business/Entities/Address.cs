using EmployeeManager.Business.Dto;
using Dapper.Contrib.Extensions;


namespace EmployeeManager.Business.Entities
{
    [Table("address")]
    public class Address : EntityBase
    {
        public string? street { get; set; }
        public string? number { get; set; }
        public string? city { get; set; }
        public string? uf { get; set; }
        public string? cep { get; set; }
        protected override AddressDto? ToDto()
        {
            return new AddressDto
            {
                Id = Id,
                Street = street,
                Number = number,
                City = city,
                Uf = uf,
                Cep = cep
            };
        }
    }
}
