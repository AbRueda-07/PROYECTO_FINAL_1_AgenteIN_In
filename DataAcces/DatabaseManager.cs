using InvestigadorAI_Final.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace InvestigadorAI_Final.DataAccess
{
    public class DatabaseManager
    {
        private readonly string _connectionString;

        public DatabaseManager()
        {
            // Configura tu cadena de conexión con tu servidor y base de datos
            _connectionString = "Server=DESKTOP-T3ECS92\\SQLEXPRESS;Database=InvestigacionesDB;Integrated Security=True;TrustServerCertificate=True;";
        }

        /// Devuelve una conexión ya abierta (ideal para operaciones simples)
        public SqlConnection GetConnection()
        {
            var conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn;
        }

        /// Devuelve una nueva conexión sin abrir (ideal para usar en bloques using)
        public SqlConnection GetNewConnection()
        {
            return new SqlConnection(_connectionString);
        }

        /// Guarda un resultado en la base de datos
        public void GuardarResultado(string prompt, string resultado)
        {
            using var conn = GetNewConnection();
            conn.Open();

            var cmd = new SqlCommand("INSERT INTO Resultados (Prompt, Resultado) VALUES (@prompt, @resultado)", conn);
            cmd.Parameters.AddWithValue("@prompt", prompt);
            cmd.Parameters.AddWithValue("@resultado", resultado);
            cmd.ExecuteNonQuery();
        }

        public List<Investigacion> ObtenerTodosLosResultados()
        {
            var resultados = new List<Investigacion>();

            using var conn = GetNewConnection();
            conn.Open();

            var cmd = new SqlCommand("SELECT Id, Prompt, Resultado, Fecha FROM Resultados", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                resultados.Add(new Investigacion
                {
                    Id = reader.GetInt32(0),
                    Prompt = reader.GetString(1),
                    Resultado = reader.GetString(2),
                    Fecha = reader.GetDateTime(3)
                });
            }

            return resultados;
        }

        public void EliminarResultadoPorId(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM Resultados WHERE Id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }


    }
}