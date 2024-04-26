using EmployeeManager.Business.Composite;
using EmployeeManager.Business.Entities;

namespace EmployeeManager.Business.Interfaces
{
    public interface IEmployeeRepository : IBaseRepository<Employee> 
    {
        Task<EmployeeWithAddress> GetEmployeeWithAddressById(long ind);
        Task<IEnumerable<EmployeeWithAddress>> GetAllEmployeesWithAddres();
    }
}
