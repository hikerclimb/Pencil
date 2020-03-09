using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pencil.Models;
using Pencil.Models.Db;

namespace Pencil.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PencilContext _context;

        public HomeController(ILogger<HomeController> logger, PencilContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var pencils = _context.PencilTable.ToList();

            return View(pencils);
        }

        public IActionResult Product(int id)
        {
            var pencil = _context.PencilTable.Where(x => x.PencilId == id).FirstOrDefault();

            return View(pencil);
        }
    }
}
