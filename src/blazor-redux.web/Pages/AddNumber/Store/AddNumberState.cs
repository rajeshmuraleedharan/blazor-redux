namespace BlazorRedux.Pages.AddNumber.Store
{
    public class AddNumberState
    {
        public AddNumberState(int firstNumber, int secondNumber, int answer)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Answer = answer;
        }

        public int FirstNumber { get; }
        public int SecondNumber { get; }
        public int Answer { get; }
    }
}
