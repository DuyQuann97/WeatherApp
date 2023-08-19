using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

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
            SearchCommand = new RelayCommand<object>(_ => { return true; }, _ =>
            {
                // Handling event/command
                string searchedCity = City;
            });
        }
    }
}
