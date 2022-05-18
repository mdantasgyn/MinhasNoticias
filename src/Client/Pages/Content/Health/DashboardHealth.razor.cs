using MinhasNoticias.Client.Infrastructure.Settings;
using MinhasNoticias.Client.Shared;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Health
{
    public partial class DashboardHealth
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public MudTheme Theme = new MudTheme();
        protected override async Task OnInitializedAsync()
        {

        }

        public void NavigateToMedicalForm()
        {
            NavigationManager.NavigateTo("/medical-form");
        }

        public void NavigateToVaccineCertificate()
        {
            NavigationManager.NavigateTo("/vaccine-certificate");
        }
    }
}
