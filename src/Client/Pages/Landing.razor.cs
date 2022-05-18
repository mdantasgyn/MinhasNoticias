using Blazored.FluentValidation;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.JSInterop;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages
{
    public partial class Landing
    {
        public MudTheme Theme = new MudTheme();

        bool open = false;

        private string qrApi = "https://api.qrserver.com/v1/create-qr-code/?size=100x100&data=";
        private string appUrl = "https://blazorstore.tlssoftwarevn.com/";
        public string AppUrl { get; set; }

        void ToggleDrawer()
        {
            open = !open;
        }
        protected override async Task OnInitializedAsync()
        {
            AppUrl = qrApi + appUrl;
        }
        public void NavigateToLogin()
        {
            _navigationManager.NavigateTo("/login");
        }

        public void NavigateToRegister()
        {
            _navigationManager.NavigateTo("/register");
        }

        private async Task ExploreAsync()
        {

        }

        public async Task NavigateToSliderSection()
        {
            await _jsRuntime.InvokeAsync<string>("ScrollToSection", "sliderSection");
            open = false;
        }

        public async Task NavigateToTrendingSection()
        {
            await _jsRuntime.InvokeAsync<string>("ScrollToSection", "trendingSection");
            open = false;
        }

        public async Task NavigateToHotProductsSection()
        {
            await _jsRuntime.InvokeAsync<string>("ScrollToSection", "hotProductSection");
            open = false;
        }

        public async Task NavigateToBlogSection()
        {
            await _jsRuntime.InvokeAsync<string>("ScrollToSection", "blogSection");
            open = false;
        }

        public async Task NavigateToContactSection()
        {
            await _jsRuntime.InvokeAsync<string>("ScrollToSection", "contactSection");
            open = false;
        }
        
    }
}