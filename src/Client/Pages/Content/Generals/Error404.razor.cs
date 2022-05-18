using MinhasNoticias.Client.Infrastructure.Settings;
using MinhasNoticias.Client.Shared;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Generals
{
    public partial class Error404
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public MudTheme Theme = new MudTheme();
        protected override async Task OnInitializedAsync()
        {

        }

        private void InvokeQrPinModal()
        {
            var parameters = new DialogParameters();
            var options = new DialogOptions { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, FullScreen = true, DisableBackdropClick = true };
            _dialogService.Show<QrPinModal>("", parameters, options);
        }
    }
}
