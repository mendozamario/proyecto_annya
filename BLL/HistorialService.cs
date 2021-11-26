using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace BLL
{
    public class HistorialService
    {
        private readonly ConexionManager conexion;
        private readonly HistorialRepository historialRepository;

        public HistorialService(string connectionString)
        {
            conexion = new ConexionManager(connectionString);
            historialRepository = new HistorialRepository(conexion);
        }
        public string Guardar(HistorialSesion historial)
        {
            try
            {
                conexion.Open();
                historialRepository.Guardar(historial);
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
    }
}
