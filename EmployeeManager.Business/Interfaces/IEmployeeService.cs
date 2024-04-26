using EmployeeManager.Business.Composite;
using EmployeeManager.Business.Dto;
using EmployeeManager.Business.Entities;

namespace EmployeeManager.Business.Interfaces
{
    public interface IEmployeeService : IBaseService<EmployeeDto, Employee>
    {
        Task GenerateFakeEmployees(int quantity);
        Task<EmployeeWithAddress> GetEmployeeWithAddressByEmployeeId(long employeeId);
        Task<IEnumerable<EmployeeWithAddress>> GetAllEmployeeWithAddress();
    }
}
