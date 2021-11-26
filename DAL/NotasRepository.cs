using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DAL
{
    public class NotasRepository
    {
        private readonly MySqlConnection _conexion;
       
        public NotasRepository(ConexionManager conexion)
        {
            _conexion = conexion._conexion;
        }
        public int Guardar(NotasSesion notas)
        {
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = @"INSERT INTO NotaSesion VALUES (@IdNotas, @IdSesionN, @Nota, @Diagnostico)";
                command.Parameters.Add("IdNotas", MySqlDbType.VarChar).Value = notas.IdNotas;
                command.Parameters.Add("IdSesionN", MySqlDbType.Int64).Value = notas.Sesion.IdSesion;
                command.Parameters.Add("Nota", MySqlDbType.VarChar).Value = notas.Nota;
                command.Parameters.Add("Diagnostico", MySqlDbType.VarChar).Value = notas.Diagnostico;
               
                var rows = command.ExecuteNonQuery();
                return rows;
            }
        }
        public List<NotasSesion> Consultar()
        {
            MySqlDataReader dataReader;
            List<NotasSesion> notas = new List<NotasSesion>();
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = "SELECT * FROM NotaSesion";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        NotasSesion nota = Mapear(dataReader);
                        notas.Add(nota);
                    }
                }
            }
            return notas;
        }
        public List<NotasSesion> FiltrarPorIdentificacion(string identificacion)
        {
            return (from p in Consultar()
                    where p.IdNotas.ToString().Contains(identificacion)
                    select p).ToList();
        }
        private NotasSesion Mapear(MySqlDataReader dataReader)
        {
            Sesion sesion = new Sesion
            {
                IdSesion = int.Parse(dataReader.GetString(1))
            };
            if (!dataReader.HasRows) return null;
            NotasSesion notas = new NotasSesion
            {
                IdNotas = int.Parse(dataReader.GetString(0)),
                Sesion = sesion,
                Nota = dataReader.GetString(2),
                Diagnostico = dataReader.GetString(3)
            };
            return notas;
        }
    }
}
