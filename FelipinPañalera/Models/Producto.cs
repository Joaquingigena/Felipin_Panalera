namespace FelipinPañalera.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Img { get; set; } = null!;
        public decimal Precio { get; set; }
        public string Descripcion { get; set; } = null!;
        public int MarcaId { get; set; }
        public Marca Marca { get; set; } = null!;
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; } = null!;
        public bool Estado { get; set; }

        public List<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();
    }
}

