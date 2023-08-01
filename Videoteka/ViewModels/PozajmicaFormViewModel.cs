using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Videoteka.Models;

namespace Videoteka.ViewModels
{
    public class PozajmicaFormViewModel
    {
        public IEnumerable<Kupac> Kupci { get; set; }
        public IEnumerable<Film> Filmovi { get; set; } 
        public Pozajmica Pozajmica { get; set; }

        public string naslov
        {
            get
            {
                if (Pozajmica != null && Pozajmica.Id != 0)
                    return "Izmijeni Pozajmicu";
                else
                    return "Novi Pozajmica";
            }
        }
    }
}