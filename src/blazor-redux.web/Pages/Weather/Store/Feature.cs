using BlazorRedux.Pages.FetchData.Store;
using Fluxor;

namespace BlazorRedux.Pages.Weather.Store
{
    public class Feature : Feature<WeatherState>
	{
		public override string GetName() => "Weather";
		protected override WeatherState GetInitialState() =>
			new WeatherState(
				isLoading: false,
				forecasts: null);
	}
}
