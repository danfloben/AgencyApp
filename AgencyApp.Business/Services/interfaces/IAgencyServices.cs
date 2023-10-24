using AgencyApp.Data.Models;
namespace AgencyApp.Business.Services.interfaces
{
    public interface IAgencyServices
    {
        IEnumerable<Agency> GetAll();
        Task<Agency> Create(Agency agency);
        Task<bool> Delete(Agency agency);
        Task<bool> Update(Agency agency);        
        Agency GetById(int id);
        IEnumerable<Currency> GetAllCurrencies();
    }
}
