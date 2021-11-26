using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class AgendaRepository
    {
        private readonly MySqlConnection _conexion;
        public AgendaRepository(ConexionManager conexion)
        {
            _conexion = conexion._conexion;
        }

        public DataTable ListadoPsicologos()
        {
            using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter("ListarAgenda;", _conexion))
            {
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }

        }

        public int Guardar(Agenda agenda)
        {
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = @"INSERT INTO Agenda VALUES (@Id, @IdPsicologo, @IdSesion)";
                command.Parameters.Add("Id", MySqlDbType.Int64).Value = agenda.IdAgenda;
                command.Parameters.Add("IdPsicologo", MySqlDbType.VarChar).Value = agenda.Psicologo.Identificacion;
                command.Parameters.Add("IdSesion", MySqlDbType.VarChar).Value = agenda.Sesion.IdSesion;
                var rows = command.ExecuteNonQuery();
                return rows;
            }
        }
        public List<Agenda> Consultar()
        {
            MySqlDataReader dataReader;
            List<Agenda> agendas = new List<Agenda>();
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = "Select IdPsicologo, ApellidoPsicologo, IdPaciente, ApellidoPaciente, Fecha,Hora,Estado From Sesion Join Paciente s Join Psicologo p ON Sesion.IdPsicologoS = p.IdPsicologo;";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Agenda agenda = Mapear(dataReader);
                        agendas.Add(agenda);
                    }
                }
            }
            return agendas;
        }
        public List<Agenda> FiltrarPorIdentificacion(string identificacion)
        {
            return (from p in Consultar()
                    where p.Psicologo.Identificacion.ToString().Contains(identificacion)
                    select p).ToList();
        }
        private Agenda Mapear(MySqlDataReader dataReader)
        {
            Psicologo psicologo = new Psicologo
            {
                Identificacion = int.Parse(dataReader.GetString(0)),
                Apellido = dataReader.GetString(1)
            };
            Paciente paciente = new Paciente
            {
                Identificacion = int.Parse(dataReader.GetString(2)),
                Apellido = dataReader.GetString(3)
            };
            Sesion sesion = new Sesion
            {
                Paciente = paciente,
                Fecha = dataReader.GetString(4),
                Hora = dataReader.GetString(5),
                Estado = dataReader.GetString(6)
            };
            if (!dataReader.HasRows) return null;
            Agenda agenda = new Agenda
            {

                Psicologo = psicologo,
                Sesion = sesion
                
            };
            return agenda;
        }
    }
}
