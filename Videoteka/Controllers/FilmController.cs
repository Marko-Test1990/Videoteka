using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videoteka.Models;
using Videoteka.ViewModels;

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

        public ActionResult Novi() 
        {   
            var zanr = _context.Zanrovi.ToList();
            var viewModel = new FilmFormViewModel 
            {
                Zanrovi = zanr
            };
            return View(viewModel); 
        }
        [HttpPost]
        public ActionResult Sacuvaj(Film film)
        {
            if (film.Id == 0)
                _context.Films.Add(film);
            else
            {
                var filmUDb = _context.Films.Single(c => c.Id == film.Id);

                filmUDb.Naziv = film.Naziv;
                filmUDb.DatumUnosa = film.DatumUnosa;
                filmUDb.ZanrId = film.ZanrId;
                filmUDb.DatumIzdanja = film.DatumIzdanja;
                filmUDb.BrojNaStanju = film.BrojNaStanju;
                filmUDb.BrojDostupnih = film.BrojDostupnih;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Film");
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

        public ActionResult Izmjena(int id)
        {
            var film = _context.Films.SingleOrDefault(c => c.Id == id);
            if (film == null)
                return HttpNotFound();

            var viewModel = new FilmFormViewModel
            {
                film = film,
                Zanrovi = _context.Zanrovi.ToList()                
            };
            return View("Novi", viewModel);
        }
    }
}