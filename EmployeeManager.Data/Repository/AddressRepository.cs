using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Interfaces;
using Microsoft.Extensions.Configuration;

namespace EmployeeManager.Data.Repository
{
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        public AddressRepository(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
