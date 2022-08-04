namespace Innovatis {
    internal class Global {
        public static string Versao = "3.0";
        public static string path = System.Environment.CurrentDirectory;
        public static string database = "innovatis.db";
        public static string pathDatabase = path + @"\db\" + database;
        public static bool logado = false;
        public static string Acesso = "Desconectado";
    }
}
