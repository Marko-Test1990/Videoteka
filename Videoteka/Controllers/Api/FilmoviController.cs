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
    public class FilmoviController : ApiController
    {
        private ApplicationDbContext _context;

        public FilmoviController()
        {
            _context = new ApplicationDbContext();
        }
        
        public IHttpActionResult GetFilmovi()
        {
            var movies = _context.Films.Where(x => x.BrojDostupnih > 0).Select(x => new FilmDto
            {
                Id = x.Id,
                Naziv = x.Naziv
            }).ToList();

            return Ok(movies);

            
        }

        public IHttpActionResult GetFilm(int id)
        {
            var film = _context.Films.SingleOrDefault(c => c.Id == id);

            if (film == null)
                return NotFound();

            return Ok(film);
        }

        [HttpPost]

        public IHttpActionResult CreateFilm(Film film)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Films.Add(film);
            _context.SaveChanges();
            return Created(new Uri(Request.RequestUri + "/" + film.Id), film);
        }
        

        [HttpDelete]
        public IHttpActionResult DeleteFilmovi(int id)
        {
            var filmUDb = _context.Films.SingleOrDefault(c => c.Id == id);

            if (filmUDb == null)
            {
                return NotFound();
            }

            _context.Films.Remove(filmUDb);
            _context.SaveChanges();

            return Ok();
        }

    }
}
