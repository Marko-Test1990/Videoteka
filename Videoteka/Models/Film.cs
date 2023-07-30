using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Videoteka.Models
{
    public class Film
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Naziv Filma je obavezan")]
        [StringLength(255)]
        public string Naziv { get; set; }

        public Zanr Zanr { get; set; }

        [Required(ErrorMessage ="Zanr je obavezan")]
        [Display(Name = "Zanr")]
        public byte ZanrId { get; set; }

        [Display(Name = "Datum Unosa")]
        public DateTime? DatumUnosa { get; set; }

        [Display(Name = "Datum Izdanja")]
        public DateTime? DatumIzdanja { get; set; }

        [Required(ErrorMessage = "Broj na Stanju je obavezan")]
        [Display(Name = "Broj na Stanju")]
        public byte BrojNaStanju { get; set; }

        [Required(ErrorMessage = "Broj Dostupnih je obavezan")]
        [Display(Name = "Broj Dostupnih")]
        public byte BrojDostupnih { get; set; }
    }
}