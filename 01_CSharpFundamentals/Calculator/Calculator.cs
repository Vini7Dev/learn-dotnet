namespace Calculator
{
  class Calculator
  {
    float FirstValue;
    float SecondValue;
    char Operation;

    public void Start()
    {
      char repeat;

      do
      {
        Console.Write("First value: ");

        FirstValue = float.Parse(Console.ReadLine());

        Console.Write("Operation [+ - * /]: ");

        Operation = char.Parse(Console.ReadLine());

        Console.Write("Second value: ");

        SecondValue = float.Parse(Console.ReadLine());

        BreakLine();

        float? result = Calculate();

        Console.WriteLine($"Result: {result}");

        BreakLine();

        Console.WriteLine("Repeat? [y / n]");

        repeat = char.Parse(Console.ReadLine().ToUpper());
        
        BreakLine();
      } while(repeat == 'Y');
    }

    private float? Calculate()
    {
      switch(Operation)
      {
        case '+': return Sum();
        case '-': return Subtract();
        case '*': return Multiply();
        case '/': return Divide();
        default: return null;
      }
    }

    private float Sum()
    {
      return FirstValue + SecondValue;
    }

    private float Subtract()
    {
      return FirstValue - SecondValue;
    }

    private float Multiply()
    {
      return FirstValue * SecondValue;
    }

    private float Divide()
    {
      return FirstValue / SecondValue;
    }

    private void BreakLine()
    {
      Console.WriteLine("");
    }
  }
}