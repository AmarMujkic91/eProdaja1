using eProdaja.Model;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProizvodiController : ControllerBase
    {
        private readonly IProizvodiService _proizvodiService;

        public ProizvodiController(IProizvodiService proizvodiService)
        {
            _proizvodiService = proizvodiService;
        }

        [HttpGet]
        public IEnumerable<Proizvodi> Get()
        {
            return _proizvodiService.Get();
        }
    }
}
