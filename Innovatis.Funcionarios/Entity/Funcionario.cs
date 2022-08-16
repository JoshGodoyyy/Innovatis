namespace Innovatis.Funcionarios.Entity {
    internal class Funcionario {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Empresa { get; set; }
        public bool Registrado { get; set; }
        public bool Status { get; set; }
        public System.DateTime Data { get; set; }
    }
}
