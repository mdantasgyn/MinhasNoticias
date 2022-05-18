using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Grocery;

public partial class GroceryIndex
{
    public bool _loaded;
    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(500);
        _loaded = true;
    }

    public void NavigateToHomePage()
    {
        _navigationManager.NavigateTo("/grocery-home");
    }

    public void NavigateToCategoriesPage()
    {
        _navigationManager.NavigateTo("/grocery/categories");
    }

    public void NavigateToProductPage1()
    {
        _navigationManager.NavigateTo("/grocery/products-grid");
    }

    public void NavigateToProductPage2()
    {
        _navigationManager.NavigateTo("/grocery/products-list");
    }

    public void NavigateToProductDetailPage1()
    {
        _navigationManager.NavigateTo("/grocery/productdetail-1");
    }

    public void NavigateToProductDetailPage2()
    {
        _navigationManager.NavigateTo("/grocery/productdetail-2");
    }

    public void NavigateToCartPage()
    {
        _navigationManager.NavigateTo("/grocery/cart");
    }

    public void NavigateToCheckoutPage()
    {
        _navigationManager.NavigateTo("/grocery/checkout");
    }
}
