using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Innovatis.Funcionarios.Entity;

namespace Innovatis.Funcionarios {
    internal class Banco {
        private static string database = Global.pathDatabase;
        private static SQLiteConnection connection;
        private static SQLiteCommand command;
        private static SQLiteDataReader reader;
        private static SQLiteDataAdapter adapter;

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
    }
}
