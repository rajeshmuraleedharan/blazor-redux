using BlazorRedux.Dto;
using System.Collections.Generic;

namespace BlazorRedux.Pages.Weather.Store.Action
{
    public class FetchWeatherDataResultAction
    {
        public FetchWeatherDataResultAction(IEnumerable<WeatherForecast> forecasts)
        {
            Forecasts = forecasts;
        }

        public IEnumerable<WeatherForecast> Forecasts { get; }
    }
}
