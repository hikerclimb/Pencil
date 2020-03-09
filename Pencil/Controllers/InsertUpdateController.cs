using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pencil.Models.Db;

namespace Pencil.Controllers
{
    public class InsertUpdateController : Controller
    {
        private readonly PencilContext _context;

        public InsertUpdateController(PencilContext context)
        {
            _context = context;
        }

        // GET: InsertUpdate/Create
        public IActionResult Create()
        {
            ViewData["BuyerId1"] = new SelectList(_context.BuyerTable, "BuyerId", "BuyerId");
            ViewData["BuyerId2"] = new SelectList(_context.BuyerTable, "BuyerId", "BuyerId");
            ViewData["BuyerId3"] = new SelectList(_context.BuyerTable, "BuyerId", "BuyerId");
            return View();
        }

        // POST: InsertUpdate/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PencilId,BuyerId1,BuyerId2,BuyerId3,Image,Name,Description,Price")] PencilTable pencilTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pencilTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BuyerId1"] = new SelectList(_context.BuyerTable, "BuyerId", "BuyerId", pencilTable.BuyerId1);
            ViewData["BuyerId2"] = new SelectList(_context.BuyerTable, "BuyerId", "BuyerId", pencilTable.BuyerId2);
            ViewData["BuyerId3"] = new SelectList(_context.BuyerTable, "BuyerId", "BuyerId", pencilTable.BuyerId3);
            return View(pencilTable);
        }

        // GET: InsertUpdate/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pencilTable = await _context.PencilTable.FindAsync(id);
            if (pencilTable == null)
            {
                return NotFound();
            }
            ViewData["BuyerId1"] = new SelectList(_context.BuyerTable, "BuyerId", "BuyerId", pencilTable.BuyerId1);
            ViewData["BuyerId2"] = new SelectList(_context.BuyerTable, "BuyerId", "BuyerId", pencilTable.BuyerId2);
            ViewData["BuyerId3"] = new SelectList(_context.BuyerTable, "BuyerId", "BuyerId", pencilTable.BuyerId3);
            return View(pencilTable);
        }

        // POST: InsertUpdate/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PencilId,BuyerId1,BuyerId2,BuyerId3,Image,Name,Description,Price")] PencilTable pencilTable)
        {
            if (id != pencilTable.PencilId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pencilTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PencilTableExists(pencilTable.PencilId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Home");
            }
            ViewData["BuyerId1"] = new SelectList(_context.BuyerTable, "BuyerId", "BuyerId", pencilTable.BuyerId1);
            ViewData["BuyerId2"] = new SelectList(_context.BuyerTable, "BuyerId", "BuyerId", pencilTable.BuyerId2);
            ViewData["BuyerId3"] = new SelectList(_context.BuyerTable, "BuyerId", "BuyerId", pencilTable.BuyerId3);
            return View(pencilTable);
        }

        private bool PencilTableExists(int id)
        {
            return _context.PencilTable.Any(e => e.PencilId == id);
        }
    }
}
