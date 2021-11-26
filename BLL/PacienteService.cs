using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using DAL;
using System.Threading.Tasks;

namespace BLL
{
    public class PacienteService
    {
        private readonly ConexionManager conexion;
        private readonly PacienteRepository pacienteRepository;

        public PacienteService(string connectionString)
        {
            conexion = new ConexionManager(connectionString);
            pacienteRepository = new PacienteRepository(conexion);
        }

        public string Guardar(Paciente paciente)
        {
            try
            {
                paciente.CalcularEdad();
                conexion.Open();
                pacienteRepository.Guardar(paciente);
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
            Responce responcePaciente = new Responce();
            try
            {
                conexion.Open();
                responcePaciente.Pacientes = pacienteRepository.Consultar();
                conexion.Close();
                if (responcePaciente.Pacientes.Count > 0) responcePaciente.Message = "Consult successfull";
                else responcePaciente.Message = "Database empty";
                responcePaciente.Error = false;
                return responcePaciente;
            }
            catch (Exception e)
            {
                responcePaciente.Error = true;
                responcePaciente.Message = $"Application Error: {e.Message}";
                return responcePaciente;
            }
            finally
            {
                conexion.Close();
            }
        }
        public Responce BuscarPorIdentificacion(string identificacion)
        {
            try
            {
                conexion.Open();
                return new Responce(pacienteRepository.FiltrarPorIdentificacion(identificacion));
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
        public Responce BuscarPorGenero(string genero)
        {
            try
            {
                conexion.Open();
                return new Responce(pacienteRepository.FiltrarPorGenero(genero));
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
