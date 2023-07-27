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

        [StringLength(255)]
        public string Naziv { get; set; }

        public Zanr Zanr { get; set; }

        public byte ZanrId { get; set; }

        public DateTime? DatumUnosa { get; set; }

        public DateTime? DatumIzdanja { get; set; }

        public byte BrojNaStanju { get; set; }

        public byte BrojDostupnih { get; set; }
    }
}