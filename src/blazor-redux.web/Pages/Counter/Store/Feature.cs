﻿using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRedux.Pages.Counter.Store
{
    public class Feature : Feature<CounterState>
    {
        public override string GetName() => "Counter";

        protected override CounterState GetInitialState() => 
            new CounterState(clickCount: 0);
    }
}
