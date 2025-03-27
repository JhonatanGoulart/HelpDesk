namespace HelpDeskPro.API.Models
{
    public class Ticket
    {
        public int Id { get; set; }                     // Identificador único do chamado
        public required string Titulo { get; set; }              // Título do problema
        public required string Descricao { get; set; }           // Detalhes do chamado
        public DateTime DataAbertura { get; set; }      // Data de abertura do chamado
        public DateTime? DataFechamento { get; set; }   // Data de fechamento (opcional)
        public required string Status { get; set; }              // Status do chamado (Aberto, Fechado, etc.)
        public int UsuarioId { get; set; }              // Chave estrangeira do usuário
        public required User Usuario { get; set; }               // Relacionamento com a entidade User
    }
}