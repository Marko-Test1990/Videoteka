using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Videoteka.Models.Dtos
{
    public class PozajmicaDto
    {
        
        [Display(Name = "Kupac")]
        public int KupacId { get; set; }

        [Display(Name = "Film")]
        public int FilmId { get; set; }

        public DateTime? DatumPozajmice { get; set; }
       
        [StringLength(255)]
        public string Napomena { get; set; }
    }
}