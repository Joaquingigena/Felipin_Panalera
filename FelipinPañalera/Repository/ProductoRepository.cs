using FelipinPañalera.Data;
using FelipinPañalera.Models;
using FelipinPañalera.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FelipinPañalera.Repository
{
    public class ProductoRepository: GenerycRepository<Producto,ApplicationDbContext> , IProductoRepository
    {
        private readonly ApplicationDbContext contexto;
        public ProductoRepository(ApplicationDbContext context) : base(context) {
            contexto = context;
        }

        public async Task<List<Producto>> Listar()
        {
            return await contexto.Productos
                .Include(p => p.Marca)
                .Include(p => p.Categoria)
                .ToListAsync();
        }
    }
}
