using Dominio.Interface;
using Persistencia;
using Persistencia.Data;

namespace Aplicacion.Repository;

    public class ClaseRepository : GenericRepository<Clase>, IClaseRepository
    {
        public ClaseRepository(SkeletonContext context) : base(context)
        {
            
        }
    }
