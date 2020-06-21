using BlazorRedux.Pages.FetchData.Store;
using BlazorRedux.Pages.Weather.Store.Action;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace BlazorRedux.Pages.Weather
{
    public partial class Forecast
    {       

        [Inject]
        private IState<WeatherState> WeatherState { get; set; }

        [Inject]
        private IDispatcher Dispatcher { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            Dispatcher.Dispatch(new FetchWeatherDataAction());
        }

    }
}
