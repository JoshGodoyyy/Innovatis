using System;

namespace Innovatis.Almoxarifado.Entity {
    internal class Relatorio {
        public int Id { get; set; }
        public string Funcionario { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public DateTime DataEntrega { get; set; }
    }
}
