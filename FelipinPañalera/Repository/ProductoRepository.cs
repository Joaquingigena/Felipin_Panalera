using FelipinPañalera.Data;
using FelipinPañalera.Models;

namespace FelipinPañalera.Repository
{
    public class ProductoRepository: GenerycRepository<Producto,ApplicationDbContext>
    {
        public ProductoRepository(ApplicationDbContext context) : base(context) { }
    }
}
