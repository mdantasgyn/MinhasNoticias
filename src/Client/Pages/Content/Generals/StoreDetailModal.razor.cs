using MinhasNoticias.Client.Shared.Components;
using Microsoft.AspNetCore.Components;
using MinhasNoticias.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Generals
{
    public partial class StoreDetailModal
    {
        private GoogleMap _googleMap;
        private string _googleMapsApiKey;
        [Parameter] public StoreInfo StoreInfo { get; set; } = new();
    }
}
