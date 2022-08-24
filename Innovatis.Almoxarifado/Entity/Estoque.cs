using System;

namespace Innovatis.Almoxarifado.Entity {
    internal class Estoque {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCompra { get; set; }
    }
}
