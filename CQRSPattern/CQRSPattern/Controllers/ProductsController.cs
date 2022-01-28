using CQRSPattern.CQRS.Handlers;
using CQRSPattern.CQRS.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private CreateProductCommandHandler commandHandler;
        private GetAllProductsQueryHandler queryHandler;

        public ProductsController(CreateProductCommandHandler commandHandler, GetAllProductsQueryHandler queryHandler)
        {
            this.commandHandler = commandHandler;
            this.queryHandler = queryHandler;
        }
        [HttpGet()]
        public IActionResult Get()
        {
            GetAllProductsQueryRequest request = new GetAllProductsQueryRequest();
            var products = queryHandler.GetAllProduct(request);
            return Ok(products);

        }
    }
}
