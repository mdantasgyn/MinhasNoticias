using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Grocery;

public partial class Categories
{
    public bool _loaded;
    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(500);
        _loaded = true;
    }

    public void NavigateToCommerceIndexPage()
    {
        _navigationManager.NavigateTo("/commerce");
    }

    public void NavigateToWalletIndexPage()
    {
        _navigationManager.NavigateTo("/wallet");
    }
}
