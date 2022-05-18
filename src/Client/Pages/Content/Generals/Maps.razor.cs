using MinhasNoticias.Client.Infrastructure.Settings;
using MinhasNoticias.Client.Shared;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinhasNoticias.Shared.Models.GoogleMap;

namespace MinhasNoticias.Client.Pages.Content.Generals
{
    public partial class Maps
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public MudTheme Theme = new MudTheme();

        public GoogleMapPosition _location { get; set; }
        protected override async Task OnInitializedAsync()
        {
            _location = new GoogleMapPosition { Lat = 10.234786711619794, Lng = 103.96343798707063 };
        }
    }
}
