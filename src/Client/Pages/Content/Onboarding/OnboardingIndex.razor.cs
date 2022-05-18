using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Onboarding;

public partial class OnboardingIndex
{
    public bool _loaded;
    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(500);
        _loaded = true;
    }

    public void NavigateToGrandientPage()
    {
        _navigationManager.NavigateTo("/walkthrough-gradient");
    }

    public void NavigateToIllustrationPage()
    {
        _navigationManager.NavigateTo("/walkthrough-illustration");
    }

    public void NavigateToMinimalPage()
    {
        _navigationManager.NavigateTo("/walkthrough-minimal");
    }

    public void NavigateToFlatPage()
    {
        _navigationManager.NavigateTo("/walkthrough-flat");
    }

    public void NavigateToImagePage()
    {
        _navigationManager.NavigateTo("/walkthrough-image");
    }

    public void NavigateToVariantPage()
    {
        _navigationManager.NavigateTo("/walkthrough-variant");
    }

    public void NavigateToWelcomePage()
    {
        _navigationManager.NavigateTo("/walkthrough-welcome");
    }

    public void NavigateToVideoPage()
    {
        _navigationManager.NavigateTo("/walkthrough-video");
    }
}
