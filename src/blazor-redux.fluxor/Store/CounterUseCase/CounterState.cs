using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorRedux.fluxor.Store.CounterUseCase
{
    public class CounterState
    {
        public int ClickCount { get; }

        public CounterState(int clickCount)
        {
            ClickCount = clickCount;
        }
    }
}
