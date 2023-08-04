using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Videoteka.Models;

namespace Videoteka.Models.Dtos
{
    public class KupacDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ime Kupca je obavezno")]
        [StringLength(255)]
        public string Ime { get; set; }

        
    }
}