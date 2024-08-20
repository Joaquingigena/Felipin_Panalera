using FelipinPañalera.Data;
using FelipinPañalera.Models;

namespace FelipinPañalera.Repository
{
    public class UsuarioRepository: GenerycRepository<Usuario,ApplicationDbContext>
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context) { }
    }
}
