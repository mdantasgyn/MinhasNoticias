﻿using MinhasNoticias.Client.Extensions;
using MinhasNoticias.Client.Infrastructure.Settings;
using MinhasNoticias.Client.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using System.Threading.Tasks;
using Dialogs = MinhasNoticias.Client.Shared.Dialogs;

namespace MinhasNoticias.Client.Pages.Content
{
    public partial class Settings
    {
        [CascadingParameter] public MainLayout MainLayout { get; set; }
        [CascadingParameter] public HubConnection HubConnection { get;set;}
        private string CurrentUserId { get; set; }
        private bool DarkMode { get; set; }
        private bool IsRTL { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var preference = await _clientPreferenceManager.GetPreference() as ClientPreference;
            if (preference != null)
            {
                DarkMode = preference.IsDarkMode;
                IsRTL = preference.IsRTL;
            }
            await LoadCurrentUserAsync();
        }

        private async Task LoadCurrentUserAsync()
        {
            var state = await _stateProvider.GetAuthenticationStateAsync();
            var user = state.User;
            if (user == null) return;
            if (user.Identity?.IsAuthenticated == true)
            {
                CurrentUserId = user.GetUserId();
            }
        }

        private void NavigateToOrderHistory()
        {
            _navigationManager.NavigateTo("/orderhistory");
        } 

        private void InvokeAccountInfoModal()
        {
            var parameters = new DialogParameters
            {
                {nameof(AccountInfoModal.UserId), CurrentUserId}
            };
            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, FullScreen= true, DisableBackdropClick = true };
            _dialogService.Show<AccountInfoModal>(_localizer["Account Info"], parameters, options);
        }

        private async Task InvokeLanguageSelectionModal()
        {
            var parameters = new DialogParameters();
            var options = new DialogOptions() { CloseButton = false, NoHeader = true, MaxWidth = MaxWidth.Large, Position = DialogPosition.Center };
            var dialog = _dialogService.Show<LanguageSelectionDialog>("", parameters, options);
            var result = await dialog.Result;
            if (!result.Cancelled)
            {
                _navigationManager.NavigateTo(_navigationManager.Uri, forceLoad: true);
            }
        }

        private async Task ToggleDarkModeAsync(bool value)
        {
            DarkMode = value;
            await MainLayout.DarkMode();
        }
        private async Task ToggleRTLModeAsync(bool value)
        {
            IsRTL = value;
            await MainLayout.ToggleRTL();
        }
        private void Logout()
        {
            var parameters = new DialogParameters
            {
                {nameof(Dialogs.Logout.ContentText), $"{_localizer["Logout Confirmation"]}"},
                {nameof(Dialogs.Logout.ButtonText), $"{_localizer["Logout"]}"},
                {nameof(Dialogs.Logout.Color), Color.Error},
                {nameof(Dialogs.Logout.CurrentUserId), CurrentUserId},
                {nameof(Dialogs.Logout.HubConnection), HubConnection}
            };

            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true };

            _dialogService.Show<Dialogs.Logout>(_localizer["Logout"], parameters, options);
        }
    }
}
