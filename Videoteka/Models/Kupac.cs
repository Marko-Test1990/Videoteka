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

        [Required(ErrorMessage ="Ime Kupca je obavezno")]
        [StringLength(255)]
        public string Ime { get; set; }

        public bool PrimaObavjestenja { get; set; }

        [Display(Name = "Datum rođenja")]
        public DateTime? DatumRodjenja { get; set; }
        
        public TipClanstva TipClanstva { get; set; }

        [Required(ErrorMessage ="Tip Clanstva je obavezan")]
        [Display(Name = "Tip Clanstva")]
        public byte TipClanstvaId { get; set; }

        public TipKupca TipKupca { get; set;}

        [Required(ErrorMessage ="Tip Kupca je obavezan")]
        [Display(Name = "Tip Kupca")]
        public byte TipKupcaId { get;set; }
    }
}