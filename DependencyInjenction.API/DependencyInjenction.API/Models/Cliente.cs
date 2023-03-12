namespace DependencyInjenction.API.Models
{
    public class Cliente
    {

        public int ClienteId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
