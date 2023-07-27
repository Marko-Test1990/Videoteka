using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Videoteka.Models
{
    public class Pozajmica
    {
        public int Id { get; set; }

        public Kupac Kupac { get; set; }
        public int KupacId { get; set; }

        public Film Film { get; set; }
        public int FilmId { get; set; }

        public DateTime? DatumPozajmice { get; set; }
        public DateTime? DatumVracanja { get; set; }


        [StringLength(255)]
        public string Napomena { get; set; }
    }
}