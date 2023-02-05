using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models.Shop;

namespace WebApplication1.Controllers
{
    public class Product_SizesController : Controller
    {
        private readonly ShopDbContext _context;

        public Product_SizesController(ShopDbContext context)
        {
            _context = context;
        }

        // GET: Product_Sizes
        public async Task<IActionResult> Index()
        {
            var shopDbContext = _context.Product_Sizes.Include(p => p.Product).Include(p => p.Size);
            return View(await shopDbContext.ToListAsync());
        }

        // GET: Product_Sizes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Product_Sizes == null)
            {
                return NotFound();
            }

            var product_Sizes = await _context.Product_Sizes
                .Include(p => p.Product)
                .Include(p => p.Size)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product_Sizes == null)
            {
                return NotFound();
            }

            return View(product_Sizes);
        }

        // GET: Product_Sizes/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id");
            ViewData["SizeId"] = new SelectList(_context.Sizes, "Id", "Id");
            return View();
        }

        // POST: Product_Sizes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductId,SizeId")] Product_Sizes product_Sizes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product_Sizes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", product_Sizes.ProductId);
            ViewData["SizeId"] = new SelectList(_context.Sizes, "Id", "Id", product_Sizes.SizeId);
            return View(product_Sizes);
        }

        // GET: Product_Sizes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Product_Sizes == null)
            {
                return NotFound();
            }

            var product_Sizes = await _context.Product_Sizes.FindAsync(id);
            if (product_Sizes == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", product_Sizes.ProductId);
            ViewData["SizeId"] = new SelectList(_context.Sizes, "Id", "Id", product_Sizes.SizeId);
            return View(product_Sizes);
        }

        // POST: Product_Sizes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductId,SizeId")] Product_Sizes product_Sizes)
        {
            if (id != product_Sizes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product_Sizes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Product_SizesExists(product_Sizes.Id))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", product_Sizes.ProductId);
            ViewData["SizeId"] = new SelectList(_context.Sizes, "Id", "Id", product_Sizes.SizeId);
            return View(product_Sizes);
        }

        // GET: Product_Sizes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Product_Sizes == null)
            {
                return NotFound();
            }

            var product_Sizes = await _context.Product_Sizes
                .Include(p => p.Product)
                .Include(p => p.Size)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product_Sizes == null)
            {
                return NotFound();
            }

            return View(product_Sizes);
        }

        // POST: Product_Sizes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Product_Sizes == null)
            {
                return Problem("Entity set 'ShopDbContext.Product_Sizes'  is null.");
            }
            var product_Sizes = await _context.Product_Sizes.FindAsync(id);
            if (product_Sizes != null)
            {
                _context.Product_Sizes.Remove(product_Sizes);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Product_SizesExists(int id)
        {
          return _context.Product_Sizes.Any(e => e.Id == id);
        }
    }
}
