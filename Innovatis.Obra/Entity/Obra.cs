using System;

namespace Innovatis.Obra.Entity {
    internal class Obra {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public double ValorContrato { get; set; }
        public double ValorMaterial { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public bool Finalizada { get; set; }
        public DateTime DataEntrega { get; set; }
    }
}
