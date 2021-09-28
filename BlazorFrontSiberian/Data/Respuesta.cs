using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFrontSiberian.Data
{
    public class Respuesta<T> //refactorizado
    {
        public int Exito { get; set; }
        public string Mensaje { get; set; }

        public T Data { get; set; }
    }
}
