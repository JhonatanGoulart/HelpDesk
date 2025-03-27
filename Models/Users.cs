namespace HelpDeskPro.API.Models
{
    public class User
    {
        public int Id { get; set; }                 // Identificador único do usuário
        public string Nome { get; set; }            // Nome do usuário
        public string Email { get; set; }           // Email para contato
        public string Cargo { get; set; }           // Cargo na empresa 
        public bool Ativo { get; set; }             // Indicador de conta ativa
    }
}