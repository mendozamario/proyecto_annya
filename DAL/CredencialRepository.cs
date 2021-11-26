using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class CredencialRepository
    {
        private readonly MySqlConnection _conexion;
        private readonly Credencial credencial = new Credencial();
        public CredencialRepository(ConexionManager conexion)
        {
            _conexion = conexion._conexion;
        }
        public int Guardar(Credencial credencial)
        {
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = @"INSERT INTO Credencial VALUES (@Id, @Password, @Type)";
                command.Parameters.Add("Id", MySqlDbType.Int32).Value = credencial.Id;
                command.Parameters.Add("Password", MySqlDbType.VarChar).Value = credencial.Password;
                command.Parameters.Add("Type", MySqlDbType.VarChar).Value = credencial.Type;
                var rows = command.ExecuteNonQuery();
                return rows;
            }
        }
        public Credencial Consultar(string identificacion)
        {
            MySqlDataReader dataReader;
            Credencial _credencial = new Credencial();
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = "SELECT * FROM credencial WHERE Id = @Id";
                command.Parameters.Add("Id", MySqlDbType.VarChar).Value = identificacion;
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    if (dataReader.Read())
                    {
                        Credencial credencial = Mapear(dataReader);
                        _credencial = credencial;
                    }
                }
            }
            return _credencial;
        }
        private Credencial Mapear(MySqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Credencial credencial = new Credencial
            {
                Id = dataReader.GetString(0),
                Password = dataReader.GetString(1),
                Type = dataReader.GetString(2)
            };
            return credencial;
        }
    }
}
