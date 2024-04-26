using EmployeeManager.Api.Helpers;
using EmployeeManager.Business.Dto;
using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManager.Api.Controllers
{
    public class AddressController : BaseController<AddressDto, Address>
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService addressService) : base(addressService)
        {
            _addressService = addressService;
        }

        [HttpPost]
        [Route("CreateFake")]
        public async Task<IActionResult> InsertFake()
        {
            var entity = await _addressService.GenerateFakeAddres();
            return Ok(new CustomResponse<AddressDto>(true, "", entity));
        }
    }
}
