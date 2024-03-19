using System.Threading;

namespace Stopwatch
{
  class Stopwatch
  {
    public void Start()
    {
      char repeat;

      do {
        Console.Clear();

        Console.Write("Time in seconds: ");

        int timerInSeconds = int.Parse(Console.ReadLine());

        Count(timerInSeconds);
        
        Console.Clear();

        Console.WriteLine("Finished! Repeat? [y / n]");

        repeat = char.Parse(Console.ReadLine().ToUpper());
      } while(repeat == 'Y');
    }

    private void Count(float timerInSeconds)
    {
      while(timerInSeconds > 0)
      {
        Console.Clear();
        Console.WriteLine(timerInSeconds);
        Thread.Sleep(1000);

        timerInSeconds--;
      }
    }
  }
}