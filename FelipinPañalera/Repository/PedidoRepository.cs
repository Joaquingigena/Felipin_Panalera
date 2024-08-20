using FelipinPañalera.Data;
using FelipinPañalera.Models;

namespace FelipinPañalera.Repository
{
    public class PedidoRepository : GenerycRepository<Pedido,ApplicationDbContext>
    {
        public PedidoRepository(ApplicationDbContext context) : base(context) { }
    }
}
