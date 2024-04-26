using Bogus;
using EmployeeManager.Business.Dto;
using EmployeeManager.Business.Entities;
using EmployeeManager.Business.Interfaces;

namespace EmployeeManager.Business.Services
{
    public class JobOpportunityService : BaseService<JobOpportunityDto, JobOpportunity>, IJobOpportunityService
    {
        public JobOpportunityService(IJobOpportunityRepository repository) : base(repository)
        {

        }

        public async Task CreateFake(int quantity)
        {
            string[] positions = { "Software Developper", "UX Design", "Project Mananger", "DBA", "IT Support" };
            for (int i = 0; i < quantity; i++) 
            {
                var fakeOportunity = new Faker<JobOpportunityDto>()
                    .RuleFor(o => o.Name, f => positions[f.Random.Number(0, 4)])
                    .RuleFor(o => o.CompanyName, f => f.Company.CompanyName())
                    .RuleFor(o => o.Salary, f => f.Random.Decimal(4999.99M, 11999.99M))
                    .RuleFor(o => o.FunctionDescription, f => f.Lorem.Sentence(5))
                    .Generate();

                await Insert(fakeOportunity);
            }
        }
    }
}
