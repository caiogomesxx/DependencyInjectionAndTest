namespace DependencyInjenction.API.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public string Produto { get; set; } = String.Empty;
        public decimal Preco { get; set; }    
        public int IdCliente { get; set; }
        public virtual Cliente? Cliente { get; set; } 
    }
}
