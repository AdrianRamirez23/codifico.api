using Codifico.Bussiness.Interfaces;
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
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployBS _employ;
        public EmployeesController(IEmployBS employBS) 
        {
            _employ = employBS;

        }
        [HttpGet]
        [Route("GetEmployees")]
        public IActionResult GetEmployees()
        {
            try
            {
                var result = _employ.GetEmployees();
                return Ok(new
                {
                    Estado = true,
                    Mensaje = "Empleados Listados",
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
