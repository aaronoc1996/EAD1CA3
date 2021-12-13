using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Threading.Tasks;
using ead1Ca3.Shared;


namespace ead1Ca3.Pages
{
   public partial class Index : ComponentBase
    {
        private Root Main;
        private string ErrorMessage;
        private string city = "Dublin";
        private int cityId = 560743;
        private async Task GetDataAsync()
        {
            try
            {
                string uri = "https://meta-weather.now.sh/api/location/"+ cityId +"/";
                Main = await Http.GetJsonAsync<Root>(uri);
                ErrorMessage = String.Empty;
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }


        protected override async Task OnInitializedAsync()
        {
            await GetDataAsync();
        }

    }
}
