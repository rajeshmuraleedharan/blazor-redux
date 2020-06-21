using BlazorRedux.Pages.Counter.Store.Action;
using Fluxor;

namespace BlazorRedux.Pages.Counter.Store.Reducer
{
    public static class CounterReducers
    {
        [ReducerMethod]
        public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action) => 
            new CounterState(clickCount: state.ClickCount + 1);
    }
}
