namespace EmailSender.WebApi.Models
{
    public class AnexoDTO
    {
        public int ID { get; set; }

        public int IDEmail { get; set; }

        public string CdAnexo { get; set; }

        public string NmAnexo { get; set; }

        public virtual EmailDTO EmailDTO { get; set; }
    }
}