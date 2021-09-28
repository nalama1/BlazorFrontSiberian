﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFrontSiberian.Data
{
    //public class Restaurante
    //{
    //}
    public partial class Restaurante
    {
        public int Idrestaurante { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Ingrese mínimo 2 caracteres")]
        public string NombreRestaurante { get; set; }
        public int? Idciudad { get; set; }
        [Required]
        public int? NumeroAforo { get; set; }
        [Required]
        public int? Telefono { get; set; }
        [Required]
        public DateTime? FechaCreacion { get; set; }

        //public virtual Ciudad IdciudadNavigation { get; set; }
    }
}
