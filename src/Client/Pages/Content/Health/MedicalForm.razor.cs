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
    public partial class MedicalForm
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public MudTheme Theme = new MudTheme();
        protected override async Task OnInitializedAsync()
        {

        }

        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
    }
}
