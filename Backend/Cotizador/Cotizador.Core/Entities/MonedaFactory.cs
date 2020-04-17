using Cotizador.Core.Business;

namespace Cotizador.Core.Entities
{
    public class MonedaFactory
    {
        public MonedaContext CreateInstance(string moneda)
        {
            MonedaContext resultado;

            switch (moneda)
            {
                case "dolar":
                    resultado = new MonedaContext(new DolarCotizacionStrategy());
                    break;
                case "euro":
                    resultado = new MonedaContext(new EuroCotizacionStrategy());
                    break;
                case "real":
                    resultado = new MonedaContext(new RealCotizacionStrategy());
                    break;
                default:
                    resultado = null;
                    break;
            }

            return resultado;
        }
    }
}
