namespace Innovatis.Obra.Entity {
    internal class Material {
        public int Id { get; set; }
        public int IdObra { get; set; }
        public string Descricao { get; set; }
        public System.DateTime Data { get; set; }
        public double Valor { get; set; }
        public string Nota { get; set; }
        public string LocalEntrega { get; set; }
    }
}
