using System.Collections.Generic;

namespace EmailSender.Entities.Models
{
    public class EmailDTO
    {
        public int ID { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public string Assunto { get; set; }

        public string Corpo { get; set; }

        public virtual IEnumerable<AnexoDTO> AnexoDTO { get; set; }
    }
}
