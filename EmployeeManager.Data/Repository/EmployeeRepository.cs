using Dapper;
using EmployeeManager.Business.Composite;
using EmployeeManager.Business.Dto;
using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Interfaces;
using Microsoft.Extensions.Configuration;

namespace EmployeeManager.Data.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IConfiguration configuration) : base(configuration)
        {
        }

        private const string GET_ALL_EMPLOYEES_WITH_ADDRESS =
            @"Select e.*, a.* from employee e
              inner join address a on e.address_id = a.id";

        private const string GET_BY_EMPLOYEE_ID_FILTER = " where e.id = @id";

        public async Task<IEnumerable<EmployeeWithAddress>> GetAllEmployeesWithAddres()
        {
            var employeesWithAddress = await _db.QueryAsync<Employee, Address, EmployeeWithAddress>(GET_ALL_EMPLOYEES_WITH_ADDRESS,
                (employee, address) =>
                {
                    var employeeWithAddress = new EmployeeWithAddress()
                    {
                        Address = (AddressDto)address,
                        Employee = (EmployeeDto)employee
                    };
                    return employeeWithAddress;
                },
                splitOn: "id");

            return employeesWithAddress;
        }

        public async Task<EmployeeWithAddress> GetEmployeeWithAddressById(long id)
        {
            var employeesWithAddress = await _db.QueryAsync<Employee, Address, EmployeeWithAddress>(string.Concat(GET_ALL_EMPLOYEES_WITH_ADDRESS,GET_BY_EMPLOYEE_ID_FILTER),
                (employee, address) =>
                {
                    var employeeWithAddress = new EmployeeWithAddress()
                    {
                        Address = (AddressDto)address,
                        Employee = (EmployeeDto)employee
                    };
                    return employeeWithAddress;
                },
                param:  new{ id },
                splitOn: "id");

            return employeesWithAddress.FirstOrDefault();
        }
    }
}
