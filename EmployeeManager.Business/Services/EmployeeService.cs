using EmployeeManager.Business.Dto;
using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Interfaces;

namespace EmployeeManager.Business.Services
{
    public class EmployeeService : BaseService<EmployeeDto, Employee>, IEmployeeService
    {
        public EmployeeService(IEmployeeRepository repository) : base(repository)
        {
        }
    }
}
