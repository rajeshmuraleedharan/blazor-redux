using BlazorRedux.Dto;
using System.Collections.Generic;

namespace BlazorRedux.Pages.FetchData.Store
{
    public class WeatherState
    {
        public WeatherState(bool isLoading, IEnumerable<WeatherForecast> forecasts)
        {
            IsLoading = isLoading;
            Forecasts = forecasts;
        }

        public bool IsLoading { get; }
        public IEnumerable<WeatherForecast> Forecasts { get; }
    }
}
