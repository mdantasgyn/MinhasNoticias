using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Grocery;

public partial class ProductDetail2
{
    protected override async Task OnInitializedAsync()
    {

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
