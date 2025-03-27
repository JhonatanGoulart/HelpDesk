namespace HelpDeskPro.API.Models
{
    public class Ticket
    {
        public int Id { get; set; }                     // Identificador único do chamado
        public string Titulo { get; set; }              // Título do problema
        public string Descricao { get; set; }           // Detalhes do chamado
        public DateTime DataAbertura { get; set; }      // Data de abertura do chamado
        public DateTime? DataFechamento { get; set; }   // Data de fechamento (opcional)
        public string Status { get; set; }              // Status do chamado (Aberto, Fechado, etc.)
        public int UsuarioId { get; set; }              // Chave estrangeira do usuário
        public User Usuario { get; set; }               // Relacionamento com a entidade User
    }
}