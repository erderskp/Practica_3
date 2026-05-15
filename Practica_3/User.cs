using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Practica_3
{
    public class User
    {
        public string Gender { get; set; }
        public string Email { get; set; }
        public Name Name { get; set; }
        public Location Location { get; set; }
    }
}
