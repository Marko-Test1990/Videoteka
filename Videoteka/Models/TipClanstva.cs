using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Videoteka.Models
{
    public class TipClanstva
    {
        public byte Id { get; set; }
        public short Clanarina { get; set; }
        public byte TrajanjeMjeseci { get; set; }
        public byte ProcenatPopusta { get; set; }

        [StringLength(50)]
        public string Naziv { get; set; }
    }
}