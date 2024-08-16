namespace FelipinPañalera.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int NroPedido { get; set; }
        public decimal ImporteTotal { get; set; }
        public DateTime Fecha { get; set; }
        public string? Nombre { get; set; }
        public string? DatosContacto { get; set; }
    }
}
