using System;

namespace Innovatis.Funcionarios {
    internal class Global {
        public static string path = AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string database = "innovatis.db";
        public static string pathDatabase = path + @"\db\" + database;
    }
}
