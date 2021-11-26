using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entity;

namespace DAL
{
    public class PacienteRepository
    {
        private readonly MySqlConnection _conexion;
        private readonly List<Paciente> _pacientes = new List<Paciente>();
        public PacienteRepository(ConexionManager conexion)
        {
            _conexion = conexion._conexion;
        }
        public int Guardar(Paciente paciente)
        {
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = @"INSERT INTO Paciente VALUES (@TipoId, @Id, @Nombre, @Apellido, @Direccion, @Telefono, @Email, @FechaNacimiento, @Edad, @Sexo)";
                command.Parameters.Add("TipoId", MySqlDbType.VarChar).Value = paciente.TipoIdentificacion;
                command.Parameters.Add("Id", MySqlDbType.Int64).Value = paciente.Identificacion;
                command.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = paciente.Nombre;
                command.Parameters.Add("Apellido", MySqlDbType.VarChar).Value = paciente.Apellido;
                command.Parameters.Add("Direccion", MySqlDbType.VarChar).Value = paciente.Direccion;
                command.Parameters.Add("Telefono", MySqlDbType.VarChar).Value = paciente.Telefono;
                command.Parameters.Add("Email", MySqlDbType.VarChar).Value = paciente.Email;
                command.Parameters.Add("FechaNacimiento", MySqlDbType.VarChar).Value = paciente.FechaNacimiento;
                command.Parameters.Add("Edad", MySqlDbType.Int32).Value = paciente.Edad;
                command.Parameters.Add("Sexo", MySqlDbType.VarChar).Value = paciente.Sexo;
                var rows = command.ExecuteNonQuery();
                return rows;
            }
        }
        public List<Paciente> Consultar()
        {
            MySqlDataReader dataReader;
            List<Paciente> pacientes = new List<Paciente>();
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Paciente";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Paciente paciente = Mapear(dataReader);
                        pacientes.Add(paciente);
                    }
                }
            }
            return pacientes;
        }
        public List<Paciente> FiltrarPorIdentificacion(string identificacion)
        {
            return (from p in Consultar()
                    where p.Identificacion.ToString().Contains(identificacion)
                    select p).ToList();
        }
        public List<Paciente> FiltrarPorGenero(string genero)
        {
            return (from p in Consultar()
                    where p.Sexo.Equals(genero)
                    select p).ToList();
        }
        public int Modificar(Paciente paciente)
        {
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = @"UPDATE Paciente SET Name = @Name, LastName = @LastName, Address = @Address, Phone = @Phone, Email = @Email, DateBirth = @DateBirth, Age = @Age, Gender = @Gender WHERE Id = @Id";
                command.Parameters.Add("Id", MySqlDbType.Int32).Value = paciente.Identificacion;
                command.Parameters.Add("Name", MySqlDbType.VarChar).Value = paciente.Nombre;
                command.Parameters.Add("LastName", MySqlDbType.VarChar).Value = paciente.Apellido;
                command.Parameters.Add("Address", MySqlDbType.VarChar).Value = paciente.Direccion;
                command.Parameters.Add("Phone", MySqlDbType.VarChar).Value = paciente.Telefono;
                command.Parameters.Add("Email", MySqlDbType.VarChar).Value = paciente.Email;
                command.Parameters.Add("DateBirth", MySqlDbType.VarChar).Value = paciente.FechaNacimiento;
                command.Parameters.Add("Age", MySqlDbType.Int32).Value = paciente.Edad;
                command.Parameters.Add("Gender", MySqlDbType.VarChar).Value = paciente.Sexo;
                var rows = command.ExecuteNonQuery();
                return rows;
            }
        }
        private Paciente Mapear(MySqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Paciente paciente = new Paciente
            {
                TipoIdentificacion = dataReader.GetString(0),
                Identificacion = int.Parse(dataReader.GetString(1)),
                Nombre = dataReader.GetString(2),
                Apellido = dataReader.GetString(3),
                Direccion = dataReader.GetString(4),
                Telefono = dataReader.GetString(5),
                Email = dataReader.GetString(6),
                FechaNacimiento = dataReader.GetString(7),
                Edad = int.Parse(dataReader.GetString(8)),
                Sexo = dataReader.GetString(9)
            };
            return paciente;
        }
    }
}
