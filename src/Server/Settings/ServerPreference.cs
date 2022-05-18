using System.Linq;
using MinhasNoticias.Shared.Constants.Localization;
using MinhasNoticias.Shared.Settings;

namespace MinhasNoticias.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}