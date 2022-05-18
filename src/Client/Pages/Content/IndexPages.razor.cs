using MinhasNoticias.Application.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content
{
    public partial class IndexPages
    {
        private bool _loaded;
        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(500);
            _loaded = true;
        }
        public void NavigateToOnboardingIndexPage()
        {
            _navigationManager.NavigateTo("/onboarding-index");
        }
        public void NavigateToGeneralIndexPage()
        {
            _navigationManager.NavigateTo("/generals-index");
        }

        public void NavigateToAppStylesPage()
        {
            _navigationManager.NavigateTo("/app-styles");
        }
        public void NavigateToActionsPage()
        {
            _navigationManager.NavigateTo("/actions-index");
        }
        public void NavigateToTravelIndexPage()
        {
            _navigationManager.NavigateTo("/travel");
        }

        public void NavigateToGroceryIndexPage()
        {
            _navigationManager.NavigateTo("/grocery");
        }

        public void NavigateToEducationIndexPage()
        {
            _navigationManager.NavigateTo("/learning");
        }

        public void NavigateToBlogIndexPage()
        {
            _navigationManager.NavigateTo("/blogs");
        }

        public void NavigateToProjectIndexPage()
        {
            _navigationManager.NavigateTo("/project");
        }

        public void NavigateToHealthIndexPage()
        {
            _navigationManager.NavigateTo("/health");
        }

        public void NavigateToCommerceIndexPage()
        {
            _navigationManager.NavigateTo("/commerce");
        }

        public void NavigateToWalletIndexPage()
        {
            _navigationManager.NavigateTo("/wallet");
        }

        public void NavigateToComponentsIndexPage()
        {
            _navigationManager.NavigateTo("/components");
        }

        public void NavigateToCustomComponentsIndexPage()
        {
            _navigationManager.NavigateTo("/component-page");
        }
    }
}
