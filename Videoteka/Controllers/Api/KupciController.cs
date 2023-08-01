using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Videoteka.Models;

namespace Videoteka.Controllers.Api
{
    public class KupciController : ApiController
    {
        private ApplicationDbContext _context;

        public KupciController()
        {
            _context = new ApplicationDbContext();
        }


        public IEnumerable<Kupac> GetKupci()
        {
            return _context.Kupci.ToList();
        }

        public IHttpActionResult GetKupac(int id)
        {
            var kupac = _context.Kupci.SingleOrDefault(c => c.Id == id);

            if (kupac == null)
                return NotFound();

            return Ok(kupac);
        }

        [HttpPost]
        public IHttpActionResult CreateKupac(Kupac kupac)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Kupci.Add(kupac);
            _context.SaveChanges();
            return Created(new Uri(Request.RequestUri + "/" + kupac.Id), kupac);
        }

        [HttpDelete]
        public IHttpActionResult DeleteKupci(int id)
        {
            var kupacUDb = _context.Kupci.SingleOrDefault(c => c.Id == id);

            if (kupacUDb == null)
            {
                return NotFound();
            }

            _context.Kupci.Remove(kupacUDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
