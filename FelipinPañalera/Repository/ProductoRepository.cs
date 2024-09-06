using FelipinPañalera.Data;
using FelipinPañalera.Models;
using FelipinPañalera.Repository.Interfaces;

namespace FelipinPañalera.Repository
{
    public class ProductoRepository: GenerycRepository<Producto,ApplicationDbContext> , IProductoRepository
    {
        public ProductoRepository(ApplicationDbContext context) : base(context) { }
    }
}
