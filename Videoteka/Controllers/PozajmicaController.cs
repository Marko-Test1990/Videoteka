using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Videoteka.Models;
using Videoteka.ViewModels;

namespace Videoteka.Controllers
{
    public class PozajmicaController : Controller
    {
        private ApplicationDbContext _context;

        public PozajmicaController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Pozajmica  .Include(c => c.Kupac).Include(c => c.Film)
        public ActionResult Index()
        {
            var pozajmica = _context.pozajmice.Include(c => c.Kupac).Include(c => c.Film).ToList();

            return View(pozajmica);
            
        }

        public ActionResult Nova()
        {
            var kupac = _context.Kupci.ToList();
            var film = _context.Films.ToList();
            var viewModel = new PozajmicaFormViewModel
            {   
                Kupci= kupac,
                Filmovi=film
                
            };
            return View(viewModel);
        }


    }
}
