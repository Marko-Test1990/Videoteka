using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videoteka.Models;
using Videoteka.ViewModels;

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

        public ActionResult Novi() 
        {   
            var tipClanstva = _context.TipClanstava.ToList();
            var tipKupca = _context.tipKupcas.ToList();
            var viewModel = new KupacFormViewModel
            {
                tipClanstvas = tipClanstva,
                tipKupcas = tipKupca
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Sacuvaj(Kupac kupac) 
        {   
            if(kupac.Id==0)
                _context.Kupci.Add(kupac);
            else 
            {
                var kupacUDb = _context.Kupci.Single(c => c.Id == kupac.Id);

                kupacUDb.Ime=kupac.Ime;
                kupacUDb.DatumRodjenja=kupac.DatumRodjenja;
                kupacUDb.TipKupcaId=kupac.TipKupcaId;
                kupacUDb.TipClanstvaId=kupac.TipClanstvaId;
                kupacUDb.PrimaObavjestenja = kupac.PrimaObavjestenja;
            }
            _context.SaveChanges();

            return RedirectToAction("Index","Kupac");
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
        public ActionResult Izmjena (int id) 
        {
            var kupac = _context.Kupci.SingleOrDefault(c => c.Id == id);
            if(kupac == null)
                return HttpNotFound();

            var viewModel = new KupacFormViewModel
            {
                kupac = kupac,
                tipClanstvas=_context.TipClanstava.ToList(),
                tipKupcas=_context.tipKupcas.ToList()
            };
            return View("Novi", viewModel);
        }
        
    }
}