using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Videoteka.Models;

namespace Videoteka.ViewModels
{
    public class FilmFormViewModel
    {
        public IEnumerable<Zanr> Zanrovi { get; set; }
        public Film film { get; set; }
        public string naslov
        {
            get
            {
                if (film != null && film.Id != 0)
                    return "Izmijeni Film";
                else
                    return "Novi Film";
            }
        }
    }
}