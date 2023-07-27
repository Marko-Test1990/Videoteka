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

        public DateTime? DatumRodjenja { get; set; }

        public TipClanstva TipClanstva { get; set; }

        public byte TipClanstvaId { get; set; }

        public TipKupca TipKupca { get; set;}
        public byte TipKupcaId { get;set; }
    }
}