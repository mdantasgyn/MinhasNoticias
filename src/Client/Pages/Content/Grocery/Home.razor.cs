using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Grocery;

public partial class Home
{
    public MudTheme Theme = new MudTheme();

    protected override async Task OnInitializedAsync()
    {
    }

    public void NavigateToShoppingPage()
    {
        _navigationManager.NavigateTo("/grocery/products-2");
    }
}
