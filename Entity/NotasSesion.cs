using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class NotasSesion
    {   
        public int IdNotas { get; set; }
        public Sesion Sesion { get; set; }
        public string Nota { get; set; }
        public string Diagnostico { get; set; }
    }
}
