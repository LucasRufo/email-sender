namespace EmailSender.Entities.Models
{
    public class AnexoDTO
    {
        public int ID { get; set; }

        public int IDEmail { get; set; }

        public string CodigoArquivo { get; set; }

        public string NomeArquivo { get; set; }

        public string Base64 { get; set; }
    }
}
