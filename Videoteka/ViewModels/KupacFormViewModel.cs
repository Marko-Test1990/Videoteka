using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Videoteka.Models;

namespace Videoteka.ViewModels
{
    public class KupacFormViewModel
    {
        public IEnumerable<TipClanstva> tipClanstvas { get; set; }
        public IEnumerable<TipKupca> tipKupcas { get; set; }
        public Kupac kupac { get; set;}

        public string naslov 
        {
            get 
            {
                if (kupac != null && kupac.Id != 0)
                    return "Izmijeni Kupaca";
                else
                    return "Novi Kupac";
            }
        }
    }
}