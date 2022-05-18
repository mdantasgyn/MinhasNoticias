using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Grocery;

public partial class Cart
{
    protected override async Task OnInitializedAsync()
    {

    }

    public void NavigateToCheckout()
    {
        _navigationManager.NavigateTo("/grocery/checkout");
    }

    public MudTheme Theme = new MudTheme();

    public int IntValue { get; set; }
    public double DoubleValue { get; set; }
    public decimal DecimalValue { get; set; }
}
