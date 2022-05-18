using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MinhasNoticias.Domain.Entities.GvMinhasNoticias
{
    public class GvMovNoticia
    {

        public int Id { get; set; }
        public int IdPolitico { get; set; }
        public virtual GvPolitico GvPolitico { get; set; }

        public DateTime DataPostagem { get; set; }
        public string TipoRedeSocial { get; set; }
        public string UrlPostagem { get; set; }
        public string Texto { get; set; }
        public bool Ativo { get; set; }
        public DateTime DesativadoEm { get; set; }
        public int Quantidadevisualizacao { get; set; }
    }
}