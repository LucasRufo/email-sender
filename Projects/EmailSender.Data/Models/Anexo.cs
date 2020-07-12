using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender.Data.Models
{
    public class Anexo
    {
        public int Id_Anexo { get; set; }

        public int Id_Email { get; set; }

        public string Cd_Anexo { get; set; }

        public string Nm_Anexo { get; set; }

        public bool Fl_Ativo { get; set; }

        public DateTime Dt_Criacao { get; set; }

        public virtual Email Email { get; set; }
    }
}
