using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace MinhasNoticias.Shared.Constants.Permission
{
    public static class Permissions
    {

        [DisplayName("Politico")]
        [Description("Permissões para Politico")]
        public static class GvPolitico
        {
            public const string View = "Permissoes.GvPolitico.Visualizar";
            public const string Create = "Permissoes.GvPolitico.Criar";
            public const string Edit = "Permissoes.GvPolitico.Editar";
            public const string Delete = "Permissoes.GvPolitico.Excluir";
            public const string Export = "Permissoes.GvPolitico.Exportar";
            public const string Search = "Permissoes.GvPolitico.Buscar";
        }

        [DisplayName("Usuário")]
        [Description("Permissões para Usuário")]
        public static class GvUsuario
        {
            public const string View = "Permissoes.GvUsuario.Visualizar";
            public const string Create = "Permissoes.GvUsuario.Criar";
            public const string Edit = "Permissoes.GvUsuario.Editar";
            public const string Delete = "Permissoes.GvUsuario.Excluir";
            public const string Export = "Permissoes.GvUsuario.Exportar";
            public const string Search = "Permissoes.GvUsuario.Buscar";
        }

        [DisplayName("Notícia")]
        [Description("Permissões para Notícias")]
        public static class GvMovNoticia
        {
            public const string View = "Permissoes.GvMovNoticia.Visualizar";
            public const string Create = "Permissoes.GvMovNoticia.Criar";
            public const string Edit = "Permissoes.GvMovNoticia.Editar";
            public const string Delete = "Permissoes.GvMovNoticia.Excluir";
            public const string Export = "Permissoes.GvMovNoticia.Exportar";
            public const string Search = "Permissoes.GvMovNoticia.Buscar";
        }

        [DisplayName("Sugestão")]
        [Description("Permissões para Sugestões")]
        public static class GvMovSugestao
        {
            public const string View = "Permissoes.GvMovSugestao.Visualizar";
            public const string Create = "Permissoes.GvMovSugestao.Criar";
            public const string Edit = "Permissoes.GvMovSugestao.Editar";
            public const string Delete = "Permissoes.GvMovSugestao.Excluir";
            public const string Export = "Permissoes.GvMovSugestao.Exportar";
            public const string Search = "Permissoes.GvMovSugestao.Buscar";
        }

        [DisplayName("Enquete")]
        [Description("Permissões para Enquetes")]
        public static class GvMovEnquete
        {
            public const string View = "Permissoes.GvMovEnquete.Visualizar";
            public const string Create = "Permissoes.GvMovEnquete.Criar";
            public const string Edit = "Permissoes.GvMovEnquete.Editar";
            public const string Delete = "Permissoes.GvMovEnquete.Excluir";
            public const string Export = "Permissoes.GvMovEnquete.Exportar";
            public const string Search = "Permissoes.GvMovEnquete.Buscar";
        }

        [DisplayName("Enquete Opções")]
        [Description("Permissões para Opções de Enquetes")]
        public static class GvMovEnqueteOpcoes
        {
            public const string View = "Permissoes.GvMovEnqueteOpcoes.Visualizar";
            public const string Create = "Permissoes.GvMovEnqueteOpcoes.Criar";
            public const string Edit = "Permissoes.GvMovEnqueteOpcoes.Editar";
            public const string Delete = "Permissoes.GvMovEnqueteOpcoes.Excluir";
            public const string Export = "Permissoes.GvMovEnqueteOpcoes.Exportar";
            public const string Search = "Permissoes.GvMovEnqueteOpcoes.Buscar";
        }

        [DisplayName("Enquete Votos")]
        [Description("Permissões para Votação em Enquetes")]
        public static class GvMovEnqueteVotos
        {
            public const string View = "Permissoes.GvMovEnqueteVotos.Visualizar";
            public const string Create = "Permissoes.GvMovEnqueteVotos.Criar";
            public const string Edit = "Permissoes.GvMovEnqueteVotos.Editar";
            public const string Delete = "Permissoes.GvMovEnqueteVotos.Excluir";
            public const string Export = "Permissoes.GvMovEnqueteVotos.Exportar";
            public const string Search = "Permissoes.GvMovEnqueteVotos.Buscar";
        }

        [DisplayName("Demanda")]
        [Description("Permissões Demandas")]
        public static class GvMovDemanda
        {
            public const string View = "Permissoes.GvMovDemanda.Visualizar";
            public const string Create = "Permissoes.GvMovDemanda.Criar";
            public const string Edit = "Permissoes.GvMovDemanda.Editar";
            public const string Delete = "Permissoes.GvMovDemanda.Excluir";
            public const string Export = "Permissoes.GvMovDemanda.Exportar";
            public const string Search = "Permissoes.GvMovDemanda.Buscar";
        }

        [DisplayName("Andamento Demanda")]
        [Description("Permissões Andamento de Demandas")]
        public static class GvMovAndamentoDemanda
        {
            public const string View = "Permissoes.GvMovAndamentoDemanda.Visualizar";
            public const string Create = "Permissoes.GvMovAndamentoDemanda.Criar";
            public const string Edit = "Permissoes.GvMovAndamentoDemanda.Editar";
            public const string Delete = "Permissoes.GvMovAndamentoDemanda.Excluir";
            public const string Export = "Permissoes.GvMovAndamentoDemanda.Exportar";
            public const string Search = "Permissoes.GvMovAndamentoDemanda.Buscar";
        }

        [DisplayName("Origem Noticia Hospedada")]
        [Description("Permissões Origem de Noticicia Hospedada")]
        public static class GvOrigemNoticiaHospedada
        {
            public const string View = "Permissoes.GvOrigemNoticiaHospedada.Visualizar";
            public const string Create = "Permissoes.GvOrigemNoticiaHospedada.Criar";
            public const string Edit = "Permissoes.GvOrigemNoticiaHospedada.Editar";
            public const string Delete = "Permissoes.GvOrigemNoticiaHospedada.Excluir";
            public const string Export = "Permissoes.GvOrigemNoticiaHospedada.Exportar";
            public const string Search = "Permissoes.GvOrigemNoticiaHospedada.Buscar";
        }











        //[DisplayName("Products")]
        //[Description("Products Permissions")]
        //public static class Products
        //{
        //    public const string View = "Permissions.Products.View";
        //    public const string Create = "Permissions.Products.Create";
        //    public const string Edit = "Permissions.Products.Edit";
        //    public const string Delete = "Permissions.Products.Delete";
        //    public const string Export = "Permissions.Products.Export";
        //    public const string Search = "Permissions.Products.Search";
        //}

        //[DisplayName("Brands")]
        //[Description("Brands Permissions")]
        //public static class Brands
        //{
        //    public const string View = "Permissions.Brands.View";
        //    public const string Create = "Permissions.Brands.Create";
        //    public const string Edit = "Permissions.Brands.Edit";
        //    public const string Delete = "Permissions.Brands.Delete";
        //    public const string Export = "Permissions.Brands.Export";
        //    public const string Search = "Permissions.Brands.Search";
        //    public const string Import = "Permissions.Brands.Import";
        //}

        [DisplayName("Documentos")]
        [Description("Permissões para Documentos")]
        public static class Documents
        {
            public const string View = "Permissoes.Documents.View";
            public const string Create = "Permissoes.Documents.Create";
            public const string Edit = "Permissoes.Documents.Edit";
            public const string Delete = "Permissoes.Documents.Delete";
            public const string Search = "Permissoes.Documents.Search";
        }

        [DisplayName("Tipos de Documentos")]
        [Description("Permissões de tipos de documentos")]
        public static class DocumentTypes
        {
            public const string View = "Permissoes.DocumentTypes.View";
            public const string Create = "Permissoes.DocumentTypes.Create";
            public const string Edit = "Permissoes.DocumentTypes.Edit";
            public const string Delete = "Permissoes.DocumentTypes.Delete";
            public const string Export = "Permissoes.DocumentTypes.Export";
            public const string Search = "Permissoes.DocumentTypes.Search";
        }

        [DisplayName("Atributos Estendidos do Documento")]
        [Description("Permissões de Atributos Estendidos do Documento")]
        public static class DocumentExtendedAttributes
        {
            public const string View = "Permissoes.DocumentExtendedAttributes.View";
            public const string Create = "Permissoes.DocumentExtendedAttributes.Create";
            public const string Edit = "Permissoes.DocumentExtendedAttributes.Edit";
            public const string Delete = "Permissoes.DocumentExtendedAttributes.Delete";
            public const string Export = "Permissoes.DocumentExtendedAttributes.Export";
            public const string Search = "Permissoes.DocumentExtendedAttributes.Search";
        }

        [DisplayName("Usuarios")]
        [Description("Permissões de usuários")]
        public static class Users
        {
            public const string View = "Permissoes.Users.View";
            public const string Create = "Permissoes.Users.Create";
            public const string Edit = "Permissoes.Users.Edit";
            public const string Delete = "Permissoes.Users.Delete";
            public const string Export = "Permissoes.Users.Export";
            public const string Search = "Permissoes.Users.Search";
        }

        [DisplayName("Funções")]
        [Description("Permissões de funções")]
        public static class Roles
        {
            public const string View = "Permissoes.Roles.View";
            public const string Create = "Permissoes.Roles.Create";
            public const string Edit = "Permissoes.Roles.Edit";
            public const string Delete = "Permissoes.Roles.Delete";
            public const string Search = "Permissoes.Roles.Search";
        }

        [DisplayName("Reivindicações de função")]
        [Description("Permissões de Reivindicações de Função")]
        public static class RoleClaims
        {
            public const string View = "Permissoes.RoleClaims.View";
            public const string Create = "Permissoes.RoleClaims.Create";
            public const string Edit = "Permissoes.RoleClaims.Edit";
            public const string Delete = "Permissoes.RoleClaims.Delete";
            public const string Search = "Permissoes.RoleClaims.Search";
        }

        [DisplayName("Comunicação")]
        [Description("Permissões de comunicação")]
        public static class Communication
        {
            public const string Chat = "Permissoes.Communication.Chat";
        }

        [DisplayName("Preferências")]
        [Description("Permissões de preferências")]
        public static class Preferences
        {
            public const string ChangeLanguage = "Permissoes.Preferences.ChangeLanguage";

            //TODO - add permissions
        }

        [DisplayName("Dashboards")]
        [Description("Permissões para Dashboards/Painéis")]
        public static class Dashboards
        {
            public const string View = "Permissoes.Dashboards.View";
        }

        [DisplayName("Hangfire")]
        [Description("Permissoes para Hangfire")]
        public static class Hangfire
        {
            public const string View = "Permissoes.Hangfire.View";
        }

        [DisplayName("Auditoria")]
        [Description("Permissões para Auditoria")]
        public static class AuditTrails
        {
            public const string View = "Permissoes.AuditTrails.View";
            public const string Export = "Permissoes.AuditTrails.Export";
            public const string Search = "Permissoes.AuditTrails.Search";
        }

        /// <summary>
        /// Returns a list of Permissions.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetRegisteredPermissions()
        {
            var permissions = new List<string>();
            foreach (var prop in typeof(Permissions).GetNestedTypes().SelectMany(c => c.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)))
            {
                var propertyValue = prop.GetValue(null);
                if (propertyValue is not null)
                    permissions.Add(propertyValue.ToString());
            }
            return permissions;
        }
    }
}