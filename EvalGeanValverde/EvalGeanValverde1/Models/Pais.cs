using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EvalGeanValverde1.Models
{

    public class Pais
    {
        [Key]
        public string NombrePais { get; set; }

        [Required]
        [Display(Name = "Nombre del Pais")]
        public string Capital { get; set; }

        [Required]
        public int Population { get; set; }

        [Required]
        public string Lating { get; set; }

        [Required]
        public string Timezones { get; set; }

        [Required]
        public string Currencies { get; set; }

        [Required]
        public string Flag { get; set; }
    }
}