using Innovatis.Obra.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Innovatis.Obra {
    internal class Historicos {
        private static readonly string path = "Data Source=" + Global.pathDatabase;
        private static SQLiteConnection connection;
        private static SQLiteCommand command;
        private static SQLiteDataReader reader;

        public static List<Material> ListarMateriais(int id) {
            using(connection = new SQLiteConnection(path)) {
                List<Material> materiais = new List<Material>();
                string cmd = "select * from historicos where id_obra = @id";
                command = new SQLiteCommand(cmd, connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                reader = command.ExecuteReader();
                while(reader.Read()) {
                    Material material = new Material() {
                        Id = Convert.ToInt32(reader["id"]),
                        IdObra = Convert.ToInt32(reader["id_obra"]),
                        Descricao = Convert.ToString(reader["descricao"]),
                        Data = Convert.ToDateTime(reader["data"]),
                        Valor = Convert.ToDouble(reader["valor"]),
                        Nota = Convert.ToString(reader["nota"]),
                        LocalEntrega = Convert.ToString(reader["local_entrega"]),
                        Fornecedor = Convert.ToString(reader["fornecedor"])
                    };
                    materiais.Add(material);
                }
                return materiais;
            }
        }

        public static void InserirMaterial(Material material) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "insert into historicos (id_obra, descricao, data, valor, nota, local_entrega, fornecedor) values (@id_obra, @descricao, @data, @valor, @nota, @local_entrega, @fornecedor)";
                command.Parameters.AddWithValue("id_obra", material.IdObra);
                command.Parameters.AddWithValue("descricao", material.Descricao);
                command.Parameters.AddWithValue("data", material.Data);
                command.Parameters.AddWithValue("valor", material.Valor);
                command.Parameters.AddWithValue("nota", material.Nota);
                command.Parameters.AddWithValue("local_entrega", material.LocalEntrega);
                command.Parameters.AddWithValue("fornecedor", material.Fornecedor);

                command.ExecuteNonQuery();
            }
        }

        public static DataTable SelecionarMaterial(int id) {
            using(connection = new SQLiteConnection(path)) {
                DataTable material = new DataTable();
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from historicos where id = @id";
                command.Parameters.AddWithValue("id", id);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                adapter.Fill(material);
                return material;
            }
        }



        public static void EditarPedido(Material material) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "update historicos set descricao = @descricao, data = @data, valor = @valor, nota = @nota, local_entrega = @local_entrega, fornecedor = @fornecedor where id = @id";
                command.Parameters.AddWithValue("descricao", material.Descricao);
                command.Parameters.AddWithValue("data", material.Data);
                command.Parameters.AddWithValue("valor", material.Valor);
                command.Parameters.AddWithValue("nota", material.Nota);
                command.Parameters.AddWithValue("local_entrega", material.LocalEntrega);
                command.Parameters.AddWithValue("fornecedor", material.Fornecedor);
                command.Parameters.AddWithValue("id", material.Id);

                command.ExecuteNonQuery();
            }
        }

        public static void RemoverPedido(int id) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "delete from historicos where id = @id";
                command.Parameters.AddWithValue("id", id);

                command.ExecuteNonQuery();
            }
        }
    }
}
