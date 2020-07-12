using System;
using System.Collections.Generic;

namespace EmailSender.Data.Models
{
    public class Email
    {
        public int Id_Email { get; set; }

        public string Ds_From { get; set; }

        public string Ds_To { get; set; }

        public string Ds_Assunto { get; set; }

        public string Ds_Corpo  { get; set; }

        public bool Fl_Ativo { get; set; }

        public DateTime Dt_Criacao { get; set; }

        public virtual IEnumerable<Anexo> Anexo { get; set; }
    }
}
