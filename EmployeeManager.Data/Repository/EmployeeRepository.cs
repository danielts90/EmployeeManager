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
    }
}
