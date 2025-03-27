namespace HelpDeskPro.API.Models
{
    public class User
    {
        public int Id { get; set; }                 // Identificador único do usuário
        public required string Nome { get; set; }            // Nome do usuário
        public required string Email { get; set; }           // Email para contato
        public required string Cargo { get; set; }           // Cargo na empresa 
        public bool Ativo { get; set; }             // Indicador de conta ativa
    }
}