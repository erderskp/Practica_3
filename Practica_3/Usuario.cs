using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Practica_3
{
    public class Usuario
    {
        public string Genero { get; set; }
        public string Email { get; set; }
        public Nombre Nombre { get; set; }
        public Ubicacion Ubicacion { get; set; }
    }
}
