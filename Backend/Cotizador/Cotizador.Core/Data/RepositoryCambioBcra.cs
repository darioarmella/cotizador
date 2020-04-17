using Cotizador.Core.Entities.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cotizador.Core.Data
{
    public class RepositoryCambioBcra : RepositoryBase, IRepository<List<RespuestaBcra>>
    {
        private string _token = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE2MTgyNzExOTksInR5cGUiOiJleHRlcm5hbCIsInVzZXIiOiJkYXJpb2FybWVsbGFAaG90bWFpbC5jb20ifQ.9EJVanyXMmM2MmNZWPOFRFV68kiI5wzBXZwwhkr2ef_dT0GxL-s1_UasagFmFtu1a-UPLEKbvxzS1-TgKCazVA";

        public async Task<List<RespuestaBcra>> GetAsync()
        {
            return await this.RunAsync<List<RespuestaBcra>>("https://api.estadisticasbcra.com/usd_of", _token);
        }
    }
}
