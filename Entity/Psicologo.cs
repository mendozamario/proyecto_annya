using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Psicologo : Persona
    {
        public string Especializacion { get; set; }
        public Agenda Agenda { get; set; }
        public Psicologo()
        {

        }
    }
}
