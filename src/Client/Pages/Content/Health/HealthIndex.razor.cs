using MinhasNoticias.Application.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Health
{
    public partial class HealthIndex
    {
        private bool _loaded;

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(500);
            _loaded = true;
        }

        public void NavigateToHealthDashboard()
        {
            NavigationManager.NavigateTo("/dashboard-health");
        }
        public void NavigateToMedicalForm()
        {
            NavigationManager.NavigateTo("/medical-form");
        }

        public void NavigateToVaccineCertificate()
        {
            NavigationManager.NavigateTo("/vaccine-certificate");
        }

        public void NavigateToVaccineCertificateDetails()
        {
            NavigationManager.NavigateTo("/certificate-details");
        }

        public void NavigateToAccount()
        {
            NavigationManager.NavigateTo("/health-account");
        }

        public void NavigateToPromotionsPage()
        {
            NavigationManager.NavigateTo("/promotions");
        }

        public void NavigateToSettings()
        {
            NavigationManager.NavigateTo("/health-settings");
        }
    }
}
