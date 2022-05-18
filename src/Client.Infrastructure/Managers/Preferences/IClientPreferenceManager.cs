using MinhasNoticias.Shared.Managers;
using MudBlazor;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Infrastructure.Managers.Preferences
{
    public interface IClientPreferenceManager : IPreferenceManager
    {
        Task<MudTheme> GetCurrentThemeAsync();

        Task<bool> ToggleDarkModeAsync();
        Task ChangeFirstVisitAsync(bool isFirstVisit);
    }
}