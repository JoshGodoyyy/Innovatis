using Innovatis.Funcionarios.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Innovatis.Funcionarios {
    public class Banco {
        private static string database = Global.pathDatabase;
        private static SQLiteConnection connection;
        private static SQLiteCommand command;
        private static SQLiteDataReader reader;
        private static SQLiteDataAdapter adapter;

        public static List<Funcionario> Listar() {
            using(connection = new SQLiteConnection("Data Source = " + database)) {
                List<Funcionario> funcionarios = new List<Funcionario>();
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from funcionarios";
                reader = command.ExecuteReader();
                while(reader.Read()) {
                    Funcionario funcionario = new Funcionario() {
                        Id = Convert.ToInt32(reader["id"]),
                        Nome = Convert.ToString(reader["nome"])
                    };
                    funcionarios.Add(funcionario);
                }
                return funcionarios;
            }
        }

        public static List<Funcionario> ListarId(int id) {
            using(connection = new SQLiteConnection("Data Source = " + database)) {
                List<Funcionario> funcionarios = new List<Funcionario>();
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from funcionarios where id = @id";
                command.Parameters.AddWithValue("id", id);
                reader = command.ExecuteReader();
                while(reader.Read()) {
                    Funcionario funcionario = new Funcionario() {
                        Id = Convert.ToInt32(reader["id"]),
                        Nome = Convert.ToString(reader["nome"]),
                        RG = Convert.ToString(reader["rg"]),
                        CPF = Convert.ToString(reader["cpf"]),
                        Empresa = Convert.ToString(reader["empresa"]),
                        Registrado = Convert.ToBoolean(reader["registro"]),
                        Status = Convert.ToBoolean(reader["status"]),
                        Data = Convert.ToDateTime(reader["aso"])
                    };
                    funcionarios.Add(funcionario);
                }
                return funcionarios;
            }
        }

        public static List<Funcionario> FiltrarRegistro(bool value) {
            using(connection = new SQLiteConnection("Data Source = " + database)) {
                List<Funcionario> funcionarios = new List<Funcionario>();
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from funcionarios where registro = @value";
                command.Parameters.AddWithValue("value", value);
                reader = command.ExecuteReader();
                while(reader.Read()) {
                    Funcionario funcionario = new Funcionario() {
                        Id = Convert.ToInt32(reader["id"]),
                        Nome = Convert.ToString(reader["nome"])
                    };
                    funcionarios.Add(funcionario);
                }
                return funcionarios;
            }
        }

        public static List<Funcionario> FiltrarNome(string value) {
            using(connection = new SQLiteConnection("Data Source = " + database)) {
                List<Funcionario> funcionarios = new List<Funcionario>();
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select * from funcionarios where nome like @value";
                command.Parameters.AddWithValue("value", value);
                reader = command.ExecuteReader();
                while(reader.Read()) {
                    Funcionario funcionario = new Funcionario() {
                        Id = Convert.ToInt32(reader["id"]),
                        Nome = Convert.ToString(reader["nome"])
                    };
                    funcionarios.Add(funcionario);
                }
                return funcionarios;
            }
        }

        public static void Inserir(Funcionario funcionario) {
            using(connection = new SQLiteConnection("Data Source = " + database)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "insert into funcionarios (nome, rg, cpf, empresa, registro, status, aso) values (@nome, @rg, @cpf, @empresa, @registro, @status, @aso)";
                command.Parameters.AddWithValue("nome", funcionario.Nome);
                command.Parameters.AddWithValue("rg", funcionario.RG);
                command.Parameters.AddWithValue("cpf", funcionario.CPF);
                command.Parameters.AddWithValue("empresa", funcionario.Empresa);
                command.Parameters.AddWithValue("registro", funcionario.Registrado);
                command.Parameters.AddWithValue("status", funcionario.Status);
                command.Parameters.AddWithValue("aso", funcionario.Data);
                command.ExecuteNonQuery();
            }
        }

        public static void Editar(Funcionario funcionario) {
            using(connection = new SQLiteConnection("Data Source = " + database)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "update funcionarios set nome = @nome, rg = @rg, cpf = @cpf, empresa = @empresa, registro = @registro, status = @status, aso = @aso where id = @id";
                command.Parameters.AddWithValue("nome", funcionario.Nome);
                command.Parameters.AddWithValue("rg", funcionario.RG);
                command.Parameters.AddWithValue("cpf", funcionario.CPF);
                command.Parameters.AddWithValue("empresa", funcionario.Empresa);
                command.Parameters.AddWithValue("registro", funcionario.Registrado);
                command.Parameters.AddWithValue("status", funcionario.Status);
                command.Parameters.AddWithValue("aso", funcionario.Data);
                command.Parameters.AddWithValue("id", funcionario.Id);
                command.ExecuteNonQuery();
            }
        }

        public static void Remover(int id) {
            using(connection = new SQLiteConnection("Data Source = " + database)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "delete from funcionarios where id = @id";
                command.Parameters.AddWithValue("id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
