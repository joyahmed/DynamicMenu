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
    public class SubMenuController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubMenuController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SubMenu
        public async Task<IActionResult> Index()
        {
            return View(await _context.SubMenu.ToListAsync());
        }

        // GET: SubMenu/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subMenu = await _context.SubMenu
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subMenu == null)
            {
                return NotFound();
            }

            return View(subMenu);
        }

        // GET: SubMenu/Create
        public IActionResult Create()
        {
            ViewData["Id"] = new SelectList(_context.MainMenu, "Id", "MenuName"); 
            return View();
        }

        // POST: SubMenu/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MainMenuId,TopMenuSelector,SubMenuName,ControllerName,ActionName")] SubMenu subMenu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subMenu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subMenu);
        }

        // GET: SubMenu/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subMenu = await _context.SubMenu.FindAsync(id);
            if (subMenu == null)
            {
                return NotFound();
            }
            return View(subMenu);
        }

        // POST: SubMenu/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MainMenuId,TopMenuSelector,SubMenuName,ControllerName,ActionName")] SubMenu subMenu)
        {
            if (id != subMenu.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subMenu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubMenuExists(subMenu.Id))
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
            return View(subMenu);
        }

        // GET: SubMenu/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subMenu = await _context.SubMenu
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subMenu == null)
            {
                return NotFound();
            }

            return View(subMenu);
        }

        // POST: SubMenu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subMenu = await _context.SubMenu.FindAsync(id);
            _context.SubMenu.Remove(subMenu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubMenuExists(int id)
        {
            return _context.SubMenu.Any(e => e.Id == id);
        }
    }
}
