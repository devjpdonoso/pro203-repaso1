using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;

using PRO203_Unidad_1.Support;

namespace PRO203_Unidad_1.DataAccess
{
    public class VideojuegoDataAccess
    {
        private readonly string _connectionString = "Server=.\\SQL2025DEV;Database=PRO203_Repaso;User Id=sa;Password=Pass.1234;TrustServerCertificate=True;";

        public List<Videojuego> ObtenerTodos()
        {
            List<Videojuego> listaJuegosDB = new List<Videojuego>();
            string query = "SELECT * from Videojuegos";
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                Videojuego juego = new Videojuego();
                juego.Identificador = Convert.ToInt32(reader[0]);
                juego.Nombre = reader[1].ToString();
                juego.Categoria = reader[2].ToString();
                juego.HorasJugadas = Convert.ToInt32(reader[3]);

                listaJuegosDB.Add(juego);   
            }
            connection.Close();
            return listaJuegosDB;
        }

        public int Crear(Videojuego juego) {
            string query = $"INSERT INTO [dbo].[Videojuegos]\r\n           ([Nombre]\r\n           ,[Categoria]\r\n           ,[HorasJugadas]\r\n           ,[FlagBorrado]\r\n           ,[FechaCreacion]\r\n           ,[UsuarioCreacion]\r\n           ,[FechaModificacion]\r\n           ,[UsuarioModificacion])\r\n     VALUES\r\n           (@Nombre,\r\n           @Categoria\r\n           ,@HorasJugadas\r\n           ,0\r\n           ,GETDATE(), \r\n           'SYSTEM', \r\n           GETDATE(),\r\n           'SYSTEM')";

            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Nombre", juego.Nombre);
            command.Parameters.AddWithValue("@Categoria", juego.Categoria);
            command.Parameters.AddWithValue("@HorasJugadas", juego.HorasJugadas);
            connection.Open();
            int value = command.ExecuteNonQuery();
            connection.Close();
            return value;
        }

        public int Modificar(Videojuego juego)
        {
            string query = $"UPDATE [dbo].[Videojuegos]\r\n   SET [Nombre] = @Nombre\r\n      ,[Categoria] = @Categoria\r\n      ,[HorasJugadas] = @HorasJugadas\r\n      ,[FechaModificacion] = GETDATE()\r\n      ,[UsuarioModificacion] = 'SYSTEM'\r\n WHERE Identificador = @Identificador";

            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Identificador", juego.Identificador);
            command.Parameters.AddWithValue("@Nombre", juego.Nombre);
            command.Parameters.AddWithValue("@Categoria", juego.Categoria);
            command.Parameters.AddWithValue("@HorasJugadas", juego.HorasJugadas);
            connection.Open();
            int value = command.ExecuteNonQuery();
            connection.Close();
            return value;
        }

        public Videojuego ObtenerPorId(string id)
        {
            Videojuego juego = new Videojuego();
            string query = "SELECT * from Videojuegos where Identificador = " + id;
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                juego.Identificador = Convert.ToInt32(reader[0]);
                juego.Nombre = reader[1].ToString();
                juego.Categoria = reader[2].ToString();
                juego.HorasJugadas = Convert.ToInt32(reader[3]); 
            }
            connection.Close();
            return juego;
        }


    }
}
