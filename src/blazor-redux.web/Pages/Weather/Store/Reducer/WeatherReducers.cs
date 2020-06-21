using BlazorRedux.Pages.FetchData.Store;
using BlazorRedux.Pages.Weather.Store.Action;
using Fluxor;

namespace BlazorRedux.Pages.Weather.Store.Reducer
{
    public static class WeatherReducers
    {
        [ReducerMethod]
        public static WeatherState ReduceFetchWeatherDataAction(WeatherState state, FetchWeatherDataAction action) =>
            new WeatherState(isLoading: true, forecasts: null);

        [ReducerMethod]
        public static WeatherState ReduceFetchWeatherDataResultAction(WeatherState state, FetchWeatherDataResultAction action) =>
            new WeatherState(isLoading: false,
                             forecasts: action.Forecasts);
    }
}
