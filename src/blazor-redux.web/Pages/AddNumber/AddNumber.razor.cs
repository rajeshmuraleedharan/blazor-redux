using BlazorRedux.Pages.AddNumber.Store;
using BlazorRedux.Pages.AddNumber.Store.Action;
using Fluxor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRedux.Pages.AddNumber
{
    public partial class AddNumber
    {
        private int FirstNumber { get; set; } 

        private int SecondNumber { get; set; }         

        [Inject]
        private IState<AddNumberState> AddNumberState { get; set; }

        [Inject]
        private IDispatcher Dispatcher { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            FirstNumber = AddNumberState.Value.FirstNumber;
            SecondNumber = AddNumberState.Value.SecondNumber;           
        }

        private void NumberUpdated()
        {
            Dispatcher.Dispatch(new AddNumberAction(FirstNumber, SecondNumber));
        }
    }
}
