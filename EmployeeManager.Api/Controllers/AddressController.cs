using EmployeeManager.Business.Dto;
using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Interfaces;

namespace EmployeeManager.Api.Controllers
{
    public class AddressController : BaseController<AddressDto, Address>
    {
        public AddressController(IAddressService service) : base(service)
        {
        }
    }
}
