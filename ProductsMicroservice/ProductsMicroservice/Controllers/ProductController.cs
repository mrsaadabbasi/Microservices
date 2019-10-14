using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductsMicroservice.Models;
using ProductsMicroservice.Models.Repository;

namespace ProductsMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IDataRepository<Products> _dataRepository;

        public ProductController(IDataRepository<Products> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Product
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Products> product = _dataRepository.GetAll();
            return Ok(product);
        }

        // GET: api/Product/5
        [AllowAnonymous]
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            Products product = _dataRepository.Get(id);

            if (product == null)
            {
                return NotFound("The Product record couldn't be found.");
            }

            return Ok(product);
        }

        // POST: api/Employee
        [HttpPost]
        public IActionResult Post([FromBody] Products product)
        {
            if (product == null)
            {
                return BadRequest("Product is null.");
            }

            _dataRepository.Add(product);
            return CreatedAtRoute(
                  "Get",
                  new { Id = product.Id },
                  product);
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Products product)
        {
            if (product == null)
            {
                return BadRequest("Product is null.");
            }

            Products productToUpdate = _dataRepository.Get(id);
            if (productToUpdate == null)
            {
                return NotFound("The Product record couldn't be found.");
            }

            _dataRepository.Update(productToUpdate, product);
            return NoContent();
        }

        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Products product = _dataRepository.Get(id);
            if (product == null)
            {
                return NotFound("The Product record couldn't be found.");
            }

            _dataRepository.Delete(product);
            return NoContent();
        }
    }
}