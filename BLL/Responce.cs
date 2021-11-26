using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace BLL
{
    public class Responce
    {
        public Responce()
        {
        }

        public Responce(List<Psicologo> psicologos)
        {
            Psicologos = psicologos;
            Error = false;
        }
        public Responce(List<Paciente> pacientes)
        {
            Pacientes = pacientes;
            Error = false;
        }
        public Responce(List<Sesion> sesions)
        {
            this.Sesion = sesions;
            Error = false;
        }
        public Responce (List<Agenda> agendas)
        {
            Agenda = agendas;
            Error = false;
        }
        public Responce(Credencial credencial)
        {
            Credencial = credencial;
            Error = false;
        }
        public Responce(string mensaje)
        {
            Error = true;
            Message = mensaje;
        }

        public bool Error { get; set; }
        public string Message { get; set; }
        public List<Paciente> Pacientes { get; set; }
        public List<Psicologo> Psicologos { get; set; }
        public List<Sesion> Sesion { get; set; }
        public List<Agenda> Agenda { get; set; }
        public Credencial Credencial { get; set; }
    }
}
