﻿using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ProyectoGreenSpace.Classes
{
    internal class Film
    {
        public const int MAX_PREMIERING = 8;
        public const int MAX_NEXT_PREMIERING = 8;

        private int id;
        private string name;
        private string synopsis;
        private Image cover;
        private TimeSpan duration;
        private int minAge;
        private double price;
        private string[] genres;
        private bool premiering;
        private bool nextPremiering;

        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public string Synopsis { get { return synopsis; } }
        public Image Cover { get { return cover; } }
        public TimeSpan Duration { get { return duration; } }
        public int MinAge { get { return minAge; } }
        public double Price { get { return price; } }
        public string[] Genres { get { return genres; } }
        public bool Premiering { get { return premiering; } }
        public bool NextPremiering { get { return nextPremiering; } }

        public Film(string name, string synopsis, Image cover, TimeSpan duration, int minAge, double price, string[] genres, bool premiering, bool nextPremiering)
        {
            this.name = name;
            this.synopsis = synopsis;
            this.cover = cover;
            this.duration = duration;
            this.minAge = minAge;
            this.price = price;
            this.genres = genres;
            this.premiering = premiering;
            this.nextPremiering = nextPremiering;
        }

        public Film(int id, string name, string synopsis, Image cover, TimeSpan duration, int minAge, double price, string[] genres, bool premiering, bool nextPremiering)
        {
            this.id = id;
            this.name = name;
            this.synopsis = synopsis;
            this.cover = cover;
            this.duration = duration;
            this.minAge = minAge;
            this.price = price;
            this.genres = genres;
            this.premiering = premiering;
            this.nextPremiering = nextPremiering;
        }

        #region Metodos de interfaz
        /// <summary>
        /// Gets all the identifying fields (id and name) of the films and return them as a list of tuples that contain the identifying information for each film
        /// </summary>
        /// <returns>List of tuples containing the film id and name</returns>
        public static List<(int id, string name)> GetIdentifyingInfo()
        {
            List<(int id, string name)> list = new List<(int id, string name)>();

            string query = "SELECT id, name FROM films";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    list.Add(
                        (
                            reader.GetInt32(0),
                            reader.GetString(1)
                        )
                    );
                }
            }

            ConnectionBD.CloseConnection();

            return list;
        }

        /// <summary>
        /// Gets all the identifying fields (id and name) of the films that are premiering and return them as a list of tuples that contain the identifying information for each film
        /// </summary>
        /// <returns>List of tuples containing the film id and name</returns>
        public static List<(int id, string name)> GetIdentifyingInfoPremiering()
        {
            List<(int id, string name)> list = new List<(int id, string name)>();

            string query = "SELECT id, name FROM films WHERE premiering = @premiering";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@premiering", true);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    list.Add(
                        (
                            reader.GetInt32(0),
                            reader.GetString(1)
                        )
                    );
                }
            }

            ConnectionBD.CloseConnection();

            return list;
        }

        /// <summary>
        /// Gets all the identifying fields (id and name) of the films that a user can review and return them as a list of tuples that contain the identifying information for each film
        /// </summary>
        /// <param name="userId">The user Id</param>
        /// <returns>List of tuples containing the film id and name</returns>
        public static List<(int id, string name)> GetIdentifyingInfoReview(int userId)
        {
            List<(int id, string name)> list = new List<(int id, string name)>();

            string query = "SELECT id, name FROM films WHERE premiering = @premiering AND id IN (SELECT filmId FROM tickets WHERE dateFilm < @date AND userId = @userId)";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@premiering", true);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@userId", userId);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    list.Add(
                        (
                            reader.GetInt32(0),
                            reader.GetString(1)
                        )
                    );
                }
            }

            ConnectionBD.CloseConnection();

            return list;
        }

        /// <summary>
        /// Inserts the Film into the Database
        /// </summary>
        public void Create()
        {
            string query = "INSERT INTO films (name, synopsis, cover, duration, minAge, price, genres, premiering, next_premiering) VALUES (@name, @synopsis, @cover, @duration, @minAge, @price, @genres, @premiering, @nextPremiering)";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@synopsis", synopsis);
            command.Parameters.AddWithValue("@cover", ImagesDB.ImageToBytes(cover));
            command.Parameters.AddWithValue("@duration", duration);
            command.Parameters.AddWithValue("@minAge", minAge);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@genres", GenresToString());
            command.Parameters.AddWithValue("@premiering", premiering);
            command.Parameters.AddWithValue("@nextPremiering", nextPremiering);

            ConnectionBD.OpenConnection();
            
            command.ExecuteNonQuery();

            ConnectionBD.CloseConnection();
        }

        /// <summary>
        /// Updates the Film with the Id attribute value with the info in its attributes
        /// </summary>
        public void Update()
        {
            string query = "UPDATE films SET name = @name, synopsis = @synopsis, cover = @cover, duration = @duration, minAge = @minAge, price = @price, genres = @genres, premiering = @premiering, next_premiering = @nextPremiering WHERE id = @id";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@synopsis", synopsis);
            command.Parameters.AddWithValue("@cover", ImagesDB.ImageToBytes(cover));
            command.Parameters.AddWithValue("@duration", duration);
            command.Parameters.AddWithValue("@minAge", minAge);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@genres", GenresToString());
            command.Parameters.AddWithValue("@premiering", premiering);
            command.Parameters.AddWithValue("@nextPremiering", nextPremiering);

            ConnectionBD.OpenConnection();

            command.ExecuteNonQuery();

            ConnectionBD.CloseConnection();
        }

        /// <summary>
        /// Deletes a Film from the Database
        /// </summary>
        /// <param name="id">The film Id</param>
        public static void Delete(int id)
        {
            string query = "DELETE FROM films WHERE id = @id";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@id", id);

            ConnectionBD.OpenConnection();

            command.ExecuteNonQuery();

            ConnectionBD.CloseConnection();
        }

        /// <summary>
        /// Comprueba si existe una pelicula con el nombre en la base de datos
        /// </summary>
        /// <param name="name">Nombre de la pelicula</param>
        /// <returns>Un booleano</returns>
        public static bool Exists(string name)
        {
            bool exists;
            
            string query = "SELECT id FROM films WHERE name LIKE @name";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@name", name);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                exists = reader.HasRows;
            }

            ConnectionBD.CloseConnection();

            return exists;
        }

        /// <summary>
        /// Obtiene la puntuacion media de las reseñas de la pelicula
        /// </summary>
        /// <returns>Puntuacion media</returns>
        public double TotalScore()
        {
            string query = "SELECT AVG(score) FROM reviews WHERE fimlId = @film";

            ConnectionBD.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@film", id);
            double score = Convert.ToDouble(command.ExecuteScalar());

            ConnectionBD.CloseConnection();

            return score;
        }

        /// <summary>
        /// Obtiene la pelicula con el id especificado
        /// </summary>
        /// <param name="id">Id de la pelicula</param>
        /// <returns>Un objeto pelicula</returns>
        public static Film InfoFilm(int id)
        {
            string query = "SELECT * FROM films WHERE id = @id";
            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@id", id);

            Film film = null;

            ConnectionBD.OpenConnection();
            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    film = new Film(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        ImagesDB.BytesToImage((byte[])reader.GetValue(3)),
                        reader.GetTimeSpan(4),
                        reader.GetInt32(5),
                        reader.GetDouble(6),
                        GenresStringToArray(reader.GetString(7)),
                        reader.GetBoolean(8),
                        reader.GetBoolean(9)
                    );
                }
            }
            ConnectionBD.CloseConnection();
            return film;
        }

        /// <summary>
        /// Obtiene la pelicula con el nombre especificado
        /// </summary>
        /// <param name="name">Nombre de la pelicula</param>
        /// <returns>Un objeto pelicula</returns>
        public static Film InfoFilm(string name)
        {
            string query = "SELECT * FROM films WHERE name = @name";
            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@name", name);

            Film film = null;

            ConnectionBD.OpenConnection();
            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    film = new Film(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        ImagesDB.BytesToImage((byte[])reader.GetValue(3)),
                        reader.GetTimeSpan(4),
                        reader.GetInt32(5),
                        reader.GetDouble(6),
                        GenresStringToArray(reader.GetString(7)),
                        reader.GetBoolean(8),
                        reader.GetBoolean(9)
                    );
                }
            }
            ConnectionBD.CloseConnection();
            return film;
        }

        /// <summary>
        /// Obtiene todas las peliculas de la base de datos
        /// </summary>
        /// <returns>Lista con todas las peliculas</returns>
        public static List<Film> ObtainAll()
        {
            List<Film> premiering = new List<Film>();

            string query = "SELECT * FROM films";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    premiering.Add(new Film(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        ImagesDB.BytesToImage((byte[])reader.GetValue(3)),
                        reader.GetTimeSpan(4),
                        reader.GetInt32(5),
                        reader.GetDouble(6),
                        GenresStringToArray(reader.GetString(7)),
                        reader.GetBoolean(8),
                        reader.GetBoolean(9)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return premiering;
        }

        /// <summary>
        /// Obtiene la cantidad de peliculas en la base de datos
        /// </summary>
        /// <returns>Cantidad de peliculas</returns>
        public static int Amount()
        {
            string query = "SELECT COUNT(*) FROM films";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);

            ConnectionBD.OpenConnection();

            int amount = Convert.ToInt32(command.ExecuteScalar());

            ConnectionBD.CloseConnection();

            return amount;
        }

        /// <summary>
        /// Obtiene todas las peliculas en estreno
        /// </summary>
        /// <returns>Lista de peliculas</returns>
        public static List<Film> ObtainAllPremiering()
        {
            List<Film> premiering = new List<Film>();

            string query = "SELECT * FROM films WHERE premiering = @premiering LIMIT @max_premiering";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@premiering", true);
            command.Parameters.AddWithValue("@max_premiering", MAX_PREMIERING);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    premiering.Add(new Film(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        ImagesDB.BytesToImage((byte[])reader.GetValue(3)),
                        reader.GetTimeSpan(4),
                        reader.GetInt32(5),
                        reader.GetDouble(6),
                        GenresStringToArray(reader.GetString(7)),
                        reader.GetBoolean(8),
                        reader.GetBoolean(9)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return premiering;
        }

        /// <summary>
        /// Obtiene la cantidad de peliculas en estreno
        /// </summary>
        /// <returns>Cantidad de peliculas</returns>
        public static int AmountPremiering()
        {
            string query = "SELECT COUNT(*) FROM films WHERE premiering = @premiering";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@premiering", true);

            ConnectionBD.OpenConnection();

            int amount = Convert.ToInt32(command.ExecuteScalar());

            ConnectionBD.CloseConnection();

            return amount;
        }

        /// <summary>
        /// Obtiene las peliculas que se van a estrenar
        /// </summary>
        /// <returns>Lista de peliculas</returns>
        public static List<Film> ObtainAllNextPremiering()
        {
            List<Film> premiering = new List<Film>();

            string query = "SELECT * FROM films WHERE next_premiering = @next_premiering LIMIT @max_next_premiering";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@next_premiering", true);
            command.Parameters.AddWithValue("@max_next_premiering", MAX_NEXT_PREMIERING);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    premiering.Add(new Film(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        ImagesDB.BytesToImage((byte[])reader.GetValue(3)),
                        reader.GetTimeSpan(4),
                        reader.GetInt32(5),
                        reader.GetDouble(6),
                        GenresStringToArray(reader.GetString(7)),
                        reader.GetBoolean(8),
                        reader.GetBoolean(9)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return premiering;
        }

        /// <summary>
        /// Obtiene la cantidad de peliculas que se van a estrenar
        /// </summary>
        /// <returns>Cantidad de peliculas</returns>
        public static int AmountNextPremiering()
        {
            string query = "SELECT COUNT(*) FROM films WHERE next_premiering = @next_premiering";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@next_premiering", true);

            ConnectionBD.OpenConnection();

            int amount = Convert.ToInt32(command.ExecuteScalar());

            ConnectionBD.CloseConnection();

            return amount;
        }

        /// <summary>
        /// Obtiene los generos que pueden tener las peliculas
        /// </summary>
        /// <returns>Lista con los generos</returns>
        public static string[] ObtainGenres()
        {
            string query = "SELECT COLUMN_TYPE AS genres FROM information_schema.COLUMNS WHERE TABLE_SCHEMA = 'greenspacefilms' AND TABLE_NAME = 'films' AND COLUMN_NAME = 'genres'";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);

            ConnectionBD.OpenConnection();

            string genres = (string)command.ExecuteScalar();

            ConnectionBD.CloseConnection();

            // Elimina la parte set( de la cadena que duvuelve la consulta, luego elimina el ) final,
            // luego elimina todas las ' y por último crea un array separando el string por las ,
            return genres.Remove(0, 4).Remove(genres.Length - 4 - 1, 1).Replace("'", string.Empty).Split(',');
        }
        #endregion

        #region Metodos de implementacion
        /// <summary>
        /// Transformar el array de generos a un string separados por ,
        /// </summary>
        /// <returns>String con los generos</returns>
        private string GenresToString()
        {
            string genresString = "";
            foreach (string genre in this.genres)
            {
                genresString += $"{genre},";
            }
            genresString = genresString.Remove(genresString.Length - 1, 1);
            return genresString;
        }

        /// <summary>
        /// Transforma el string de generos a un array
        /// </summary>
        /// <param name="genresString">String de los generos separados por ,</param>
        /// <returns>Array de los generos</returns>
        private static string[] GenresStringToArray(string genresString)
        {
            return genresString.Split(',');
        }
        #endregion
    }
}
