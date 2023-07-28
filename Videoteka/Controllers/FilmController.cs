using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videoteka.Models;

namespace Videoteka.Controllers
{
    public class FilmController : Controller
    {

        private ApplicationDbContext _context;

        public FilmController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Film
        public ActionResult Index()
        {
            var film = _context.Films.Include(c => c.Zanr).ToList();

            return View(film);
        }

        public ActionResult Detalji(int id)
        {
            var film = _context.Films.SingleOrDefault(c => c.Id == id);

            if (film == null)
                return HttpNotFound();

            return View(film);
        }

        
    }
}