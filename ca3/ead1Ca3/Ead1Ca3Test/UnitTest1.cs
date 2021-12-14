using ead1Ca3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Ead1Ca3Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string url = "https://meta-weather.now.sh/api/location/560743";
            string expected = "Dublin";

            var Http = new HttpClient();
            WorldWeather.WeatherData get1, get2;

            get1 = await Http.GetJsonAsync<WorldWeather.WeatherData>(url);
            get2 = await Http.GetJsonAsync<WorldWeather.WeatherData>(url);
            Weather.WeatherData weatherData = new WorldWeather.WeatherData();
            string weatherLoc = ""; //weatherData.title;

            Assert.Equal(expected, weatherLoc);
        }
    }
}
