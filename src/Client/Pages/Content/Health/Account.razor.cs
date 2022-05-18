using MinhasNoticias.Application.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Health
{
    public partial class Account
    {
        public bool _loaded = false;

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(500);
            _loaded = true;
        }
    }
}
