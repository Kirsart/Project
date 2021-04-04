using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WhatToBuyAPI.Data;
using WhatToBuyLibrary.Models;

namespace WhatToBuyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductListsController : ControllerBase
    {
        private readonly WhatToBuyAPIContext _context;

        public ProductListsController(WhatToBuyAPIContext context)
        {
            _context = context;
        }

        // GET: api/ProductLists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductList>>> GetProductList()
        {
            return await _context.ProductList.ToListAsync();
        }

        // GET: api/ProductLists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductList>> GetProductList(Guid id)
        {
            var productList = await _context.ProductList.FindAsync(id);

            if (productList == null)
            {
                return NotFound();
            }

            return productList;
        }

        // PUT: api/ProductLists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductList(Guid id, ProductList productList)
        {
            if (id != productList.ProductListId)
            {
                return BadRequest();
            }

            _context.Entry(productList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductListExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProductLists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductList>> PostProductList(ProductList productList)
        {
            _context.ProductList.Add(productList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductList", new { id = productList.ProductListId }, productList);
        }

        // DELETE: api/ProductLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductList(Guid id)
        {
            var productList = await _context.ProductList.FindAsync(id);
            if (productList == null)
            {
                return NotFound();
            }

            _context.ProductList.Remove(productList);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductListExists(Guid id)
        {
            return _context.ProductList.Any(e => e.ProductListId == id);
        }
    }
}
