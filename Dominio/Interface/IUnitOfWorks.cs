using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interface;

namespace Dominio.Interfaces
{
    public interface IUnitOfWorks
    {
            IClaseRepository Clases { get; }
            Task<int> SaveAsync();
    }
}