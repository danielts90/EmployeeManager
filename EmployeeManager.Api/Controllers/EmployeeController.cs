using EmployeeManager.Api.Helpers;
using EmployeeManager.Business.Composite;
using EmployeeManager.Business.Dto;
using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManager.Api.Controllers
{
    public class EmployeeController : BaseController<EmployeeDto, Employee>
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController( IEmployeeService employeeService) : base(employeeService)
        {
           _employeeService = employeeService;
        }

        [HttpPost]
        [Route("CreateFake")]
        public async Task<IActionResult> CreateEmployees(int quantity)
        {
            await _employeeService.GenerateFakeEmployees(quantity);
            return Ok(new CustomResponse<string>(true, "Employees inserted", ""));
        }

        [HttpGet]
        [Route("GetAllEmployeesWithAddress")]
        public async Task<IActionResult> GetAllEmployeesWithAddress()
        {
            var employees = await _employeeService.GetAllEmployeeWithAddress();
            return Ok(new CustomResponse<IEnumerable<EmployeeWithAddress>>(true, "", employees ));
        }

        [HttpGet]
        [Route("GetEmployeeWithAddress")]
        public async Task<IActionResult> GetEmployeeWithAddress(long id)
        {
            var employeeWithAddress = await _employeeService.GetEmployeeWithAddressByEmployeeId(id);
            return Ok(new CustomResponse<EmployeeWithAddress>(true, "", employeeWithAddress));
        }

    }
}
