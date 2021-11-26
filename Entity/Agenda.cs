using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Agenda
    {
        public int IdAgenda { get; set; }
        public Psicologo Psicologo { get; set; }
        public Sesion Sesion { get; set; }
        public List<Sesion> Sesiones { get; set; }
        public List<Psicologo> Psicologos { get; set; }

        public void RegistrarSesion(Sesion sesion)
        {
            foreach (var item in Psicologos)
            {
                if (sesion.Psicologo.Identificacion == item.Identificacion)
                {
                    Sesiones.Add(sesion);
                }
            }  
        }
    }
}
