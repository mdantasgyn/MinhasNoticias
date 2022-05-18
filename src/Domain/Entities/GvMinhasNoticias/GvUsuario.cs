using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasNoticias.Domain.Entities.GvMinhasNoticias
{
    public class GvUsuario
    {
        public int Id { get; set; }
        public int IdPolitico { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public bool ColaboradorEquipePolitica { get; set; }

        public string CargoColaborador { get; set; }
        public bool Voluntario { get; set; }
        public string TextoVoluntariado { get; set; }
        public string TituloEleitor { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string MyProperty { get; set; }


    }
}
