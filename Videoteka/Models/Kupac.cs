using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Videoteka.Models
{
    public class Kupac
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Ime { get; set; }

        public bool PrimaObavjestenja { get; set; }

        [Display(Name = "Datum rođenja")]
        public DateTime? DatumRodjenja { get; set; }
        
        public TipClanstva TipClanstva { get; set; }

        [Display(Name = "Tip Clanstva")]
        public byte TipClanstvaId { get; set; }

        public TipKupca TipKupca { get; set;}

        [Display(Name = "Tip Kupca")]
        public byte TipKupcaId { get;set; }
    }
}