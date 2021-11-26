using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Entity;
using System.Threading.Tasks;

namespace BLL
{
    public class NotasService
    {
        private readonly ConexionManager conexion;
        private readonly NotasRepository notasRepository;

        public NotasService(string connectionString)
        {
            conexion = new ConexionManager(connectionString);
            notasRepository = new NotasRepository(conexion);
        }
        public string Guardar(NotasSesion nota)
        {
            try
            {
                conexion.Open();
                notasRepository.Guardar(nota);
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
