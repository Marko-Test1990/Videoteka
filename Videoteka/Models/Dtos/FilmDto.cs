using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Videoteka.Models.Dtos
{
    public class FilmDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Naziv Filma je obavezan")]
        [StringLength(255)]
        public string Naziv { get; set; }

    }
}