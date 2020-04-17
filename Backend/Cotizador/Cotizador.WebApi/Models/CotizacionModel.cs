using Cotizador.Core.Entities;

namespace Cotizador.WebApi.Models
{
    public class CotizacionModel
    {
        public string Moneda { get; set; }
        public double Precio { get; set; }

        public static CotizacionModel ToModel(Cotizacion cotizacion)
        {
            return new CotizacionModel
            {
                Moneda = cotizacion.Moneda,
                Precio = cotizacion.Precio
            };
        }
    }
}
