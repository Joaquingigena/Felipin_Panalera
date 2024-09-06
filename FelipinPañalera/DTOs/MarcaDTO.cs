namespace FelipinPañalera.DTOs
{
    public class MarcaDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
    }

    public class MarcaCreacionDTO
    {
        public string Nombre { get; set; }
    }
}
