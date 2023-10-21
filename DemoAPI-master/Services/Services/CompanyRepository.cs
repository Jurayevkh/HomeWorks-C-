using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Services.DataContexts;
using Services.Dtos;
using Services.Interfaces;


namespace Services.Services
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DataContext contexts;
        public CompanyRepository(DataContext contexts, IMapper mapper)
        {
            this.contexts = contexts;
            this.Mapper = mapper;
        }
        public IMapper Mapper { get;}
       
        public async Task CreateCompanyAsync(CreateCompanyDto company)
        {
            var company1 = new Company()
            {
                Address = company.Address,
                Email = company.Email,
                Name = company.Name,
                Id = new Guid(),
                Phone = company.Phone,
            };
            await contexts.Companies.AddAsync(company1);
            await contexts.SaveChangesAsync();
        }

        public async Task DeleteCompany(Guid companyId)
        {
            var company = await contexts.Companies.FirstOrDefaultAsync(x => x.Id == companyId);

            if(company != null)
            {
                contexts.Companies.Remove(company);
                await contexts.SaveChangesAsync();
            }
        }

        public async Task<List<Company>> GetAllAsync()
        {
            var companies = await contexts.Companies.AsNoTracking().ToListAsync();

            return companies;
        }

        public async Task<Company> GetCompanyByIdAsync(Guid companyId)
        {
            var company = await contexts.Companies.FirstOrDefaultAsync(x => x.Id == companyId);

            return company;
        }

        public async Task UpdateCompany(Guid companyId, string companyName)
        {
            var company = await contexts.Companies.FirstOrDefaultAsync(x => x.Id == companyId);

            company.Name = companyName;

            contexts.Companies.Update(company);
            await contexts.SaveChangesAsync();
        }

    }
}