namespace YieldReturn.Work.Foo;

public static class Foo1
{
    public static IEnumerable<int> Foo()
    {
        Console.WriteLine("Start...");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Before 'yield return' {i}...");

            yield return i;

            Console.WriteLine($"After 'yield return' {i}...");
        }

        Console.WriteLine("End...");
    }
}