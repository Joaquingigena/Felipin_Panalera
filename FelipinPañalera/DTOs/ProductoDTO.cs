using FelipinPañalera.Models;

namespace FelipinPañalera.DTOs
{
    public class ProductoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Img { get; set; } = null!;
        public decimal Precio { get; set; }
        public string Descripcion { get; set; } = null!;
        public int MarcaId { get; set; }
        public string NombreMarca { get; set; } = null!;
        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; } = null!;
        public bool Estado { get; set; }
    }

    public class ProductoCreacionDTO
    {
        public string Nombre { get; set; } = null!;
        public string? Img { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; } = null!;
        public int MarcaId { get; set; }
        public int CategoriaId { get; set; }
        public bool Estado { get; set; }

    }
}
