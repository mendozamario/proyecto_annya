using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Sesion
    {
        public int IdSesion { get; set; }
        public Paciente Paciente { get; set; }
        public Psicologo Psicologo { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public NotasSesion NotaSesion { get; set; }
        public string Estado { get; set; }
        
    }
}
