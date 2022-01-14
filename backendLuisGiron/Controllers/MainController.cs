using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace backendLuisGiron.Controllers
{
  public class MainController : ApiController
  {
    WSOnline.TipoCambioSoapClient ws = new WSOnline.TipoCambioSoapClient();

    [HttpGet]
    [Route("api/variablesDisponibles")]
    public IHttpActionResult variablesDisponibles()
    {
      var data = ws.VariablesDisponibles();
      return Ok(data);
    }

    [HttpGet]
    [Route("api/tipoCambioRango")]
    public IHttpActionResult tipoCambioRango(string fechaI, string fechaF)
    {
      var data = ws.TipoCambioRango(fechaI, fechaF);
      return Ok(data);
    }
  }
}