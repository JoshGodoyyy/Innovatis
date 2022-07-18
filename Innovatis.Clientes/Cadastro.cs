using Innovatis.Clientes.Entity;
using System;
using System.Data.SQLite;

namespace Innovatis.Clientes {
    internal class Cadastro {
        readonly SQLiteCommand cmd = new SQLiteCommand();
        public string mensagem;
        public Cadastro(Cliente cliente) {
            cmd.CommandText = "insert into clientes (nome, rg, cpf, contato, email, empresa, cnpj, contato_empresa, endereco, numero, bairro, cidade, cep, uf) values (@nome, @rg, @cpf, @contato, @email, @empresa, @cnpj, @contato_empresa, @endereco, @numero, @bairro, @cidade, @cep, @uf)";
            cmd.Parameters.AddWithValue("nome", cliente.Nome);
            cmd.Parameters.AddWithValue("rg", cliente.RG);
            cmd.Parameters.AddWithValue("cpf", cliente.CPF);
            cmd.Parameters.AddWithValue("contato", cliente.Contato);
            cmd.Parameters.AddWithValue("email", cliente.Email);
            cmd.Parameters.AddWithValue("empresa", cliente.Empresa);
            cmd.Parameters.AddWithValue("cnpj", cliente.CNPJ);  
            cmd.Parameters.AddWithValue("contato_empresa", cliente.ContatoEmpresa);
            cmd.Parameters.AddWithValue("endereco", cliente.Endereco);
            cmd.Parameters.AddWithValue("numero", cliente.Numero);
            cmd.Parameters.AddWithValue("bairro", cliente.Bairro);
            cmd.Parameters.AddWithValue("cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("cep", cliente.CEP);
            cmd.Parameters.AddWithValue("uf", cliente.UF);
            try {
                cmd.Connection = Conexao.Conectar();
                cmd.ExecuteNonQuery();
                Conexao.Desconectar();
                mensagem = "Cadastrado com sucesso";
            } catch(Exception ex) {
                mensagem = ex.Message;
            }
        }
    }
}
