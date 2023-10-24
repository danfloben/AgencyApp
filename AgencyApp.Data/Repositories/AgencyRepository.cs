using AgencyApp.Data.Context;
using AgencyApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AgencyApp.Data.Repositories
{
    public class AgencyRepository : IAgencyRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ILogger _logger;
        public AgencyRepository(ILogger<Agency> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            this._appDbContext = appDbContext;
        }
        public async Task<Agency> Create(Agency agency)
        {
            await _appDbContext.Set<Agency>().AddAsync(agency);
            await _appDbContext.SaveChangesAsync();
            return agency;
        }

        public async Task<bool> Delete(Agency agency)
        {
            if (agency is null)
            {
                return false;
            }
            _appDbContext.Set<Agency>().Remove(agency);
            await _appDbContext.SaveChangesAsync();

            return true;
        }

        public IEnumerable<Agency> GetAll()
        {
            return _appDbContext.Agencies.ToList();
        }

        public Agency GetById(int id)
        {
            return _appDbContext.Agencies.Find(id);
        }
        public async Task<bool> Update(Agency agency)
        {
            _appDbContext.Entry(agency).State = EntityState.Modified;
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        public IEnumerable<Currency> GetAllCurrencies()
        {
            return _appDbContext.Currencies.ToList();
        }
    }
}