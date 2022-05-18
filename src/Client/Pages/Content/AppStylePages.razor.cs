using MinhasNoticias.Application.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content
{
    public partial class AppStylePages
    {
        private bool _loaded;
        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(500);
            _loaded = true;
        }

        public void WelcomePage()
        {
            _navigationManager.NavigateTo("/walkthrough-welcome");
        }

        public void SignInPage()
        {
            _navigationManager.NavigateTo("/pages/sign-in");
        }

        public void SignUpPage()
        {
            _navigationManager.NavigateTo("/pages/sign-up");
        }

        public void ResetPasswordPage()
        {
            _navigationManager.NavigateTo("/pages/forgot-password");
        }
        public void BlogsHome()
        {
            _navigationManager.NavigateTo("/blogs-home1");
        }

        public void CommerceHome()
        {
            _navigationManager.NavigateTo("/dashboard-commerce");
        }

        public void GroceryHome()
        {
            _navigationManager.NavigateTo("/grocery-home");
        }

        public void HealthHome()
        {
            _navigationManager.NavigateTo("/dashboard-health");
        }

        public void LearningHome()
        {
            _navigationManager.NavigateTo("/learning-home1");
        }

        public void ProjectsHome()
        {
            _navigationManager.NavigateTo("/project-home1");
        }

        public void TravelsHome()
        {
            _navigationManager.NavigateTo("/travel/home");
        }

        public void WalletHome()
        {
            _navigationManager.NavigateTo("/dashboard-wallet");
        }

        public void AccountPage()
        {
            _navigationManager.NavigateTo("/profile1");
        }

        public void StorePage()
        {
            _navigationManager.NavigateTo("/stores");
        }
    }
}
