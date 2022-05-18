﻿using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Wallet
{
    public partial class TransactionDetail
    {
        //private List<BreadcrumbItem> _routes = new List<BreadcrumbItem>
        //{
        //    new BreadcrumbItem("Pages", href: "/pages"),
        //     new BreadcrumbItem("Wallet", href: "/pages/wallet"),
        //    new BreadcrumbItem("Transaction details", href: null, disabled: true)
        //};
        protected override async Task OnInitializedAsync()
        {

        }

        public MudTheme Theme = new MudTheme();

        public int IntValue { get; set; } = 1;
        public double DoubleValue { get; set; }
        public decimal DecimalValue { get; set; }

        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string ValidThru { get; set; }
        public string CVV { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string Apartment { get; set; }
    }
}
