namespace BlazorRedux.Pages.AddNumber.Store.Action
{
    public class AddNumberAction
    {
        public AddNumberAction(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }
                 
        public int FirstNumber { get; }

        public int SecondNumber { get; }
    }
}
