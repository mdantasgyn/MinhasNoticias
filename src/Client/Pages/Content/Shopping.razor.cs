using MinhasNoticias.Application.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content
{
    public partial class Shopping
    {
        public bool _loaded;
        Menu menu;
        private List<ProductItemInfo> _productItemMenu1;
        private List<ProductItemInfo> _productItemMenu2;

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(500);
            _productItemMenu1 = new List<ProductItemInfo>
            {
                new ProductItemInfo
                {
                    Id = 1,
                    Image = "/images/foods/1.jpg",
                    ItemName = "Home Burger",
                    Descriptions = "Our store guarantees the followig perks to all it's customers.",
                    Discount = "10%",
                    OnSale = true,
                    IsFavorite = false,
                    Price = "$36.50"
                },
                new ProductItemInfo
                {
                    Id = 2,
                    Image = "/images/foods/2.jpg",
                    ItemName = "Steaks",
                    Descriptions = "Our store guarantees the followig perks to all it's customers.",
                    Discount = "20%",
                    OnSale = false,
                    IsFavorite = true,
                    Price = "$29.99"
                },
                new ProductItemInfo
                {
                    Id = 3,
                    Image = "/images/foods/3.jpg",
                    ItemName = "Pizzas",
                    Descriptions = "Our store guarantees the followig perks to all it's customers.",
                    Discount = "15%",
                    OnSale = true,
                    IsFavorite = false,
                    Price = "$19.00"
                },
                new ProductItemInfo
                {
                    Id = 4,
                    Image = "/images/pictures/4.jpg",
                    ItemName = "Marina Steaks",
                    Descriptions = "Our store guarantees the followig perks to all it's customers.",
                    Discount = "10%",
                    OnSale = true,
                    IsFavorite = false,
                    Price = "$23.99"
                },
                new ProductItemInfo
                {
                    Id = 5,
                    Image = "/images/foods/5.jpg",
                    ItemName = "Gold Potatoes",
                    Descriptions = "Our store guarantees the followig perks to all it's customers.",
                    Discount = "10%",
                    OnSale = false,
                    IsFavorite = true,
                    Price = "$12.45"
                },
                new ProductItemInfo
                {
                    Id = 6,
                    Image = "/images/foods/6.jpg",
                    ItemName = "Baked Clams",
                    Descriptions = "Our store guarantees the followig perks to all it's customers.",
                    Discount = "30%",
                    OnSale = true,
                    IsFavorite = false,
                    Price = "$7.50"
                }
            };

            _productItemMenu2 = new List<ProductItemInfo>
            {
                new ProductItemInfo
                {
                    Id = 7,
                    Image = "/images/foods/7.jpg",
                    ItemName = "Desserts",
                    Descriptions = "Our store guarantees the followig perks to all it's customers.",
                    Discount = "10%",
                    OnSale = true,
                    IsFavorite = false,
                    Price = "$35.99"
                },
                new ProductItemInfo
                {
                    Id = 8,
                    Image = "/images/foods/8.jpg",
                    ItemName = "Potatoes Snack",
                    Descriptions = "Our store guarantees the followig perks to all it's customers.",
                    Discount = "20%",
                    OnSale = true,
                    IsFavorite = false,
                    Price = "$99.99"
                },
                new ProductItemInfo
                {
                    Id = 9,
                    Image = "/images/foods/9.jpg",
                    ItemName = "Madness Pizza",
                    Descriptions = "Our store guarantees the followig perks to all it's customers.",
                    Discount = "40%",
                    OnSale = false,
                    IsFavorite = true,
                    Price = "$15.50"
                },
                new ProductItemInfo
                {
                    Id = 10,
                    Image = "/images/foods/1.jpg",
                    ItemName = "King Burger",
                    Descriptions = "Our store guarantees the followig perks to all it's customers.",
                    Discount = "20%",
                    OnSale = true,
                    IsFavorite = false,
                    Price = "$9.99"
                },
                new ProductItemInfo
                {
                    Id = 11,
                    Image = "/images/foods/2.jpg",
                    ItemName = "Pizzas",
                    Descriptions = "Our store guarantees the followig perks to all it's customers.",
                    Discount = "15%",
                    OnSale = false,
                    IsFavorite = true,
                    Price = "$19.00"
                },
                new ProductItemInfo
                {
                    Id =12,
                    Image = "/images/foods/3.jpg",
                    ItemName = "Chocolates",
                    Descriptions = "Our store guarantees the followig perks to all it's customers.",
                    Discount = "10%",
                    OnSale = true,
                    IsFavorite = false,
                    Price = "$29.99"
                }
            };

            _loaded = true;
        }

        public void NavigateToProductDetail()
        {
            NavigationManager.NavigateTo("/shopping/productdetail");
        }

        public class Menu
        {
            public string Name { get; set; }
        }

        Func<Menu, string> converter = p => p?.Name;
    }
}
