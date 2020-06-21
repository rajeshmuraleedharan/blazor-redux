using BlazorRedux.Dto;
using BlazorRedux.Pages.Weather.Store.Action;
using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorRedux.Pages.Weather.Store.Effect
{
    public class FetchWeatherDataActionEffect: Effect<FetchWeatherDataAction>
    {
        private readonly HttpClient _http;

        public FetchWeatherDataActionEffect(HttpClient http)
        {
            _http = http;
        }

        protected override async Task HandleAsync(FetchWeatherDataAction action, IDispatcher dispatcher)
        {
            var forecasts = await _http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
            dispatcher.Dispatch(new FetchWeatherDataResultAction(forecasts));
        }
    }
}
