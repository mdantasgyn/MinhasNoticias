using MinhasNoticias.Application.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content.Blogs
{
    public partial class BlogsIndex
    {
        private bool _loaded;
        private List<PostSummary> _postList;

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(500);
            _loaded = true;
        }

        public void NavigateToHome1()
        {
            NavigationManager.NavigateTo("/blogs-home1");
        }
        public void NavigateToHome2()
        {
            NavigationManager.NavigateTo("/blogs-home2");
        }

        public void NavigateToHome3()
        {
            NavigationManager.NavigateTo("/blogs-home3");
        }

        public void NavigateToArticle1()
        {
            NavigationManager.NavigateTo("/article1");
        }

        public void NavigateToArticle2()
        {
            NavigationManager.NavigateTo("/article2");
        }

        public void NavigateToArticleLists()
        {
            NavigationManager.NavigateTo("/article-lists");
        }

        public void NavigateToArticleGrid()
        {
            NavigationManager.NavigateTo("/article-grid");
        }

        public void NavigateToArticleCards()
        {
            NavigationManager.NavigateTo("/article-cards");
        }
    }
}
