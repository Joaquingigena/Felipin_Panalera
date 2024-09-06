namespace FelipinPañalera.DTOs
{
    public class CategoriaDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
    }

    public class CategoriaCreacionDTO
    {
        public string Nombre { get; set; }
    }
}
