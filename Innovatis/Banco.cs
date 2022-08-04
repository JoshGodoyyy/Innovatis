using Innovatis.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Innovatis {
    internal class Banco {
        private static string path = "Data Source = " + Global.pathDatabase;
        private static SQLiteConnection connection;
        private static SQLiteCommand command;
        private static SQLiteDataReader reader;

        public static List<Usuario> Login(Usuario usuario) {
            using(connection = new SQLiteConnection(path)) {
                List<Usuario> usuarios = new List<Usuario>();
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from usuarios where usuario = @usuario and senha = @senha";
                command.Parameters.AddWithValue("usuario", usuario.Nome);
                command.Parameters.AddWithValue("senha", usuario.Senha);
                reader = command.ExecuteReader();

                if(reader.HasRows) {
                    while(reader.Read()) {
                        Usuario login = new Usuario() {
                            Id = Convert.ToInt32(reader["id"]),
                            Nome = Convert.ToString(reader["usuario"]),
                            Senha = Convert.ToString(reader["senha"]),
                            Funcao = Convert.ToString(reader["funcao"])
                        };
                        usuarios.Add(login);
                    }
                }
                return usuarios;
            }
        }

        public static List<Usuario> Usuarios() {
            using(connection = new SQLiteConnection(path)) {
                List<Usuario> usuarios = new List<Usuario>();
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from usuarios";
                reader = command.ExecuteReader();

                if(reader.HasRows) {
                    while(reader.Read()) {
                        Usuario usuario = new Usuario() {
                            Id = Convert.ToInt32(reader["id"]),
                            Nome = Convert.ToString(reader["usuario"]),
                            Senha = Convert.ToString(reader["senha"]),
                            Funcao = Convert.ToString(reader["funcao"])
                        };
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
            }
        }

        public static List<Usuario> SelecionarUsuario(int id) {
            using(connection = new SQLiteConnection(path)) {
                List<Usuario> usuarios = new List<Usuario>();
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from usuarios where id = @id";
                command.Parameters.AddWithValue("id", id);
                reader = command.ExecuteReader();

                if(reader.HasRows) {
                    while(reader.Read()) {
                        Usuario usuario = new Usuario() {
                            Id = Convert.ToInt32(reader["id"]),
                            Nome = Convert.ToString(reader["usuario"]),
                            Senha = Convert.ToString(reader["senha"]),
                            Funcao = Convert.ToString(reader["funcao"])
                        };
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
            }
        }

        public static void NovoUsuario(Usuario usuario) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "insert into usuarios (usuario, senha, funcao) values (@usuario, @senha, @funcao)";
                command.Parameters.AddWithValue("usuario", usuario.Nome);
                command.Parameters.AddWithValue("senha", usuario.Senha);
                command.Parameters.AddWithValue("funcao", usuario.Funcao);

                command.ExecuteNonQuery();
            }
        }

        public static void EditarUsuario(Usuario usuario) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "update usuarios set usuario = @usuario, senha = @senha, funcao = @funcao where id = @id";
                command.Parameters.AddWithValue("usuario", usuario.Nome);
                command.Parameters.AddWithValue("senha", usuario.Senha);
                command.Parameters.AddWithValue("funcao", usuario.Funcao);
                command.Parameters.AddWithValue("id", usuario.Id);

                command.ExecuteNonQuery();
            }
        }

        public static void RemoverUsuario(int id) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "delete from usuarios where id = @id";
                command.Parameters.AddWithValue("id", id);

                command.ExecuteNonQuery();
            }
        }
    }
}
