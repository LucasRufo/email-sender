using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmailSender.Data.Models
{
    public class Email
    {
        [Key]
        public int Id_Email { get; set; }

        public string Ds_To { get; set; }

        public string Ds_Assunto { get; set; }

        public string Ds_Corpo  { get; set; }

        public bool Fl_Ativo { get; set; }

        public DateTime Dt_Criacao { get; set; }
    }
}
