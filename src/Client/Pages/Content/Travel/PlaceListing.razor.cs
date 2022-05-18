using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Travel;

public partial class PlaceListing
{
    public MudTheme Theme = new MudTheme();
    public bool IsFavorite1 { get; set; }
    public bool IsFavorite2 { get; set; }
    public bool IsFavorite3 { get; set; }
    public bool IsFavorite4 { get; set; }
    public bool IsFavorite5 { get; set; }
    public bool IsFavorite6 { get; set; }
    public bool IsFavorite7 { get; set; }
    public bool IsFavorite8 { get; set; }
    protected override async Task OnInitializedAsync()
    {
    }

    public void NavigateToShoppingPage()
    {
        _navigationManager.NavigateTo("/grocery/products-2");
    }
}
