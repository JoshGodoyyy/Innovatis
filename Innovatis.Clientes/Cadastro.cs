using Innovatis.Clientes.Entity;
using System.Collections.Generic;
using System.Data.SQLite;
using System;

namespace Innovatis.Clientes {
    public class Cadastro {
        private static readonly string path = "Data Source=" + Global.pathDatabase;
        private static SQLiteConnection connection;
        private static SQLiteCommand command;
        private static SQLiteDataReader reader;

        public static List<Cliente> LoadData() {
            using(connection = new SQLiteConnection(path)) {
                List<Cliente> clientes = new List<Cliente>();
                string cmd = "select * from clientes";
                command = new SQLiteCommand(cmd, connection);
                connection.Open();
                reader = command.ExecuteReader();
                while(reader.Read()) {
                    Cliente cliente = new Cliente() {
                        Id = Convert.ToInt32(reader["id"]),
                        Nome = Convert.ToString(reader["nome"]),
                        RG = Convert.ToString(reader["rg"]),
                        CPF = Convert.ToString(reader["cpf"]),
                        Contato = Convert.ToString(reader["contato"]),
                        Email = Convert.ToString(reader["email"]),
                        Empresa = Convert.ToString(reader["empresa"]),
                        CNPJ = Convert.ToString(reader["cnpj"]),
                        ContatoEmpresa = Convert.ToString(reader["contato_empresa"]),
                        Endereco = Convert.ToString(reader["endereco"]),
                        Numero = Convert.ToInt32(reader["numero"]),
                        Bairro = Convert.ToString(reader["bairro"]),
                        Cidade = Convert.ToString(reader["cidade"]),
                        CEP = Convert.ToString(reader["cep"]),
                        UF = Convert.ToString(reader["uf"])
                    };
                    clientes.Add(cliente);
                }

                return clientes;
            }
        }

        public static void InsertData(Cliente cliente) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "insert into clientes (nome, rg, cpf, contato, email, empresa, cnpj, contato_empresa, endereco, numero, bairro, cidade, cep, uf) values (@nome, @rg, @cpf, @contato, @email, @empresa, @cnpj, @contato_empresa, @endereco, @numero, @bairro, @cidade, @cep, @uf)";
                command.Parameters.AddWithValue("nome", cliente.Nome);
                command.Parameters.AddWithValue("rg", cliente.RG);
                command.Parameters.AddWithValue("cpf", cliente.CPF);
                command.Parameters.AddWithValue("contato", cliente.Contato);
                command.Parameters.AddWithValue("email", cliente.Email);
                command.Parameters.AddWithValue("empresa", cliente.Empresa);
                command.Parameters.AddWithValue("cnpj", cliente.CNPJ);
                command.Parameters.AddWithValue("contato_empresa", cliente.ContatoEmpresa);
                command.Parameters.AddWithValue("endereco", cliente.Endereco);
                command.Parameters.AddWithValue("numero", cliente.Numero);
                command.Parameters.AddWithValue("bairro", cliente.Bairro);
                command.Parameters.AddWithValue("cidade", cliente.Cidade);
                command.Parameters.AddWithValue("cep", cliente.CEP);
                command.Parameters.AddWithValue("uf", cliente.UF);
                command.ExecuteNonQuery();
            }
        }

        public static void EditItem(Cliente cliente) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "update clientes set nome = @nome, rg = @rg, cpf = @cpf, contato = @contato, email = @email, empresa = @empresa, cnpj = @cnpj, contato_empresa = @contato_empresa, endereco = @endereco, numero = @numero, bairro = @bairro, cidade = @cidade, cep = @cep, uf = @uf where id = @id";
                command.Parameters.AddWithValue("id", cliente.Id);
                command.Parameters.AddWithValue("nome", cliente.Nome);
                command.Parameters.AddWithValue("rg", cliente.RG);
                command.Parameters.AddWithValue("cpf", cliente.CPF);
                command.Parameters.AddWithValue("contato", cliente.Contato);
                command.Parameters.AddWithValue("email", cliente.Email);
                command.Parameters.AddWithValue("empresa", cliente.Empresa);
                command.Parameters.AddWithValue("cnpj", cliente.CNPJ);
                command.Parameters.AddWithValue("contato_empresa", cliente.ContatoEmpresa);
                command.Parameters.AddWithValue("endereco", cliente.Endereco);
                command.Parameters.AddWithValue("numero", cliente.Numero);
                command.Parameters.AddWithValue("bairro", cliente.Bairro);
                command.Parameters.AddWithValue("cidade", cliente.Cidade);
                command.Parameters.AddWithValue("cep", cliente.CEP);
                command.Parameters.AddWithValue("uf", cliente.UF);
                command.ExecuteNonQuery();
            }
        }

        public static void RemoveData(int id) {
            using(connection = new SQLiteConnection(path)) {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "delete from clientes where id = @id";
                command.Parameters.AddWithValue("id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
