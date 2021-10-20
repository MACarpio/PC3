using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pc3practica.Models;
using Pc3practica.Data;
using Microsoft.EntityFrameworkCore;

namespace Pc3practica.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
  private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            
            _context = context;
        }
       
 public async Task<IActionResult> Index()
        {
            return View(await _context.DataProductos.ToListAsync());
        }
    
        // GET: Producto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.DataProductos
                .FirstOrDefaultAsync(m => m.ID == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Producto/Create
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,nombre,precio,imagen,categoria,telefono,descripcion,nombrecomp,lugar")] Productos producto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
               
               
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        private bool ProductoExists(int id)
        {
            return _context.DataProductos.Any(e => e.ID == id);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    
}
