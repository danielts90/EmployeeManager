using Bogus;
using EmployeeManager.Business.Dto;
using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Interfaces;

namespace EmployeeManager.Business.Services
{
    public class AddressService : BaseService<AddressDto, Address>, IAddressService
    {
        public AddressService(IAddressRepository repository) : base(repository)
        {
        }

        public async Task<AddressDto> GenerateFakeAddres()
        {
            var fakeAddres = new Faker<AddressDto>("pt_BR")
                .RuleFor(o => o.Street, f => f.Address.StreetAddress())
                .RuleFor(o => o.Uf, f => f.Address.StateAbbr())
                .RuleFor(o => o.Cep, f => f.Address.ZipCode())
                .RuleFor(o => o.City, f => f.Address.City())
                .RuleFor(o => o.Number, f => f.Random.AlphaNumeric(3));

            var inserted = await Insert(fakeAddres);
            var fakeEntity = await GetById(inserted);
            return fakeEntity;



        }
    }
}
