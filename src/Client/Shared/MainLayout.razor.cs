using MinhasNoticias.Client.Extensions;
using MinhasNoticias.Client.Infrastructure.Settings;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Shared
{
    public partial class MainLayout : IDisposable
    {
        private MudTheme _currentTheme;
        //private ThemeManagerTheme _themeManager = new ThemeManagerTheme();
        //public bool _themeManagerOpen = false;
        private bool _rightToLeft = false;
        public bool IsFirstVisit { get; set; }

        //void OpenThemeManager(bool value)
        //{
        //    _themeManagerOpen = value;
        //}

        //void UpdateTheme(ThemeManagerTheme value)
        //{
        //    _themeManager = value;
        //    StateHasChanged();
        //}
        private async Task RightToLeftToggle(bool value)
        {
            _rightToLeft = value;
            await Task.CompletedTask;
        }

        protected override async Task OnInitializedAsync()
        {
            _currentTheme = AppTheme.DefaultTheme;
            _currentTheme = await _clientPreferenceManager.GetCurrentThemeAsync();
            _rightToLeft = await _clientPreferenceManager.IsRTL();
            _interceptor.RegisterEvent();

            IsFirstVisit = await _clientPreferenceManager.IsFirstVisit();
            StateHasChanged();
        }

        public async Task DarkMode()
        {
            bool isDarkMode = await _clientPreferenceManager.ToggleDarkModeAsync();
            _currentTheme = isDarkMode
                ? AppTheme.DefaultTheme
                : AppTheme.DarkTheme;

            StateHasChanged();
        }
        public async Task ToggleRTL()
        {
            var isRtl = await _clientPreferenceManager.ToggleLayoutDirection();
            _rightToLeft = isRtl;

            StateHasChanged();
        }
        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}