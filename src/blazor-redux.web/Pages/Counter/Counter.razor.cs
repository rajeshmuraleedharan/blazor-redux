using BlazorRedux.Pages.Counter.Store;
using BlazorRedux.Pages.Counter.Store.Action;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace BlazorRedux.Pages.Counter
{
    public partial class Counter
    {
        [Inject]
        private IState<CounterState> CounterState { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        private void IncrementCount()
        {
            Dispatcher.Dispatch(new IncrementCounterAction());
        }
    }
}
