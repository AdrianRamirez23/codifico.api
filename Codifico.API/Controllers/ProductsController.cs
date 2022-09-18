using Codifico.Bussiness.Interfaces;
using Codifico.Models.DTO;
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
    public class ProductsController : ControllerBase
    {
        private readonly IProductsBS products;
        public ProductsController(IProductsBS productsBS)
        {
            products = productsBS;
        }
        [HttpGet]
        [Route("GetProducts")]
        public IActionResult GetProducts()
        {
            try
            {
                var result = products.GetProducts();
                return Ok(new
                {
                    Estado = true,
                    Mensaje = "Productos Listados",
                    Result = result
                });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message.ToString());
            }
        }
        [HttpPost]
        [Route("AddNewOrder")]
        public IActionResult AddNewOrder(OrderNew ordersNew)
        {
            if (ModelState.IsValid) 
            {
                try
                {
                    products.AddNewOrder(ordersNew);
                    return Ok(new
                    {
                        Estado = true,
                        Mensaje = "Nueva orden con Producto Creado",
                        Result = ordersNew
                    });

                }
                catch (Exception ex)
                {

                    return NotFound(ex.Message.ToString());
                }
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
