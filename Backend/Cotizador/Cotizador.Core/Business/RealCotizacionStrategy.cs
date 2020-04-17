using Cotizador.Core.Business.Interface;
using Cotizador.Core.Data;
using Cotizador.Core.Entities;
using Cotizador.Core.Entities.Common;

namespace Cotizador.Core.Business
{
    public class RealCotizacionStrategy : ICotizacionStrategy
    {
        private IRepository<RespuestaExchangeRate> _repository;

        public RealCotizacionStrategy()
        {
            _repository = new RepositoryExchangeRate();
        }

        public Cotizacion GetCotizacion()
        {
            var respuesta = _repository.GetAsync().Result;

            return new Cotizacion { Moneda = "real", Precio = respuesta.ConversionRates["ARS"] };
        }
    }
}
