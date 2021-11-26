using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class HistorialRepository
    {
        private readonly MySqlConnection _conexion;
        public HistorialRepository(ConexionManager conexion)
        {
            _conexion = conexion._conexion;
        }
        public int Guardar(HistorialSesion historial)
        {
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = @"INSERT INTO Agenda HistorialSesion (@IdHistorial, @IdSesionH, @IdPacienteH)";
                command.Parameters.Add("Id", MySqlDbType.Int64).Value = historial.IdHistorial;
                command.Parameters.Add("IdSesionH", MySqlDbType.VarChar).Value = historial.Sesion.IdSesion;
                command.Parameters.Add("IdPacienteH", MySqlDbType.VarChar).Value = historial.Sesion.Paciente.Identificacion;
                var rows = command.ExecuteNonQuery();
                return rows;
            }
        }
    }
}
