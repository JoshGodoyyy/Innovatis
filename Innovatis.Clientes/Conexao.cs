using System.Data.SQLite;

namespace Innovatis.Clientes {
    internal class Conexao {
        private static SQLiteConnection connection = new SQLiteConnection();
        static Conexao() {
            connection.ConnectionString = "Data Source=E:\\ws-vs2022\\Innovatis\\Innovatis\\db\\innovatis.db";
        }
        public static SQLiteConnection Conectar() {
            if(connection.State == System.Data.ConnectionState.Closed) {
                connection.Open();
            }
            return connection;
        }
        public static void Desconectar() {
            if(connection.State == System.Data.ConnectionState.Open) connection.Close();
        }
    }
}
