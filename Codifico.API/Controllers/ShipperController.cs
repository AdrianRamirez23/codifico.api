using Codifico.Bussiness.Interfaces;
using Codifico.Models.RTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codifico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        private readonly IShipperBS _shipper;
        public ShipperController(IShipperBS shipper)
        {
            _shipper = shipper;

        }
        [HttpGet]
        [Route("GetShipper")]
        public IActionResult GetShipper()
        {
            try
            {
                var result = _shipper.GetShippers();
                return Ok(new
                {
                    Estado = true,
                    Mensaje = "Transportistas Listados",
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
