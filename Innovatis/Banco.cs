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
                            Nivel = Convert.ToInt32(reader["nivel"])
                        };
                        usuarios.Add(login);
                    }
                }
                return usuarios;
            }
        }
    }
}
