using Dominio.Interface;

namespace Dominio.Interfaces;

    public interface IUnitOfWork
    {
            IClaseRepository Clases { get; }
            Task<int> SaveAsync();
    }
