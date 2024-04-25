using EmployeeManager.Business.Dto;
using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Interfaces;
using EmployeeManager.Business.Services;

namespace EmployeeManager.Api.Controllers
{
    public class EmployeeController : BaseController<EmployeeDto, Employee>
    {
        public EmployeeController(IEmployeeService service) : base(service)
        {
        }
    }
}
