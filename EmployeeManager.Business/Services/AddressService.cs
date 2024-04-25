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
    }
}
