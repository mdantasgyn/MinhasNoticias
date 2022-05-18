using MinhasNoticias.Shared.Settings;
using System.Threading.Tasks;
using MinhasNoticias.Shared.Wrapper;

namespace MinhasNoticias.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}