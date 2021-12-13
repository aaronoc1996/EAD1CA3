using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Threading.Tasks;
using ead1Ca3.Shared;


namespace ead1Ca3.Pages
{
    public partial class Weather : ComponentBase
    {
        private Root Main;
        private string ErrorMessage;
        private string city = "Dublin";
        private int cityId = 560743;
        private async Task GetDataAsync()
        {
            try
            {
                string uri = "https://meta-weather.now.sh/api/location/" + cityId + "/";
                Main = await Http.GetJsonAsync<Root>(uri);
                ErrorMessage = String.Empty;
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }

            try
            {
                if (cityId == 560743)
                {
                    city = "Dublin";
                }

                else if (cityId == 2151330)
                {
                    city = "Beijing";
                }

                else if (cityId == 26042)
                {
                    city = "Leeds";
                }
                else if (cityId == 650272)
                {
                    city = "Frankfurt";
                }
                else if (cityId == 36615)
                {
                    city = "Sunderland";
                }
                else if (cityId == 721943)
                {
                    city = "Rome";
                }
                else if (cityId == 455825)
                {
                    city = "Rio";
                }
                else if (cityId == 2378426)
                {
                    city = "Charlotte";
                }
                else if (cityId == 766273)
                {
                    city = "Madrid";
                }
                else if (cityId == 2452078)
                {
                    city = "Minneapolis";
                }
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
