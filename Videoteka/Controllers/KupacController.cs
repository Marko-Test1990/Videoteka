using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videoteka.Models;

namespace Videoteka.Controllers
{
    public class KupacController : Controller
    {   


        private ApplicationDbContext _context;

        public KupacController() 
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing) 
        {
            _context.Dispose();
        }
        // GET: Kupac
        public ActionResult Index()
        {
            var kupac = _context.Kupci.Include(c => c.TipKupca).ToList();

            return View(kupac);
        }

        public ActionResult Detalji(int id)
        {
            var kupac = _context.Kupci.SingleOrDefault(c => c.Id == id);

            if (kupac == null)
                return HttpNotFound();

            return View(kupac);
        }

        
    }
}