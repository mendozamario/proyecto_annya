using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class CredencialService
    {
        private readonly ConexionManager conexion;
        private readonly CredencialRepository credencialRepository;
        public CredencialService(string connectionString)
        {
            conexion = new ConexionManager(connectionString);
            credencialRepository = new CredencialRepository(conexion);
        }
        public void Guardar(Credencial credencial, string name, string lastName)
        {
            try
            {
                credencial.Password = Seguridad.Encrypt(credencial.AutogenerateAccess(name, lastName));
                conexion.Open();
                credencialRepository.Guardar(credencial);
            }
            catch (Exception e)
            {
                string message = $"Application Error: {e.Message}";
            }
            finally
            {
                conexion.Close();
            }
        }
        public Responce Consultar(string identificacion)
        {
            Responce responseCredencial = new Responce();
            try
            {
                conexion.Open();
                responseCredencial.Credencial = credencialRepository.Consultar(identificacion);
                conexion.Close();
                if (responseCredencial.Credencial != null) responseCredencial.Message = "Consult Successfull";
                else responseCredencial.Message = "Database empty";
                responseCredencial.Error = false;
                return responseCredencial;
            }
            catch (Exception e)
            {
                responseCredencial.Error = true;
                responseCredencial.Message = $"Application Error: {e.Message}";
                return responseCredencial;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
