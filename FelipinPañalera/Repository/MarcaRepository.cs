using FelipinPañalera.Data;
using FelipinPañalera.Models;

namespace FelipinPañalera.Repository
{
    public class MarcaRepository : GenerycRepository<Marca,ApplicationDbContext>
    {
        public MarcaRepository(ApplicationDbContext context) : base(context) { }
    }
}
