﻿using System.Collections.Generic;
using Blazored.LocalStorage;
using MinhasNoticias.Client.Infrastructure.Settings;
using MudBlazor;
using System.Threading.Tasks;
using MinhasNoticias.Shared.Constants.Storage;
using MinhasNoticias.Shared.Settings;
using MinhasNoticias.Shared.Wrapper;
using Microsoft.Extensions.Localization;

namespace MinhasNoticias.Client.Infrastructure.Managers.Preferences
{
    public class ClientPreferenceManager : IClientPreferenceManager
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly IStringLocalizer<ClientPreferenceManager> _localizer;

        public ClientPreferenceManager(
            ILocalStorageService localStorageService,
            IStringLocalizer<ClientPreferenceManager> localizer)
        {
            _localStorageService = localStorageService;
            _localizer = localizer;
        }

        public async Task<bool> ToggleDarkModeAsync()
        {
            var preference = await GetPreference() as ClientPreference;
            if (preference != null)
            {
                preference.IsDarkMode = !preference.IsDarkMode;
                await SetPreference(preference);
                return !preference.IsDarkMode;
            }

            return false;
        }
        public async Task<bool> ToggleLayoutDirection()
        {
            var preference = await GetPreference() as ClientPreference;
            if (preference != null)
            {
                preference.IsRTL = !preference.IsRTL;
                await SetPreference(preference);
                return preference.IsRTL;
            }
            return false;
        }

        public async Task<IResult> ChangeLanguageAsync(string languageCode)
        {
            var preference = await GetPreference() as ClientPreference;
            if (preference != null)
            {
                preference.LanguageCode = languageCode;
                await SetPreference(preference);
                return new Result
                {
                    Succeeded = true,
                    Messages = new List<string> { _localizer["Client Language has been changed"] }
                };
            }

            return new Result
            {
                Succeeded = false,
                Messages = new List<string> { _localizer["Failed to get client preferences"] }
            };
        }

        public async Task ChangeFirstVisitAsync(bool isFirstVisit)
        {
            var preference = await GetPreference() as ClientPreference;
            if (preference != null)
            {
                preference.IsFirstVisit = isFirstVisit;
                await SetPreference(preference);
            }
        }
        public async Task<MudTheme> GetCurrentThemeAsync()
        {
            var preference = await GetPreference() as ClientPreference;
            if (preference != null)
            {
                if (preference.IsDarkMode == true) return AppTheme.DarkTheme;
            }
            return AppTheme.DefaultTheme;
        }
        public async Task<bool> IsRTL()
        {
            var preference = await GetPreference() as ClientPreference;
            if (preference != null)
            {
                if (preference.IsDarkMode == true) return false;
            }
            return preference.IsRTL;
        }
        public async Task<string> LanguageCode()
        {
            var preference = await GetPreference() as ClientPreference;
            return preference != null ? preference.LanguageCode : "en-US";
        }
        public async Task<bool> IsFirstVisit()
        {
            var preference = await GetPreference() as ClientPreference;
            if (preference != null)
            {
                return preference.IsFirstVisit;
            }
            return preference.IsFirstVisit;
        }

        public async Task<IPreference> GetPreference()
        {
            return await _localStorageService.GetItemAsync<ClientPreference>(StorageConstants.Local.Preference) ?? new ClientPreference();
        }

        public async Task SetPreference(IPreference preference)
        {
            await _localStorageService.SetItemAsync(StorageConstants.Local.Preference, preference as ClientPreference);
        }
    }
}