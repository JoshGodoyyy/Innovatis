using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace Innovatis.Obra {
    internal class Cadastro {
        private static readonly string path = "Data Source=E:\\ws-vs2022\\Innovatis\\Innovatis\\db\\innovatis.db";
        private static SQLiteConnection connection;
        private static SQLiteCommand command;
        private static SQLiteDataReader reader;

        public static List<Entity.Obra> LoadData() {
            using(connection = new SQLiteConnection(path)) {
                List<Entity.Obra> obras = new List<Entity.Obra>();
                string cmd = "select * from obras";
                command = new SQLiteCommand(cmd, connection);
                connection.Open();
                reader = command.ExecuteReader();
                while(reader.Read()) {
                    Entity.Obra obra = new Entity.Obra() {
                        Id = Convert.ToInt32(reader["id"]),
                        Logradouro = Convert.ToString(reader["logradouro"]),
                        Numero = Convert.ToInt32(reader["numero"]),
                        Bairro = Convert.ToString(reader["bairro"]),
                        Cidade = Convert.ToString(reader["cidade"]),
                        CEP = Convert.ToString(reader["cep"]),
                        IdCliente = Convert.ToInt32(reader["id_cliente"]),
                        ValorContrato = Convert.ToDouble(reader["valorcontrato"]),
                        ValorMaterial = Convert.ToDouble(reader["valormaterial"]),
                        DataInicio = Convert.ToDateTime(reader["datainicio"]),
                        DataFinal = Convert.ToDateTime(reader["datafinal"])
                    };
                    obras.Add(obra);
                }
                return obras;
            }
        }

        public static void InsertData(Entity.Obra obra) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "insert into obras (logradouro, numero, bairro, cidade, cep, id_cliente, valorcontrato, valormaterial, datainicio, datafinal) values (@logradouro, @numero, @bairro, @cidade, @cep, @id_cliente, @valorcontrato, @valormaterial, @datainicio, @datafinal)";
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

                command.ExecuteNonQuery();
            }
        }
    }
}
