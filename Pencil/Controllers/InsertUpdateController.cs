using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Contentful.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pencil.Models;
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
            ViewBag.BuyerId1 = new SelectList(_context.BuyerTable.Take(4), "BuyerId", "Buyer");
            ViewBag.BuyerId2 = new SelectList(_context.BuyerTable.Take(4), "BuyerId", "Buyer");
            ViewBag.BuyerId3 = new SelectList(_context.BuyerTable.Take(4), "BuyerId", "Buyer");
            return View();
        }

        // POST: InsertUpdate/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BuyerId1,BuyerId2,BuyerId3,Name,Description,Price")] PencilViewModel pencilViewModel, IFormFile file)
        {
            PencilTable pencilTable = new PencilTable();
            
            pencilTable.BuyerId1 = pencilViewModel.BuyerId1;
            pencilTable.BuyerId2 = pencilViewModel.BuyerId2;
            pencilTable.BuyerId3 = pencilViewModel.BuyerId3;
            pencilTable.Image = pencilViewModel.Image;
            pencilTable.Name = pencilViewModel.Name;
            pencilTable.Description = pencilViewModel.Description;
            pencilTable.Price = pencilViewModel.Price;

            if (file != null)
            {
                string fileName;
                using (var reader = new StreamReader(file.OpenReadStream()))
                {
                    var parsedContentDisposition = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
                    fileName = parsedContentDisposition.FileName;
                }
                pencilTable.Image = System.IO.File.ReadAllBytes(fileName.Replace("\"", string.Empty).Replace("'", string.Empty));
            }
            if (ModelState.IsValid)
            {
                _context.Add(pencilTable);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
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
            
            ViewBag.BuyerId1 = new SelectList(_context.BuyerTable.Take(4), "BuyerId", "Buyer");
            ViewBag.BuyerId2 = new SelectList(_context.BuyerTable.Take(4), "BuyerId", "Buyer");
            ViewBag.BuyerId3 = new SelectList(_context.BuyerTable.Take(4), "BuyerId", "Buyer");

            return View(pencilTable);
        }

        // POST: InsertUpdate/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PencilId,BuyerId1,BuyerId2,BuyerId3,Name,Description,Price")] PencilTable pencilTable, IFormFile file)
        {
            if (file != null)
            {
                string fileName;
                using (var reader = new StreamReader(file.OpenReadStream()))
                {
                    var parsedContentDisposition = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
                    fileName = parsedContentDisposition.FileName;
                }
                pencilTable.Image = System.IO.File.ReadAllBytes(fileName.Replace("\"", string.Empty).Replace("'", string.Empty));
            }

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
