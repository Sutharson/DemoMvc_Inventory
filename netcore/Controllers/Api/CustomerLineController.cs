using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using netcore.Data;
using netcore.Models.Invent;

namespace netcore.Controllers.Api
{

    [Produces("application/json")]
    [Route("api/CustomerLine")]
    public class CustomerLineController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerLineController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CustomerLine
        [HttpGet]
        [Authorize]
        public IActionResult GetCustomerLine(string masterid)
        {
            return Json(new { data = _context.CustomerLine.Where(x => x.customerId.Equals(masterid)).ToList() });
        }

        // POST: api/CustomerLine
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> PostCustomerLine([FromBody] CustomerLine customerLine)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (customerLine.customerLineId == 0)
            {
                //customerLine.customerLineId = Guid.NewGuid().ToString(); //todo
                Random rnd = new Random();

                customerLine.customerLineId = rnd.Next(1, 13);
                _context.CustomerLine.Add(customerLine);
                await _context.SaveChangesAsync();
                return Json(new { success = true, message = "Add new data success." });
            }
            else
            {
                _context.Update(customerLine);
                await _context.SaveChangesAsync();
                return Json(new { success = true, message = "Edit data success." });
            }

        }

        // DELETE: api/CustomerLine/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult>  DeleteCustomerLine([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var customerLine = await _context.CustomerLine.SingleOrDefaultAsync(m => m.customerLineId == id);
            if (customerLine == null)
            {
                return NotFound();
            }

            _context.CustomerLine.Remove(customerLine);
            await _context.SaveChangesAsync();

            return Json(new { success = true, message = "Delete success." });
        }


        private bool CustomerLineExists(int id)
        {
            return _context.CustomerLine.Any(e => e.customerLineId == id);
        }


    }

}
