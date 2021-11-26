using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Entity;
namespace BLL
{
    public class SesionService
    {
        private readonly ConexionManager conexion;
        private readonly SesionRepository sesionRepository;

        public SesionService(string connectionString)
        {
            conexion = new ConexionManager(connectionString);
            sesionRepository = new SesionRepository(conexion);
        }
        public string Guardar(Sesion sesion)
        {
            try
            {
                conexion.Open();
                sesionRepository.Guardar(sesion);
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

        public DataTable ListadoPsicologos()
        {
            return sesionRepository.ListadoPsicologos();
        }
       
        public Responce BuscarPorEstado(string estado)
        {
            try
            {
                conexion.Open();
                return new Responce(sesionRepository.FiltrarPorEstado(estado));
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
        public Responce BuscarPorIdentificacion(string identificacion)
        {
            try
            {
                conexion.Open();
                return new Responce(sesionRepository.FiltrarPorIdentificacion(identificacion));
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
        public Responce BuscarPorIdentificacionPsicologo(string identificacion)
        {
            try
            {
                conexion.Open();
                return new Responce(sesionRepository.FiltrarPorIdentificacionPsicologo(identificacion));
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
        public Responce Consultar()
        {
            Responce responceSesion = new Responce();
            try
            {
                conexion.Open();
                responceSesion.Sesion = sesionRepository.Consultar();
                conexion.Close();
                if (responceSesion.Sesion.Count > 0) responceSesion.Message = "Consult successfull";
                else responceSesion.Message = "Database empty";
                responceSesion.Error = false;
                return responceSesion;
            }
            catch (Exception e)
            {
                responceSesion.Error = true;
                responceSesion.Message = $"Application Error: {e.Message}";
                return responceSesion;
            }
            finally
            {
                conexion.Close();
            }
        }
        public Responce ConsultarFecha(string fecha)
        {
            Responce responseSesion = new Responce();
            try
            {
                conexion.Open();
                responseSesion.Sesion = sesionRepository.ConsultarFechas(fecha);
                conexion.Close();
                if (responseSesion.Sesion.Count > 0) responseSesion.Message = "Consult successfull";
                else responseSesion.Message = "Database empty";
                responseSesion.Error = false;
                return responseSesion;
            }
            catch (Exception e)
            {
                responseSesion.Error = true;
                responseSesion.Message = $"Application Error {e.Message}";
                return responseSesion;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
