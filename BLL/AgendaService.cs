using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class AgendaService
    {
        private readonly ConexionManager conexion;
        private readonly AgendaRepository agendaRepository;

        public AgendaService(string connectionString)
        {
            conexion = new ConexionManager(connectionString);
            agendaRepository = new AgendaRepository(conexion);
        }
        public string Guardar(Agenda agenda)
        {
            try
            {
                conexion.Open();
                agendaRepository.Guardar(agenda);
                return "Guardo exitosamente";
            }
            catch (Exception e)
            {
                return $"Application Error: {e.Message}";
            }
            finally
            {
                conexion.Close();
            }
        }
        public Responce Consultar()
        {
            Responce responceAgenda = new Responce();
            try
            {
                conexion.Open();
                responceAgenda.Agenda = agendaRepository.Consultar();
                conexion.Close();
                if (responceAgenda.Agenda.Count > 0) responceAgenda.Message = "Consult successfull";
                else responceAgenda.Message = "Database empty";
                responceAgenda.Error = false;
                return responceAgenda;
            }
            catch (Exception e)
            {
                responceAgenda.Error = true;
                responceAgenda.Message = $"Application Error: {e.Message}";
                return responceAgenda;
            }
            finally
            {
                conexion.Close();
            }
        }
        public DataTable ListadoAgenda()
        {
            return agendaRepository.ListadoPsicologos();
        }
        public Responce BuscarPorIdentificacion(string identificacion)
        {
            try
            {
                conexion.Open();
                return new Responce(agendaRepository.FiltrarPorIdentificacion(identificacion));
            }
            catch (Exception exception)
            {
                return new Responce("Se presentó el siguiente error:" + exception.Message);
            }
            finally
            {
                conexion.Close();
            }

        }
    }
}
