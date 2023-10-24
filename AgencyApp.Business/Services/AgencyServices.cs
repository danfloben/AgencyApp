using AgencyApp.Business.Services.interfaces;
using AgencyApp.Data.Models;
using AgencyApp.Data.Repositories;

namespace AgencyApp.Business.Services
{
    public class AgencyServices : IAgencyServices
    {
        public readonly IAgencyRepository _repository;
        public AgencyServices(IAgencyRepository repository)
        {
            _repository = repository;
        }
        public async Task<Agency> Create(Agency agency)
        {
            return await _repository.Create(agency);
        }
        public Task<bool> Delete(Agency agency)
        {
            return _repository.Delete(agency);
        }
        public Task<bool> Update(Agency agency)
        {
           return _repository.Update(agency);
        }
        public IEnumerable<Agency> GetAll()
        {
            return _repository.GetAll().ToList();
        }
        public Agency GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Currency> GetAllCurrencies()
        {
            return _repository.GetAllCurrencies().ToList();
        }
    }
}
