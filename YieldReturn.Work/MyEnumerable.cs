using System.Collections;

namespace YieldReturn.Work;

public class MyEnumerable : IEnumerable<int>, IDisposable
{
    public void Dispose() { }

    public IEnumerator<int> GetEnumerator() => new MyEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => new MyEnumerator();
}

public class MyEnumerator : IEnumerator<int>
{
    public MyEnumerator()
    {
        Console.WriteLine("Start...");
    }

    int _current = -1;

    public int Current => _current;

    object IEnumerator.Current => _current;

    public void Dispose()
    {
        Console.WriteLine("End...");
    }

    public bool MoveNext()
    {
        if (_current > 0)
        {
            Console.WriteLine($"After 'yield return' {_current}...");
        }

        if (_current >= 10) return false;
        Console.WriteLine($"Before 'yield return' {_current}...");

        _current++;
        return true;

    }

    public void Reset()
    {
        _current = -1;
    }
}