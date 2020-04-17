using Cotizador.Core.Business.Interface;
using Cotizador.Core.Entities;

namespace Cotizador.Core.Business
{
    public class MonedaContext
    {
        private ICotizacionStrategy _cotizacionStrategy;

        public MonedaContext(ICotizacionStrategy strategy)
        {
            this._cotizacionStrategy = strategy;
        }

        public Cotizacion GetCotizacion()
        {
            return _cotizacionStrategy.GetCotizacion();
        }
    }
}
