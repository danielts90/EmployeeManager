using EmployeeManager.Business.Dto;
using EmployeeManager.Business.Entities;

namespace EmployeeManager.Business.Interfaces
{
    public interface IAddressService : IBaseService<AddressDto, Address> 
    {
        Task<AddressDto> GenerateFakeAddres();
    }

}
