using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
    public class SesionRepository
    {
        private readonly MySqlConnection _conexion;
        
        public SesionRepository(ConexionManager conexion)
        {
            _conexion = conexion._conexion;
        }
        public DataTable ListadoPsicologos()
        {
            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter("ListarPsicologo;", _conexion))
            {
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }

        }
        
        


        public int Guardar(Sesion sesion)
        {
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = @"INSERT INTO Sesion VALUES (@Id, @IdPsicologo, @IdPaciente,@Fecha, @Hora, @Estado)";
                command.Parameters.Add("Id", MySqlDbType.Int32).Value = sesion.IdSesion;
                command.Parameters.Add("IdPsicologo", MySqlDbType.VarChar).Value = sesion.Psicologo.Identificacion;
                command.Parameters.Add("IdPaciente", MySqlDbType.VarChar).Value = sesion.Paciente.Identificacion;
                command.Parameters.Add("Fecha", MySqlDbType.VarChar).Value = sesion.Fecha;
                command.Parameters.Add("Hora", MySqlDbType.VarChar).Value = sesion.Hora;
                command.Parameters.Add("Estado", MySqlDbType.VarChar).Value = sesion.Estado;
                var rows = command.ExecuteNonQuery();
                return rows;
            }
        }
        
        public List<Sesion> Consultar()
        {
            MySqlDataReader dataReader;
            List<Sesion> sesion = new List<Sesion>();
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Sesion";
                dataReader = command.ExecuteReader();
                
                    while (dataReader.Read())
                    {
                        Sesion sesiones = Mapear(dataReader);
                        sesion.Add(sesiones);
                    }
                dataReader.Close();
            }
            return sesion;
        }
        public List<Sesion> FiltrarPorEstado(string estado)
        {
            return (from p in Consultar()
                    where p.Estado.Equals(estado)
                    select p).ToList();
        }
        public List<Sesion> FiltrarPorIdentificacion(string identificacion)
        {
            return (from p in Consultar()
                    where p.IdSesion.ToString().Contains(identificacion)
                    select p).ToList();
        }
        public List<Sesion> FiltrarPorIdentificacionPsicologo(string identificacion)
        {
            return (from p in Consultar()
                    where p.Psicologo.Identificacion.ToString().Contains(identificacion)
                    select p).ToList();
        }

        private Sesion Mapear(MySqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Psicologo psicologo = new Psicologo
            {
                Identificacion = int.Parse(dataReader.GetString(1))
            };
            Paciente paciente = new Paciente()
            {
                Identificacion = int.Parse(dataReader.GetString(2)),
            };

            Sesion sesion = new Sesion
            {
                IdSesion = int.Parse(dataReader.GetString(0)),
                Psicologo = psicologo,
                Paciente = paciente,
                Fecha = (dataReader.GetString(3)),
                Hora = dataReader.GetString(4),
                Estado = dataReader.GetString(5)
            };
            return sesion;
        }
    }
}
