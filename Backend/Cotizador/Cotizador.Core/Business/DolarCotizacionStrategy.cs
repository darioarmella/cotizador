using Cotizador.Core.Business.Interface;
using Cotizador.Core.Data;
using Cotizador.Core.Entities;
using Cotizador.Core.Entities.Common;
using System.Collections.Generic;
using System.Linq;

namespace Cotizador.Core.Business
{
    public class DolarCotizacionStrategy : ICotizacionStrategy
    {
        private IRepository<List<RespuestaBcra>> _repository;

        public DolarCotizacionStrategy()
        {
            _repository = new RepositoryCambioBcra();
        }

        public Cotizacion GetCotizacion()
        {
            var respuesta = _repository.GetAsync().Result;

            //return new Cotizacion { Moneda = "dolar", Precio = 45 };
            return new Cotizacion { Moneda = "dolar", Precio = respuesta.LastOrDefault().V };
        }
    }
}
