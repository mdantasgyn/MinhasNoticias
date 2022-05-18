using MinhasNoticias.Application.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Generals
{
    public partial class PagesIndex
    {
        private bool _loaded;

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(500);
            _loaded = true;
        }

        public void AboutUsPage()
        {
            NavigationManager.NavigateTo("/about-us");
        }
        public void CareersPage()
        {
            NavigationManager.NavigateTo("/careers");
        }

        public void Error404Page()
        {
            NavigationManager.NavigateTo("/error404");
        }

        public void FaqsPage()
        {
            NavigationManager.NavigateTo("/faqs");
        }

        public void ForgotPasswordPage()
        {
            NavigationManager.NavigateTo("/pages/forgot-password");
        }

        public void SignInPage()
        {
            NavigationManager.NavigateTo("/pages/sign-in");
        }

        public void SignUpPage()
        {
            NavigationManager.NavigateTo("/pages/sign-up");
        }

        public void MapsPage()
        {
            NavigationManager.NavigateTo("/maps");
        }

        public void Timeline1Page()
        {
            NavigationManager.NavigateTo("/timeline1");
        }
        public void Timeline2Page()
        {
            NavigationManager.NavigateTo("/timeline2");
        }

        public void Profile1Page()
        {
            NavigationManager.NavigateTo("/profile1");
        }

        public void Profile2Page()
        {
            NavigationManager.NavigateTo("/profile2");
        }

        public void Profile3Page()
        {
            NavigationManager.NavigateTo("/profile3");
        }

        public void ContactUsPage()
        {
            NavigationManager.NavigateTo("/contact-us");
        }

        public void TeamPage()
        {
            NavigationManager.NavigateTo("/team");
        }

        public void StorePage()
        {
            NavigationManager.NavigateTo("/stores");
        }
    }
}
