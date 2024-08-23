using FelipinPañalera.Data;
using FelipinPañalera.Models;
using FelipinPañalera.Repository.Interfaces;

namespace FelipinPañalera.Repository
{
    public class UsuarioRepository: GenerycRepository<Usuario,ApplicationDbContext>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context) { }
    }
}
