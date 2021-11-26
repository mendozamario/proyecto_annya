using Entity;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DAL
{
    public class PsicologoRepository
    {
        private readonly MySqlConnection _conexion;
        public PsicologoRepository(ConexionManager conexion)
        {
            _conexion = conexion._conexion;
        }
        public int Guardar(Psicologo psicologo)
        {
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = @"INSERT INTO Psicologo VALUES (@TipoId, @Id, @Name, @LastName, @Address, @Phone, @Email, @DateBirth, @Age, @Gender,@Especializacion)";
                command.Parameters.Add("TipoId", MySqlDbType.VarChar).Value = psicologo.TipoIdentificacion; 
                command.Parameters.Add("Id", MySqlDbType.Int64).Value = psicologo.Identificacion;
                command.Parameters.Add("Name", MySqlDbType.VarChar).Value = psicologo.Nombre;
                command.Parameters.Add("LastName", MySqlDbType.VarChar).Value = psicologo.Apellido;
                command.Parameters.Add("Address", MySqlDbType.VarChar).Value = psicologo.Direccion;
                command.Parameters.Add("Phone", MySqlDbType.VarChar).Value = psicologo.Telefono;
                command.Parameters.Add("Email", MySqlDbType.VarChar).Value = psicologo.Email;
                command.Parameters.Add("DateBirth", MySqlDbType.VarChar).Value = psicologo.FechaNacimiento;
                command.Parameters.Add("Age", MySqlDbType.Int32).Value = psicologo.Edad;
                command.Parameters.Add("Gender", MySqlDbType.VarChar).Value = psicologo.Sexo;
                command.Parameters.Add("Especializacion", MySqlDbType.VarChar).Value = psicologo.Especializacion;
                var rows = command.ExecuteNonQuery();
                return rows;
            }
        }
        public List<Psicologo> Consultar()
        {
            MySqlDataReader dataReader;
            List<Psicologo> psicologo = new List<Psicologo>();
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = "SELECT TipoId, Id, Nombre, Apellido, Direccion, Telefono, Email, FechaNacimiento, Edad, Sexo, Especializacion FROM Psicologo";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Psicologo psicologos = Mapear(dataReader);
                        psicologo.Add(psicologos);
                    }
                }
            }
            return psicologo;
        }
        public List<Psicologo> FiltrarPorIdentificacion(string identificacion)
        {
            return (from p in Consultar()
                    where p.Identificacion.ToString().Contains(identificacion)
                    select p).ToList();
        }
        public int Modificar(Psicologo psicologo)
        {
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = @"UPDATE Psicologo SET Name = @Name, LastName = @LastName, Address = @Address, Phone = @Phone, Email = @Email, DateBirth = @DateBirth, Age = @Age, Gender = @Gender WHERE Id = @Id";
                command.Parameters.Add("Id", MySqlDbType.Int32).Value = psicologo.Identificacion;
                command.Parameters.Add("Name", MySqlDbType.VarChar).Value = psicologo.Nombre;
                command.Parameters.Add("LastName", MySqlDbType.VarChar).Value = psicologo.Apellido;
                command.Parameters.Add("Address", MySqlDbType.VarChar).Value = psicologo.Direccion;
                command.Parameters.Add("Phone", MySqlDbType.VarChar).Value = psicologo.Telefono;
                command.Parameters.Add("Email", MySqlDbType.VarChar).Value = psicologo.Email;
                command.Parameters.Add("DateBirth", MySqlDbType.VarChar).Value = psicologo.FechaNacimiento;
                command.Parameters.Add("Age", MySqlDbType.Int32).Value = psicologo.Edad;
                command.Parameters.Add("Gender", MySqlDbType.VarChar).Value = psicologo.Sexo;
                var rows = command.ExecuteNonQuery();
                return rows;
            }
        }
        private Psicologo Mapear(MySqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Psicologo psicologo = new Psicologo
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
                Sexo = dataReader.GetString(9),
                Especializacion = dataReader.GetString(10)
            };
            return psicologo;
        }


    }
}
