using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRedux.Pages.AddNumber.Store
{
    public class Feature : Feature<AddNumberState>
    {
        public override string GetName() => "AddNumner";

        protected override AddNumberState GetInitialState() =>
            new AddNumberState(0, 0, 0);
    }
}
