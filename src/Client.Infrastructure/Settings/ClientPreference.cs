using System.Linq;
using MinhasNoticias.Shared.Constants.Localization;
using MinhasNoticias.Shared.Settings;

namespace MinhasNoticias.Client.Infrastructure.Settings
{
    public record ClientPreference : IPreference
    {
        public bool IsDarkMode { get; set; }
        public bool IsRTL { get; set; }
        public bool IsDrawerOpen { get; set; }
        public string PrimaryColor { get; set; }
        public bool IsFirstVisit { get; set; } = true;
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "pt-BR";
    }
}