using Dominio.Interface;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplicacion.UnitOfWork
{ 

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly SkeletonContext? _Context;
        private IClaseRepository? _clases;

        public UnitOfWork(SkeletonContext? context) => _Context = context;

        public IClaseRepository Clases => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public  Task<int> SaveAsync(){
            throw new NotImplementedException();
        }
    }
}