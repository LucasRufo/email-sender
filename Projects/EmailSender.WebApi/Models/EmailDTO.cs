using System.Collections.Generic;

namespace EmailSender.WebApi.Models
{
    public class EmailDTO
    {
        public int ID { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public string Assunto { get; set; }

        public string Corpo { get; set; }

        public string Base64 { get; set; }

        public virtual IEnumerable<AnexoDTO> AnexoDTO { get; set; }
    }
}