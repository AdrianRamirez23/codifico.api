using Codifico.Bussiness.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codifico.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IClientsBS _clients;
        public ClientesController(IClientsBS clientsBS)
        {
            _clients = clientsBS;
        }

        [HttpGet]
        [Route("SalesDatePrediction")]
        public IActionResult SalesDatePrediction()
        {
            try
            {
                var result = _clients.SalesDatePrediction();
                return Ok(new
                {
                    Estado = true,
                    Mensaje = "Clientes Listados",
                    Result = result
                });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message.ToString());
            }
        }
        [HttpGet]
        [Route("getClientsOrders/{id}")]
        public IActionResult getClientsOrders([FromRoute] int id)
        {
            try
            {
                var result = _clients.getClientsOrders(id);
                return Ok(new
                {
                    Estado = true,
                    Mensaje = "Ordenes por cliente listados",
                    Result = result
                });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message.ToString());
            }
        }
    }
}
