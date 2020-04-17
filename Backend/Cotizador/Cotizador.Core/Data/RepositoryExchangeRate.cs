using Cotizador.Core.Entities.Common;
using System.Threading.Tasks;

namespace Cotizador.Core.Data
{
    public class RepositoryExchangeRate : RepositoryBase, IRepository<RespuestaExchangeRate>
    {
        public async Task<RespuestaExchangeRate> GetAsync()
        {
            return await this.RunAsync<RespuestaExchangeRate>("https://prime.exchangerate-api.com/v5/216f9132253c53f46ff0a6ad/latest/BRL");
        }
    }
}
