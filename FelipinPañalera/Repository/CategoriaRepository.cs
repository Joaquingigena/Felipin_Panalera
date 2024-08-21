using FelipinPañalera.Data;
using FelipinPañalera.Models;
using FelipinPañalera.Repository.Interfaces;

namespace FelipinPañalera.Repository
{
    public class CategoriaRepository : GenerycRepository<Categoria,ApplicationDbContext>,ICategoriaRepository
    {
        public CategoriaRepository(ApplicationDbContext context) : base(context) { }
    }
}
