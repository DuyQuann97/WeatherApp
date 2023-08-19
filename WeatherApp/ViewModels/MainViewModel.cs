using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;
using WeatherApp.Models;

namespace WeatherApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Properties
        private string _city;

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        #endregion

        #region Commands
        public ICommand SearchCommand { get; set; }
        #endregion

        public MainViewModel()
        {
            SearchCommand = new RelayCommand<object>(_ => { return true; }, async _ =>
            {
                // Handling event/command
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://weatherapi-com.p.rapidapi.com/current.json?q=Ho%20Chi%20Minh"),
                    Headers =
                    {
                        { "X-RapidAPI-Key", "1a19c73a31mshf423af852816df1p1f63a4jsnfb24cc4d42e6" },
                        { "X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com" },
                    },
                };

                var response = await client.SendAsync(request);
                var body = await response.Content.ReadAsStringAsync();
                
                // Map convert data Json

                var Infor = JsonConvert.DeserializeObject<WeatherInfo>(body);
            });
        }
    }
}
