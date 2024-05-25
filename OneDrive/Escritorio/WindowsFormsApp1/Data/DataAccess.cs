using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
namespace WindowsFormsApp1.Data
{

    internal class DataAccess
    {
        readonly string connectionString = "server=localhost;database=dblaboratorio;user=root;password=DMBDAD";
        readonly MySqlConnection connection;
        public DataAccess()
        {
            connection = new MySqlConnection(connectionString);
        }
        public void Insertar(Model modelo)
        {
            try
            {
                string query = "INSERT INTO catalogo_consolas (nombre_consola, compania, anio_lanzamiento, generacion) " +
                    "VALUES (@nombre_consola, @compania, @anio_lanzamiento, @generacion)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombre_consola", modelo.Nombre_consola);
                cmd.Parameters.AddWithValue("@compania", modelo.Compania);
                cmd.Parameters.AddWithValue("@anio_lanzamiento", modelo.Anio_lanzamiento);
                cmd.Parameters.AddWithValue("@generacion", modelo.Generacion);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            }
            public void Actualizar(Model modelo)
            {
                try
                {
                    string query = "UPDATE catalogo_consolas SET nombre_consola= @nombre_consola, " +
                        "compania= @compania, anio_lanzamiento= @anio_lanzamiento, " +
                        "generacion = @generacion WHERE ID = @ID";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id_consola", modelo.Id_consola);
                    cmd.Parameters.AddWithValue("@nombre_consola", modelo.Nombre_consola);
                    cmd.Parameters.AddWithValue("@compania", modelo.Compania);
                    cmd.Parameters.AddWithValue("@anio_lanzamiento", modelo.Anio_lanzamiento);
                    cmd.Parameters.AddWithValue("@generacion", modelo.Generacion);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

        }
        public List<Model> ObtenerTodosLosUsuarios()
        {
            List<Model> juegos= new List<Model>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM catalogo_consolas";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string gen = reader.GetString("generacion");
                        Model juego= new Model
                        (
                            id: reader.GetInt32("id_consola"),
                            name: reader.GetString("nombre_consola"),
                            compania: reader.GetString("compania"),
                            date: reader.GetDateTime("anio_lanzamiento"),
                            gen: reader.GetInt32("gen")
                            );

                        juegos.Add(juego);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return juegos;
        }
        public DataTable LeerTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM catalogo_consolas";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                connection.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los registros: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}
