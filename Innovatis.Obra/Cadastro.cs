﻿using System;
using System.Data.SQLite;
using System.Collections.Generic;
using Innovatis.Obra.Entity;
using System.Data;

namespace Innovatis.Obra {
    internal class Cadastro {
        private static readonly string path = "Data Source=E:\\ws-vs2022\\Innovatis\\Innovatis\\db\\innovatis.db";
        private static SQLiteConnection connection;
        private static SQLiteCommand command;
        private static SQLiteDataReader reader;

        #region Cadastro de Obras
        public static void InsertData(Entity.Obra obra) {
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
        #endregion

        #region Históricos
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
                        IdObra = Convert.ToInt32(reader["id_obra"]),
                        Descricao = Convert.ToString(reader["descricao"]),
                        Data = Convert.ToDateTime(reader["data"]),
                        Valor = Convert.ToDouble(reader["valor"]),
                        Nota = Convert.ToString(reader["nota"]),
                        LocalEntrega = Convert.ToString(reader["local_entrega"])
                    };
                    materiais.Add(material);
                }
                return materiais;
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

        public static void InserirMaterial(Material material) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "insert into historicos (id_obra, descricao, data, valor, nota, local_entrega) values (@id_obra, @descricao, @data, @valor, @nota, @local_entrega)";
                command.Parameters.AddWithValue("id_obra", material.IdObra);
                command.Parameters.AddWithValue("descricao", material.Descricao);
                command.Parameters.AddWithValue("data", material.Data);
                command.Parameters.AddWithValue("valor", material.Valor);
                command.Parameters.AddWithValue("nota", material.Nota);
                command.Parameters.AddWithValue("local_entrega", material.LocalEntrega);

                command.ExecuteNonQuery();
            }
        }

        public static void EditarPedido(Material material) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "update historicos set descricao = @descricao, data = @data, valor = @valor, nota = @nota, local_entrega = @local_entrega where id = @id";
                command.Parameters.AddWithValue("descricao", material.Descricao);
                command.Parameters.AddWithValue("data", material.Data);
                command.Parameters.AddWithValue("valor", material.Valor);
                command.Parameters.AddWithValue("nota", material.Nota);
                command.Parameters.AddWithValue("local_entrega", material.LocalEntrega);
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
        #endregion
    }
}
