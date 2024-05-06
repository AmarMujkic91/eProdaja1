﻿using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodiService : IProizvodiService
    {
        List<Proizvodi> _proizvodiList = new List<Proizvodi>()
        {
            new Proizvodi()
            {
                ProizvodId=1,
                Naziv="Laptop"
            }
        };

        public IList<Proizvodi> Get()
        {
            return _proizvodiList;
        }
    }
}
