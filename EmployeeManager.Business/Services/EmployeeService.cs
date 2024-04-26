using Bogus;
using Bogus.DataSets;
using Bogus.Extensions.Brazil;
using EmployeeManager.Business.Composite;
using EmployeeManager.Business.Dto;
using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Interfaces;
using static Bogus.DataSets.Name;

namespace EmployeeManager.Business.Services
{
    public class EmployeeService : BaseService<EmployeeDto, Employee>, IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository repository) : base(repository)
        {
            _employeeRepository = repository;
        }

        public async Task GenerateFakeEmployees(int quantity)
        {
            for(int i = 1; i <= quantity; i++) 
            {
                var fakeEmployee = new Faker<EmployeeDto>("pt_BR")
                    .RuleFor(o => o.Name, f => f.Name.FullName())
                    .RuleFor(o => o.Cpf, f => f.Person.Cpf(false))
                    .RuleFor(o => o.MotherName, f => f.Name.FullName(Gender.Female))
                    .RuleFor(o => o.FatherName, f => f.Name.FullName(Gender.Male))
                    .RuleFor(o => o.BirthDate, f => f.Date.Past(70))
                    .Generate();
                fakeEmployee.Addres_Id = i;
                await Insert(fakeEmployee);
            }
        }

        public async Task<IEnumerable<EmployeeWithAddress>> GetAllEmployeeWithAddress()
        {
            return await _employeeRepository.GetAllEmployeesWithAddres();
        }

        public async Task<EmployeeWithAddress> GetEmployeeWithAddressByEmployeeId(long employeeId)
        {
            return await _employeeRepository.GetEmployeeWithAddressById(employeeId);
        }
    }
}
