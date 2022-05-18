using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Content
{
    public partial class QrPinModal
    {
        private bool _loaded;
        private string qrApi = "https://api.qrserver.com/v1/create-qr-code/?size=200x200&data=";
        protected override async Task OnInitializedAsync()
        {
            _loaded = false;
            await Task.Delay(500);
            ImgSrc = qrApi + "http://tlssoftwarevn.com";
            _loaded = true;
        }

        public string ImgSrc { get; set; }
    }
}
