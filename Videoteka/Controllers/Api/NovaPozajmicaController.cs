using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Videoteka.Models;
using Videoteka.Models.Dtos;

namespace Videoteka.Controllers.Api
{   

    public class NovaPozajmicaController : ApiController
    {
        private ApplicationDbContext _context;

        public NovaPozajmicaController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNovePozajmice (PozajmicaDto pozajmicaDto) 
        {
            

            var kupac = _context.Kupci.FirstOrDefault(c => c.Id == pozajmicaDto.KupacId);

            var filmovi = _context.Films.FirstOrDefault(f => f.Id == pozajmicaDto.FilmId);

            if (filmovi.BrojNaStanju == 0)
                return BadRequest("Film nije dostupan");


            filmovi.BrojDostupnih--;

            var novaPozajmica = new Pozajmica
            {
                KupacId = pozajmicaDto.KupacId,
                FilmId = pozajmicaDto.FilmId,
                DatumPozajmice = Convert.ToDateTime(pozajmicaDto.DatumPozajmice), 
                Napomena = pozajmicaDto.Napomena
            };

            _context.pozajmice.Add(novaPozajmica);

            _context.SaveChanges();

            

            return Ok();

            
        }
    }
}
