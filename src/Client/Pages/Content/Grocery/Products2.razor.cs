using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Grocery;

public partial class Products2
{
    public bool _loaded;
    private List<ProductItemInfo> _productItemList;
    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(500);
        _productItemList = new List<ProductItemInfo>
        {
            new ProductItemInfo
            {
                Id = 1,
                Image = "/images/grocery/sm/1.png",
                ItemName = "Tomatoes",
                Descriptions = "Imported from Asia",
                Price = "$15.99",
                Discount = "5% Off"
            },
            new ProductItemInfo
            {
                Id = 2,
                Image = "/images/grocery/sm/2.png",
                ItemName = "Strawberries",
                Descriptions = "Local Farm Product",
                Price = "$19.99",
                Discount = "5% Off"
            },
            new ProductItemInfo
            {
                Id = 3,
                Image = "/images/grocery/sm/3.png",
                ItemName = "EU Onions",
                Descriptions = "Imported from Europe",
                Price = "$15.50",
                Discount = "15% Off"
            },
            new ProductItemInfo
            {
                Id = 4,
                Image = "/images/grocery/sm/4.png",
                ItemName = "Iceberg Salad",
                Descriptions = "Imported from Asia",
                Price = "$99.99",
                Discount = "5% Off"
            },
            new ProductItemInfo
            {
                Id = 5,
                Image = "/images/grocery/sm/5.png",
                ItemName = "Green Apple",
                Descriptions = "Local Farm Product",
                Price = "$9,99",
                Discount = "10% Off"
            },
            new ProductItemInfo
            {
                Id =6,
                Image = "/images/grocery/sm/6.png",
                ItemName = "Potatoes",
                Descriptions = "Imported from Asia",
                Price = "$11.99",
                Discount = "35% Off"
            }
        };

        _loaded = true;
    }

    public void NavigateToProductDetail()
    {
        _navigationManager.NavigateTo("/grocery/productdetail-2");
    }

    public class Menu
    {
        public string Name { get; set; }
    }

    Func<Menu, string> converter = p => p?.Name;

    public class ProductItemInfo
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string ItemName { get; set; }
        public string Descriptions { get; set; }
        public string Price { get; set; }
        public string Discount { get; set; }
    }
}
