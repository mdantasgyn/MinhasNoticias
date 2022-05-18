using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinhasNoticias.Shared.Models.GoogleMap;

namespace MinhasNoticias.Client.Pages.Content.Travel;

public partial class RoomBooking
{
    public bool IsFavorite { get; set; }

    DateTime? date = null;
    DateRange _dateRange = new DateRange(DateTime.Now.Date, DateTime.Now.AddDays(3).Date);

    public GoogleMapPosition _location { get; set; }
    protected override async Task OnInitializedAsync()
    {
        _location = new GoogleMapPosition { Lat = 10.739780, Lng = 106.705020 };
    }

    public void NavigateToCheckout()
    {
        _navigationManager.NavigateTo("/checkout");
    }

    public void NavigateToCartDetail()
    {
        _navigationManager.NavigateTo("/cart");
    }
}
