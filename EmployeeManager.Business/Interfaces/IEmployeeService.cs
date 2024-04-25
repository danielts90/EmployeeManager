using EmployeeManager.Business.Dto;
using EmployeeManager.Business.Entities;

namespace EmployeeManager.Business.Interfaces
{
    public interface IEmployeeService : IBaseService<EmployeeDto, Employee>
    {
    }
}
