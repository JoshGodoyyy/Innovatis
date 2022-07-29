namespace Innovatis.Clientes {
    internal class Global {
        public static string Versao = "1.1";
        public static string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string database = "innovatis.db";
        public static string pathDatabase = path + @"\db\" + database;
    }
}
