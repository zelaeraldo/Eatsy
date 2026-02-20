using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eatsy1.Data;
using Eatsy1.Models;

namespace Eatsy1.Controllers
{
    public class DeliveryDriversController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DeliveryDriversController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DeliveryDrivers
        public async Task<IActionResult> Index()
        {
              return _context.DeliveryDriver != null ? 
                          View(await _context.DeliveryDriver.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.DeliveryDriver'  is null.");
        }

        // GET: DeliveryDrivers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DeliveryDriver == null)
            {
                return NotFound();
            }

            var deliveryDriver = await _context.DeliveryDriver
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deliveryDriver == null)
            {
                return NotFound();
            }

            return View(deliveryDriver);
        }

        // GET: DeliveryDrivers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DeliveryDrivers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,PhoneNumber,VehicleDetails")] DeliveryDriver deliveryDriver)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deliveryDriver);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deliveryDriver);
        }

        // GET: DeliveryDrivers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DeliveryDriver == null)
            {
                return NotFound();
            }

            var deliveryDriver = await _context.DeliveryDriver.FindAsync(id);
            if (deliveryDriver == null)
            {
                return NotFound();
            }
            return View(deliveryDriver);
        }

        // POST: DeliveryDrivers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,PhoneNumber,VehicleDetails")] DeliveryDriver deliveryDriver)
        {
            if (id != deliveryDriver.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deliveryDriver);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliveryDriverExists(deliveryDriver.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(deliveryDriver);
        }

        // GET: DeliveryDrivers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DeliveryDriver == null)
            {
                return NotFound();
            }

            var deliveryDriver = await _context.DeliveryDriver
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deliveryDriver == null)
            {
                return NotFound();
            }

            return View(deliveryDriver);
        }

        // POST: DeliveryDrivers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DeliveryDriver == null)
            {
                return Problem("Entity set 'ApplicationDbContext.DeliveryDriver'  is null.");
            }
            var deliveryDriver = await _context.DeliveryDriver.FindAsync(id);
            if (deliveryDriver != null)
            {
                _context.DeliveryDriver.Remove(deliveryDriver);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeliveryDriverExists(int id)
        {
          return (_context.DeliveryDriver?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
