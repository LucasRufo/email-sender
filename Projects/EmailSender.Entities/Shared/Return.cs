using System.Collections.Generic;
using System.Linq;

namespace EmailSender.Entities.Shared
{
    public class Return
    {
        public bool Success { get { return Errors.Any(); } }

        public Dictionary<string, string> Errors { get; private set; } = new Dictionary<string, string>();

        public object Objeto { get; set; }

        public void Handle(string key, string value)
        {
            if (Errors.Any(m => m.Key == key) || string.IsNullOrEmpty(key) || string.IsNullOrEmpty(value))
                return;

            Errors.Add(key, value);
        }

        public Dictionary<string, string> GetErrors() => Errors;

        public Return()
        {
            if (Objeto == null)
                Objeto = new { };
        }

        public Return(object objeto)
        {
            Objeto = objeto;
        }

        public Return(string key, string value)
        {
            Handle(key, value);
        }
    }
}
