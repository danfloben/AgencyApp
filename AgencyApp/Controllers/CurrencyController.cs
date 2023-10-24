using AgencyApp.Business.Services.interfaces;
using AgencyApp.Data.Models;
using Microsoft.AspNetCore.Mvc;


namespace AgencyApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private IAgencyServices _agencyServices { get; }
        public CurrencyController(IAgencyServices agencyServices)
        {
            _agencyServices = agencyServices;
        }
        // GET: api/<CurrencyController>
        [HttpGet]
        public IEnumerable<Currency> Get()
        {
            return _agencyServices.GetAllCurrencies();
        }

    }
}
