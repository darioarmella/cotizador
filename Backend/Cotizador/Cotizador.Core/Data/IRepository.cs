using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Core.Data
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetAsync();
    }
}
