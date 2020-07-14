using EmailSender.Data.Models;
using EmailSender.Entities.Models;
using System.Collections.Generic;

namespace EmailSender.Biz.Mapping
{
    public class AnexoMapping
    {
        public Anexo ToAnexoMap(AnexoDTO anexoDTO)
        {
            return new Anexo()
            {
                Cd_Anexo = anexoDTO.CodigoArquivo,
                Nm_Anexo = anexoDTO.NomeArquivo,
            };
        }

        public IEnumerable<Anexo> ToAnexoListMap(IEnumerable<AnexoDTO> anexoDTOList)
        {
            var anexoList = new List<Anexo>();

            foreach (var anexoDTO in anexoDTOList)
                anexoList.Add(ToAnexoMap(anexoDTO));

            return anexoList;
        }
    }
}
