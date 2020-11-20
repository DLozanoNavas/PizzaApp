using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyMvcApp.Data;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers
{
    public class PizzasController : Controller
    {
        private readonly DataBaseContext _context;

        public PizzasController(DataBaseContext context)
        {
            _context = context;
        }

        // GET: Pizzas
        public async Task<IActionResult> Index()
        {
            var dataBaseContext = _context.Pizzas.Include(p => p.Pizzeria);
            return View(await dataBaseContext.ToListAsync());
        }

        // GET: Pizzas/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas
                .Include(p => p.Pizzeria)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pizza == null)
            {
                return NotFound();
            }

            return View(pizza);
        }

        // GET: Pizzas/Create
        public IActionResult Create()
        {
            ViewData["PizzeriaID"] = new SelectList(_context.Pizzerias, "ID", "ID");
            return View();
        }

        // POST: Pizzas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ImagenUrl,Descripcion,Titulo,CostoEnPesos,PizzeriaID")] Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pizza);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PizzeriaID"] = new SelectList(_context.Pizzerias, "ID", "ID", pizza.PizzeriaID);
            return View(pizza);
        }

        // GET: Pizzas/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas.FindAsync(id);
            if (pizza == null)
            {
                return NotFound();
            }
            ViewData["PizzeriaID"] = new SelectList(_context.Pizzerias, "ID", "ID", pizza.PizzeriaID);
            return View(pizza);
        }

        // POST: Pizzas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,ImagenUrl,Descripcion,Titulo,CostoEnPesos,PizzeriaID")] Pizza pizza)
        {
            if (id != pizza.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pizza);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PizzaExists(pizza.ID))
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
            ViewData["PizzeriaID"] = new SelectList(_context.Pizzerias, "ID", "ID", pizza.PizzeriaID);
            return View(pizza);
        }

        // GET: Pizzas/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas
                .Include(p => p.Pizzeria)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pizza == null)
            {
                return NotFound();
            }

            return View(pizza);
        }

        // POST: Pizzas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var pizza = await _context.Pizzas.FindAsync(id);
            _context.Pizzas.Remove(pizza);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PizzaExists(string id)
        {
            return _context.Pizzas.Any(e => e.ID == id);
        }
    }
}
