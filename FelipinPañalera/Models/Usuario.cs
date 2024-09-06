namespace FelipinPañalera.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public int Rol { get; set; }
    }

  
}
