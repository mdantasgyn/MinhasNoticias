﻿using MinhasNoticias.Client.Infrastructure.Settings;
using MinhasNoticias.Client.Shared;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Health
{
    public partial class VaccineCertificate
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public MudTheme Theme = new MudTheme();

        private bool _loaded;
        private string qrApi = "https://api.qrserver.com/v1/create-qr-code/?size=120x120&data=";
        protected override async Task OnInitializedAsync()
        {
            _loaded = false;
            await Task.Delay(500);
            ImgSrc = qrApi + "http://tlssoftwarevn.com";
            FullName = "John Alex Doe";
            DoB = "01/01/1990";
            PIDNo = "0123456789";
            _loaded = true;
        }

        public string ImgSrc { get; set; }
        public string FullName { get; set; }
        public string DoB { get; set; }
        public string PIDNo { get; set; }
    }
}
