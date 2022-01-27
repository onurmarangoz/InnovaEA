using EA.ProductCatalogue.Business;
using EA.ProductCatalogue.Business.DTO.Requests;
using EA.ProductCatalogue.Business.DTO.Responses;
using EA.ProductCatalogue.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EA.ProductCatalogue.API.Filter;

namespace EA.ProductCatalogue.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await productService.GetProducts();
            return Ok(products);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            ProductListResponse product = await productService.GetProductById(id);
            return Ok(product);

        }


        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductRequest product)
        {
            if (ModelState.IsValid)
            {
                // TODO 1: Exception Handling kavramını .NET Core middleware ya da filter ile yaz:
                var addedProduct = await productService.AddProduct(product);
                return CreatedAtAction(nameof(GetById), new { id = addedProduct.Id }, addedProduct);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        [ProductExist]
        public async Task<IActionResult> Update(int id, UpdateProductRequest updateProductRequest)
        {

            if (ModelState.IsValid)
            {
                Product updatedProduct = await productService.UpdateProduct(updateProductRequest);
                return Ok(updateProductRequest);
            }

            return BadRequest(ModelState);
        }
        [HttpDelete("{id}")]
        [ProductExist]
        public async Task<IActionResult> Delete(int id)
        {
            await productService.Delete(id);
            return Ok();

        }

    }
}
