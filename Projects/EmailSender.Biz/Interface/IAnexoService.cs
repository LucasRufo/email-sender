using EmailSender.Entities.Models;
using System.Collections.Generic;

namespace EmailSender.Biz.Interface
{
    public interface IAnexoService
    {
        void SaveFiles(IEnumerable<AnexoDTO> anexoDTOList);

        object CreateAttachment(AnexoDTO anexoDTOList);
    }
}
