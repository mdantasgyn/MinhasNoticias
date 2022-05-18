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
    public partial class Profile3
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public MudTheme Theme = new MudTheme();

        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public string Password { get; set; }

        private bool Notifications { get; set; }
        private bool Newsletter { get; set; }
        private bool DarkMode { get; set; }
        protected override async Task OnInitializedAsync()
        {
            FullName = "John Alex Doe";
            Email = "john.doe@example.com";
            PhoneNumber = "+12 345 6789990";
            Location = "Sanfransisco, USA";
            Password = "123password";
            Notifications = true;
            Newsletter = true;
            DarkMode = false;
        }

        private async Task ToggleNotificationAsync(bool value)
        {
            Notifications = value;
        }
        private async Task ToggleNewsletterAsync(bool value)
        {
            Newsletter = value;
        }
        private async Task ToggleDarkModeAsync(bool value)
        {
            DarkMode = value;
        }
    }
}
