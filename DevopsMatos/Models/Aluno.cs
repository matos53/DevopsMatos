namespace DevopsMatos.Models
{
    public class Aluno
    {
        public Aluno()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? RGM { get; set; }
        public string? Professor { get; set; }
        public string? Email { get; set; }
        public DateTime Idade { get; set; }
    }
}
