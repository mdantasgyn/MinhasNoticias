using MinhasNoticias.Application.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Actions
{
    public partial class ActionsIndex
    {
        private bool _loaded;
        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(500);
            _loaded = true;
        }
        public void OnActionInstall()
        {
            var parameters = new DialogParameters();
            var options = new DialogOptions() { CloseButton = false, NoHeader = true, MaxWidth = MaxWidth.Large, Position = DialogPosition.BottomCenter };
            var dialog = _dialogService.Show<AddToHomeScreen>("", parameters, options);
        }
        public void OnActionCall()
        {
            var parameters = new DialogParameters();
            var options = new DialogOptions() { CloseButton = false, NoHeader = true, MaxWidth = MaxWidth.Large, Position = DialogPosition.BottomCenter };
            var dialog = _dialogService.Show<CallButton>("", parameters, options);
        }

        public void OnActionConfirmation()
        {
            var parameters = new DialogParameters();
            var options = new DialogOptions() { CloseButton = false, NoHeader = true, MaxWidth = MaxWidth.Large, Position = DialogPosition.Center };
            var dialog = _dialogService.Show<Confirmation>("", parameters, options);
        }

        public void OnActionMaps()
        {
            var parameters = new DialogParameters();
            var options = new DialogOptions() { CloseButton = false, NoHeader = true, MaxWidth = MaxWidth.Large, Position = DialogPosition.BottomCenter };
            var dialog = _dialogService.Show<EmbedMaps>("", parameters, options);
        }

        public void OnActionLanguages()
        {
            var parameters = new DialogParameters();
            var options = new DialogOptions() { CloseButton = false, NoHeader = true, MaxWidth = MaxWidth.Large, Position = DialogPosition.Center };
            var dialog = _dialogService.Show<Languages>("", parameters, options);
        }

        public void OnActionShareLists()
        {
            var parameters = new DialogParameters();
            var options = new DialogOptions() { CloseButton = false, NoHeader = true, MaxWidth = MaxWidth.Large, Position = DialogPosition.BottomCenter };
            var dialog = _dialogService.Show<ShareLists>("", parameters, options);
        }

        public void OnActionShareGrid()
        {
            var parameters = new DialogParameters();
            var options = new DialogOptions() { CloseButton = false, NoHeader = true, MaxWidth = MaxWidth.Large, Position = DialogPosition.BottomCenter };
            var dialog = _dialogService.Show<ShareGrid>("", parameters, options);
        }

        public void OnActionSuccessBox()
        {
            var parameters = new DialogParameters();
            var options = new DialogOptions() { CloseButton = false, NoHeader = true, MaxWidth = MaxWidth.Large, Position = DialogPosition.BottomCenter };
            var dialog = _dialogService.Show<SuccessBox>("", parameters, options);
        }

        public void OnActionSuccessBoxBackground()
        {
            var parameters = new DialogParameters();
            var options = new DialogOptions() { CloseButton = false, NoHeader = true, MaxWidth = MaxWidth.Large, Position = DialogPosition.BottomCenter };
            var dialog = _dialogService.Show<SuccessBoxBackground>("", parameters, options);
        }

        public void OnActionVideoEmbedded()
        {
            var parameters = new DialogParameters();
            var options = new DialogOptions() { CloseButton = false, NoHeader = true, MaxWidth = MaxWidth.Large, Position = DialogPosition.BottomCenter };
            var dialog = _dialogService.Show<VideoEmbed>("", parameters, options);
        }

        public void OnActionWarningBox()
        {
            var parameters = new DialogParameters();
            var options = new DialogOptions() { CloseButton = false, NoHeader = true, MaxWidth = MaxWidth.Large, Position = DialogPosition.BottomCenter };
            var dialog = _dialogService.Show<WarningBox>("", parameters, options);
        }

        public void OnActionWarningBoxBackground()
        {
            var parameters = new DialogParameters();
            var options = new DialogOptions() { CloseButton = false, NoHeader = true, MaxWidth = MaxWidth.Large, Position = DialogPosition.BottomCenter };
            var dialog = _dialogService.Show<WarningBoxBackground>("", parameters, options);
        }
    }
}
