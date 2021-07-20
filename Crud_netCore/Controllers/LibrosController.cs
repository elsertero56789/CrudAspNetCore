using System.Collections;
using System.Collections.Generic;
using Crud_netCore.Datos;
using Crud_netCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Crud_netCore.Controllers
{
    public class LibrosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LibrosController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET
        public IActionResult Index()
        {
            IEnumerable<Libro> listLibro = _context.Libro;
            return View(listLibro);
        }

        //CREATE GET
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libro.Add(libro);
                _context.SaveChanges();
                TempData["mensaje"] = "El libro se a creado correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }

        
        public IActionResult Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            
            //obtener el libro
            var libro = _context.Libro.Find(id);
            if (libro == null)
            {
                return NotFound();
            }
            
            return View(libro);
        }
        //Edit Post
        [HttpPost]
        public IActionResult Edit(Libro libro)
        {
            if(ModelState.IsValid)
            {
                _context.Libro.Update(libro);
                _context.SaveChanges();

                TempData["mensaje"] = "El libro se editó Correctamente";
                return RedirectToAction("Index");
            }

            return View();
        }
        //Delete Get
        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            
            //obtener el libro
            var libro = _context.Libro.Find(id);
            if (libro == null)
            {
                return NotFound();
            }
            
            return View(libro);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int? id)
        {
            var libro = _context.Libro.Find(id);
            if (libro == null)
            {
                return NotFound();
            }

            _context.Libro.Remove(libro);
            _context.SaveChanges();

            TempData["mensaje"] = "El libro se eliminó Correctamente";
            return RedirectToAction("Index");
        }
    }
}