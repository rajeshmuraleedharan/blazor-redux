using BlazorRedux.Pages.AddNumber.Store.Action;
using Fluxor;

namespace BlazorRedux.Pages.AddNumber.Store.Reducer
{
    public static class AddNumberActionReducers
    {
        [ReducerMethod]
        public static AddNumberState ReducerAddNumberAction(AddNumberState state, AddNumberAction action)
        {
            return new AddNumberState(action.FirstNumber, action.SecondNumber, action.FirstNumber + action.SecondNumber);
        }
    }
}
