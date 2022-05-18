using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasNoticias.Domain.Entities.GvMinhasNoticias
{
    public class GvPolitico
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string NomePolitico { get; set; }
        public string CargoPoliticoAtual { get; set; }
        public string CargoADisputar { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Gabinete { get; set; }
        public string Observacao { get; set; }
        public string TextoInformacao { get; set; }
        public string TextoPix { get; set; }
        public string UrlImagemPix { get; set; }
        public string ChavePix { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }

    }
}
