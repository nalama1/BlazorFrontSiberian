using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFrontSiberian.Data
{
    public class Ciudad
    {     
        public int Idciudad { get; set; }

        [Required(ErrorMessage ="El nombre es obligatorio")]
        [MinLength(2, ErrorMessage = "Ingrese mínimo 2 caracteres")]
        public string NombreCiudad { get; set; }


        [Required(ErrorMessage = "La fecha es obligatorio")]
        [Display(Name ="Fecha de creación")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:YYYY-MM-dd}", ApplyFormatInEditMode = true)]
        [Range(typeof(DateTime), "2000/1/1", "2021/12/12",
        ErrorMessage = "El valor de la {0} debe ser mayor a {1} ")]
        public DateTime FechaCreacion { get; set; }
    }
}
