using EmailSender.Biz.Base;
using EmailSender.Biz.Interface;
using EmailSender.Entities.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace EmailSender.Biz.Core
{
    public class AnexoService : BaseService, IAnexoService
    {
        private const string DIRETORIO_ARQUIVOS = @"C:\Users\rifel\FilesFromProjects";

        public object CreateAttachment(AnexoDTO anexoDTOList)
        {
            throw new NotImplementedException();
        }

        public void SaveFiles(IEnumerable<AnexoDTO> anexoDTOList)
        {
            foreach (var anexoDTO in anexoDTOList)
                SaveAttachmentsFiles(anexoDTO);
        }

        private void SaveAttachmentsFiles(AnexoDTO anexoDTO)
        {
            if (!string.IsNullOrEmpty(DIRETORIO_ARQUIVOS)) return;

            var fullPath = Path.Combine(DIRETORIO_ARQUIVOS, anexoDTO.NomeArquivo);

            File.WriteAllBytes(fullPath, Convert.FromBase64String(anexoDTO.Base64));
        }
    }
}
