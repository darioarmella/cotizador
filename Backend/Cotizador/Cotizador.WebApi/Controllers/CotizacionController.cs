using Cotizador.Core.Entities;
using Cotizador.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cotizador.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotizacionController : ControllerBase
    {
        [HttpGet("{moneda}", Name = "Get")]
        public ActionResult<CotizacionModel> Get(string moneda)
        {
            if(!string.IsNullOrEmpty(moneda))
            {
                MonedaFactory factory = new MonedaFactory();
                var monedaConcreta = factory.CreateInstance(moneda);

                var cotizacion = CotizacionModel.ToModel(monedaConcreta.GetCotizacion());

                return cotizacion;
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
