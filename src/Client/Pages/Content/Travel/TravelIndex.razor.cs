using MinhasNoticias.Application.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Travel
{
    public partial class TravelIndex
    {
        private bool _loaded;
        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(500);
            _loaded = true;
        }
        public void NavigateToHomePage()
        {
            _navigationManager.NavigateTo("/travel/home");
        }

        public void NavigateToPlaceListingPage()
        {
            _navigationManager.NavigateTo("/travel/place-listing");
        }

        public void NavigateToExperiencesPage()
        {
            _navigationManager.NavigateTo("/travel/experiences");
        }

        public void NavigateToRoomBookingPage()
        {
            _navigationManager.NavigateTo("/travel/room-booking");
        }

        public void NavigateToTourDetailsPage()
        {
            _navigationManager.NavigateTo("/travel/tour-details");
        }

        public void NavigateToConfirmationPage()
        {
            _navigationManager.NavigateTo("/travel/confirmation");
        }
    }
}
