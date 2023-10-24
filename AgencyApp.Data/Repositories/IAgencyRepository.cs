namespace AgencyApp.Data.Repositories
{
    using AgencyApp.Data.Models;
    using System.Collections.Generic;

    public interface IAgencyRepository
    {
        IEnumerable<Agency> GetAll();
        Task<Agency> Create(Agency agency);
        Task<bool> Delete(Agency agency);
        Task<bool> Update(Agency agency);
        Agency GetById(int id);
        IEnumerable<Currency> GetAllCurrencies();
    }

}
