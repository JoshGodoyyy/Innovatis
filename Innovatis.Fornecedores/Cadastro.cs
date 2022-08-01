using Innovatis.Fornecedores.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Innovatis.Fornecedores {
    public class Cadastro {
        private static string path = Globais.pathDatabase;
        private static SQLiteConnection connection;
        private static SQLiteCommand command;
        private static SQLiteDataReader reader;
        private static SQLiteDataAdapter adapter;

        public static List<Fornecedor> Listar() {
            using(connection = new SQLiteConnection("Data Source = " + path)) {
                List<Fornecedor> fornecedores = new List<Fornecedor>();
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from fornecedores";
                reader = command.ExecuteReader();

                while(reader.Read()) {
                    Fornecedor fornecedor = new Fornecedor() {
                        Id = Convert.ToInt32(reader["id"]),
                        Nome = Convert.ToString(reader["empresa"]),
                        Contato = Convert.ToString(reader["contato"]),
                        Email = Convert.ToString(reader["email"]),
                        Responsavel = Convert.ToString(reader["responsavel"])
                    };
                    fornecedores.Add(fornecedor);
                }
                return fornecedores;
            }
        }

        public static DataTable SelecionarFornecedor(int id) {
            using(connection = new SQLiteConnection("Data Source = " + path)) {
                DataTable data = new DataTable();
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from fornecedores where id = @id";
                command.Parameters.AddWithValue("id", id);
                adapter = new SQLiteDataAdapter(command);
                adapter.Fill(data);
                return data;
            }
        }

        public static void Inserir(Fornecedor fornecedor) {
            using(connection = new SQLiteConnection("Data Source = " + path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "insert into fornecedores (empresa, contato, email, responsavel) values (@empresa, @contato, @email, @responsavel)";
                command.Parameters.AddWithValue("empresa", fornecedor.Nome);
                command.Parameters.AddWithValue("contato", fornecedor.Contato);
                command.Parameters.AddWithValue("email", fornecedor.Email);
                command.Parameters.AddWithValue("responsavel", fornecedor.Responsavel);

                command.ExecuteNonQuery();
            }
        }
        public static void Editar(Fornecedor fornecedor) {
            using(connection = new SQLiteConnection("Data Source = " + path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "update fornecedores set empresa = @empresa, contato = @contato, email = @email, responsavel = @responsavel where id = @id";
                command.Parameters.AddWithValue("empresa", fornecedor.Nome);
                command.Parameters.AddWithValue("contato", fornecedor.Contato);
                command.Parameters.AddWithValue("email", fornecedor.Email);
                command.Parameters.AddWithValue("responsavel", fornecedor.Responsavel);
                command.Parameters.AddWithValue("id", fornecedor.Id);

                command.ExecuteNonQuery();
            }
        }
        public static void Remover(int id) {
            using(connection = new SQLiteConnection("Data Source = " + path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "delete from fornecedores where id = @id";
                command.Parameters.AddWithValue("id", id);

                command.ExecuteNonQuery();
            }
        }
    }
}
