using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DynamicMenu.Data;
using DynamicMenu.Models;

namespace DynamicMenu.Controllers
{
    public class MainMenuController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MainMenuController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MainMenu
        public async Task<IActionResult> Index()
        {
            return View(await _context.MainMenu.ToListAsync());
        }

        // GET: MainMenu/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainMenu = await _context.MainMenu
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mainMenu == null)
            {
                return NotFound();
            }

            return View(mainMenu);
        }

        // GET: MainMenu/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MainMenu/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MenuName,ControllerName,ActionName")] MainMenu mainMenu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mainMenu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mainMenu);
        }

        // GET: MainMenu/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainMenu = await _context.MainMenu.FindAsync(id);
            if (mainMenu == null)
            {
                return NotFound();
            }
            return View(mainMenu);
        }

        // POST: MainMenu/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MenuName,ControllerName,ActionName")] MainMenu mainMenu)
        {
            if (id != mainMenu.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mainMenu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MainMenuExists(mainMenu.Id))
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
            return View(mainMenu);
        }

        // GET: MainMenu/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mainMenu = await _context.MainMenu
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mainMenu == null)
            {
                return NotFound();
            }

            return View(mainMenu);
        }

        // POST: MainMenu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mainMenu = await _context.MainMenu.FindAsync(id);
            _context.MainMenu.Remove(mainMenu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MainMenuExists(int id)
        {
            return _context.MainMenu.Any(e => e.Id == id);
        }
    }
}
