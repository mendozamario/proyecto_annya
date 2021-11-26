using System;
using System.Linq;
using Entity;
using DAL;

namespace BLL
{
    public class PsicologoService
    {
        private readonly ConexionManager conexion;
        private readonly PsicologoRepository psicologoRepository;
        private readonly CredencialService credencialService;
        public PsicologoService(string connectionString)
        {
            conexion = new ConexionManager(connectionString);
            psicologoRepository = new PsicologoRepository(conexion);
            credencialService = new CredencialService(connectionString);
        }
        public string Guardar(Psicologo psicologo)
        {
            try
            {
                psicologo.CalcularEdad();
                Credencial credencial = new Credencial
                {
                    Id = psicologo.Identificacion.ToString(),
                    Type = "Psicologo",

                };
                credencialService.Guardar(credencial, psicologo.Nombre, psicologo.Apellido);
                conexion.Open();
                psicologoRepository.Guardar(psicologo);
                return "Guardado exitosamente";
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
            Responce responcePsicologo = new Responce();
            try
            {
                conexion.Open();
                responcePsicologo.Psicologos = psicologoRepository.Consultar();
                conexion.Close();
                if (responcePsicologo.Psicologos.Count > 0) responcePsicologo.Message = "Consult successfull";
                else responcePsicologo.Message = "Database empty";
                responcePsicologo.Error = false;
                return responcePsicologo;
            }
            catch (Exception e)
            {
                responcePsicologo.Error = true;
                responcePsicologo.Message = $"Application Error: {e.Message}";
                return responcePsicologo;
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
                return new Responce(psicologoRepository.FiltrarPorIdentificacion(identificacion));
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
        public string Modificar( Psicologo psicologo)
        {
            try
            {
                conexion.Open();
                psicologoRepository.Modificar(psicologo);
                return "Updated successfull";
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
    }
}
