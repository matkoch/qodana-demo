namespace ClassLibrary1;

public static class FizzBuzzer
{
    public static string FizzBuzz(int i)
    {
        return (i % 3 == 0, i % 5 == 0) switch
        {
            (true, true) => "FizzBuzz",
            (true, _) => "Fizz",
            (_, true) => "Buzz",
            (_, _) => i.ToString()
        };
    }
}
