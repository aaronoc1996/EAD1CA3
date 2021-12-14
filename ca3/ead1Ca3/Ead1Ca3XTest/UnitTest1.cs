using System;
using ead1Ca3;
using ead1Ca3.Shared;
using ead1Ca3.Pages;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace Ead1Ca3XTest
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1Async()
        {
            string url = "https://meta-weather.now.sh/api/location/560743";
            string expected = "Dublin";

            var Http = new HttpClient();
;

        }
    }
}
