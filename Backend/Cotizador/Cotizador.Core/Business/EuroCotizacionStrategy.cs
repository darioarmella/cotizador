using Cotizador.Core.Business.Interface;
using Cotizador.Core.Data;
using Cotizador.Core.Entities;
using Cotizador.Core.Entities.Common;

namespace Cotizador.Core.Business
{
    public class EuroCotizacionStrategy : ICotizacionStrategy
    {
        private IRepository<RespuestaCambioToday> _repository;

        public EuroCotizacionStrategy()
        {
            _repository = new RepositoryCambioToday();
        }
        
        public Cotizacion GetCotizacion()
        {
            var respuesta = _repository.GetAsync().Result;

            return new Cotizacion { Moneda = "euro", Precio = respuesta.Result.Value };
        }
    }
}
