using Innovatis.Almoxarifado.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Innovatis.Almoxarifado {
    internal class Banco {
        private static string path = AppDomain.CurrentDomain.BaseDirectory.ToString();
        private static string database = "innovatis.db";
        private static string pathDatabase = path + @"\db\" + database;
        private static string connectionString = "Data source = " + pathDatabase;
        private static SQLiteConnection connection;
        private static SQLiteCommand command;
        private static SQLiteDataReader reader;

        public static List<Estoque> ListarTodosEPIs() {
            using(connection = new SQLiteConnection(connectionString)) {
                List<Estoque> estoque = new List<Estoque>();
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from estoque";
                reader = command.ExecuteReader();

                if(reader.HasRows) {
                    while(reader.Read()) {
                        Estoque item = new Estoque() {
                            Id = Convert.ToInt32(reader["id"]),
                            Descricao = Convert.ToString(reader["descricao"]),
                            Quantidade = Convert.ToInt32(reader["quantidade"]),
                            DataCompra = Convert.ToDateTime(reader["data_compra"])
                        };
                        estoque.Add(item);
                    }
                }
                return estoque;
            }
        }
        
        public static List<Estoque> SelecionarEPI(int id) {
            using(connection = new SQLiteConnection(connectionString)) {
                List<Estoque> estoque = new List<Estoque>();
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from estoque where id = @id";
                command.Parameters.AddWithValue("id", id);
                reader = command.ExecuteReader();

                while(reader.Read()) {
                    Estoque item = new Estoque() {
                        Id = Convert.ToInt32(reader["id"]),
                        Descricao = Convert.ToString(reader["descricao"]),
                        Quantidade = Convert.ToInt32(reader["quantidade"]),
                        DataCompra = Convert.ToDateTime(reader["data_compra"])
                    };
                    estoque.Add(item);
                }
                return estoque;
            }
        }

        public static void InserirEPI(Estoque item) {
            using(connection = new SQLiteConnection(connectionString)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "insert into estoque (descricao, quantidade, data_compra) values (@descricao, @quantidade, @data_compra)";
                command.Parameters.AddWithValue("descricao", item.Descricao);
                command.Parameters.AddWithValue("quantidade", item.Quantidade);
                command.Parameters.AddWithValue("data_compra", item.DataCompra);

                command.ExecuteNonQuery();
            }
        }

        public static void EditarEPI(Estoque item) {
            using(connection = new SQLiteConnection(connectionString)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "update estoque set descricao = @descricao, quantidade = @quantidade, data_compra = @data_compra where id = @id";
                command.Parameters.AddWithValue("descricao", item.Descricao);
                command.Parameters.AddWithValue("quantidade", item.Quantidade);
                command.Parameters.AddWithValue("data_compra", item.DataCompra);
                command.Parameters.AddWithValue("id", item.Id);

                command.ExecuteNonQuery();
            }
        }

        public static void RemoverEPI(int id) {
            using(connection = new SQLiteConnection(connectionString)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "delete from estoque where id = @id";
                command.Parameters.AddWithValue("id", id);

                command.ExecuteNonQuery();
            }
        }
    }
}
