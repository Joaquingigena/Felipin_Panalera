namespace FelipinPañalera.DTOs
{
    public class UsuarioDTO
    {
        //A modificar
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public int Rol { get; set; }
    }
}
