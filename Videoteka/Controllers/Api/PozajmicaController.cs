using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Videoteka.Models;

namespace Videoteka.Controllers.Api
{
    public class PozajmicaController : ApiController
    {   
        private ApplicationDbContext _context;

        public PozajmicaController() 
        {
            _context = new ApplicationDbContext();
        }

        //Remove Later?
        public IEnumerable<Pozajmica> GetPozajmice() 
        {
            return _context.pozajmice.ToList();
        }

        //Remove Later?
        public IHttpActionResult GetPozajmica(int id) 
        {
            var pozajmica = _context.pozajmice.SingleOrDefault(c  => c.Id == id);

            if(pozajmica == null)
                return NotFound();

            return Ok(pozajmica);
        }
        

        [HttpDelete]
        public IHttpActionResult DeletePozajmica (int id) 
        {
            var pozajmicaUDb = _context.pozajmice.SingleOrDefault(c => c.Id == id);

            if(pozajmicaUDb == null) 
            {
                return NotFound();
            }

            _context.pozajmice.Remove(pozajmicaUDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
