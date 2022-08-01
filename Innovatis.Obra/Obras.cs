using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Innovatis.Obra {
    internal class Obras {
        private static readonly string path = "Data Source=" + Global.pathDatabase;
        private static SQLiteConnection connection;
        private static SQLiteCommand command;
        private static SQLiteDataReader reader;

        public static List<Entity.Obra> ListarObras(int num) {
            using(connection = new SQLiteConnection(path)) {
                List<Entity.Obra> obras = new List<Entity.Obra>();
                string cmd = "select * from obras where finalizada = @finalizada";
                command = new SQLiteCommand(cmd, connection);
                command.Parameters.AddWithValue("finalizada", num);
                connection.Open();
                reader = command.ExecuteReader();
                while(reader.Read()) {
                    Entity.Obra obra = new Entity.Obra() {
                        Id = Convert.ToInt32(reader["id"]),
                        Logradouro = Convert.ToString(reader["logradouro"]),
                    };
                    obras.Add(obra);
                }
                return obras;
            }
        }

        public static List<Entity.Obra> ListarObrasById(int id) {
            using(connection = new SQLiteConnection(path)) {
                List<Entity.Obra> obras = new List<Entity.Obra>();
                string cmd = "select * from obras where id = @id";
                command = new SQLiteCommand(cmd, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                reader = command.ExecuteReader();
                while(reader.Read()) {
                    Entity.Obra obra = new Entity.Obra() {
                        Logradouro = Convert.ToString(reader["logradouro"]),
                        ValorContrato = Convert.ToDouble(reader["valorcontrato"]),
                        ValorMaterial = Convert.ToDouble(reader["valormaterial"]),
                        DataFinal = Convert.ToDateTime(reader["datafinal"])
                    };
                    obras.Add(obra);
                }
                return obras;
            }
        }

        public static DataTable SelecionarObra(int id) {
            using(connection = new SQLiteConnection(path)) {
                DataTable data = new DataTable();
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from obras where id = @id";
                command.Parameters.AddWithValue("id", id);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(data);
                return data;
            }
        }

        public static void NovaObra(Entity.Obra obra) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "insert into obras (logradouro, numero, bairro, cidade, cep, id_cliente, valorcontrato, valormaterial, datainicio, datafinal, finalizada) values (@logradouro, @numero, @bairro, @cidade, @cep, @id_cliente, @valorcontrato, @valormaterial, @datainicio, @datafinal, @finalizada)";
                command.Parameters.AddWithValue("logradouro", obra.Logradouro);
                command.Parameters.AddWithValue("numero", obra.Numero);
                command.Parameters.AddWithValue("bairro", obra.Bairro);
                command.Parameters.AddWithValue("cidade", obra.Cidade);
                command.Parameters.AddWithValue("cep", obra.CEP);
                command.Parameters.AddWithValue("id_cliente", obra.IdCliente);
                command.Parameters.AddWithValue("valorcontrato", obra.ValorContrato);
                command.Parameters.AddWithValue("valormaterial", obra.ValorMaterial);
                command.Parameters.AddWithValue("datainicio", obra.DataInicio);
                command.Parameters.AddWithValue("datafinal", obra.DataFinal);
                command.Parameters.AddWithValue("finalizada", obra.Finalizada);

                command.ExecuteNonQuery();
            }
        }

        public static void EditarObra(Entity.Obra obra) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "update obras set logradouro = @logradouro, numero = @numero, bairro = @bairro, cidade = @cidade, cep = @cep, id_cliente = @id_cliente, valorcontrato = @valorcontrato, valormaterial = @valormaterial, datainicio = @datainicio, datafinal = @datafinal where id = @id";
                command.Parameters.AddWithValue("logradouro", obra.Logradouro);
                command.Parameters.AddWithValue("numero", obra.Numero);
                command.Parameters.AddWithValue("bairro", obra.Bairro);
                command.Parameters.AddWithValue("cidade", obra.Cidade);
                command.Parameters.AddWithValue("cep", obra.CEP);
                command.Parameters.AddWithValue("id_cliente", obra.IdCliente);
                command.Parameters.AddWithValue("valorcontrato", obra.ValorContrato);
                command.Parameters.AddWithValue("valormaterial", obra.ValorMaterial);
                command.Parameters.AddWithValue("datainicio", obra.DataInicio);
                command.Parameters.AddWithValue("datafinal", obra.DataFinal);
                command.Parameters.AddWithValue("id", obra.Id);

                command.ExecuteNonQuery();

            }
        }

        public static void FinalizarObra(int id, DateTime date) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "update obras set finalizada = 1, dataentrega = @date where id = @id";
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("date", date);

                command.ExecuteNonQuery();
            }
        }

        public static List<Entity.Obra> Relatorio(int id) {
            using(connection = new SQLiteConnection(path)) {
                List<Entity.Obra> obras = new List<Entity.Obra>();
                string cmd = "select * from obras inner join clientes where obras.id = @id";
                command = new SQLiteCommand(cmd, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                reader = command.ExecuteReader();
                while(reader.Read()) {
                    Entity.Obra obra = new Entity.Obra() {
                        NomeCliente = Convert.ToString(reader["nome"]),
                        Logradouro = Convert.ToString(reader["logradouro"]),
                        Numero = Convert.ToInt32(reader["numero"]),
                        Bairro = Convert.ToString(reader["bairro"]),
                        Cidade = Convert.ToString(reader["cidade"]),
                        ValorContrato = Convert.ToDouble(reader["valorcontrato"]),
                        ValorMaterial = Convert.ToDouble(reader["valormaterial"]),
                        DataInicio = Convert.ToDateTime(reader["datainicio"]),
                        DataFinal = Convert.ToDateTime(reader["datafinal"]),
                        DataEntrega = Convert.ToDateTime(reader["dataentrega"])
                    };
                    obras.Add(obra);
                }
                return obras;
            }
        }
    }
}
