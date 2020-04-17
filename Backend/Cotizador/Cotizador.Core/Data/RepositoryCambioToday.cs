using Cotizador.Core.Entities.Common;
using System.Threading.Tasks;

namespace Cotizador.Core.Data
{
    public class RepositoryCambioToday : RepositoryBase, IRepository<RespuestaCambioToday>
    {
        public async Task<RespuestaCambioToday> GetAsync()
        {
            return await this.RunAsync<RespuestaCambioToday>("https://api.cambio.today/v1/quotes/EUR/ARS/json?quantity=1&key=4237|B050qS5g_6N6Wxt8wsPQriiw5ADc^*T6");
        }
    }
}
