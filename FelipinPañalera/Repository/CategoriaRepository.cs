using FelipinPañalera.Data;
using FelipinPañalera.Models;

namespace FelipinPañalera.Repository
{
    public class CategoriaRepository : GenerycRepository<Categoria,ApplicationDbContext>
    {
        public CategoriaRepository(ApplicationDbContext context) : base(context) { }
    }
}
