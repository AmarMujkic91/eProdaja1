using eProdaja.Model;
using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodiService : IProizvodiService
    {
        EProdajaContext _dbContext;

        public ProizvodiService(EProdajaContext dbContext)
        {
            _dbContext = dbContext;
        }



        List<Model.Proizvodi> _proizvodiList = new List<Model.Proizvodi>()
        {
            new Model.Proizvodi()
            {
                ProizvodId=1,
                Naziv="Laptop"
            }
        };

        public IList<Model.Proizvodi> Get()
        {
            var proizvodiListst = _dbContext.Proizvodi.ToList();
            return _proizvodiList;
        }
    }
}
