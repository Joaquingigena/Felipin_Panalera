using FelipinPañalera.Data;
using FelipinPañalera.Models;
using FelipinPañalera.Repository.Interfaces;

namespace FelipinPañalera.Repository
{
    public class MarcaRepository : GenerycRepository<Marca,ApplicationDbContext>,IMarcaRepository
    {
        public MarcaRepository(ApplicationDbContext context) : base(context) { }
    }
}
