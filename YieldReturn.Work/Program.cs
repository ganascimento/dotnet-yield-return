using YieldReturn.Work.Foo;

//var foo = Foo1.Foo();
var foo = Foo2.Foo();

using (var item = foo.GetEnumerator())
{
    while (item.MoveNext())
    {
        var element = item.Current;
        Console.WriteLine(element);
    }
}