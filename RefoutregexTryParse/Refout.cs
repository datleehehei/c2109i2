namespace RefoutregexTryParse;
internal class Refout
{
    public static void ChangeVar(out int a, out int b)
    {
        a = 10;
        b = 11;
        var tam = a;
        a = b;
        b = tam;
        Console.WriteLine("Change balue");
        Console.WriteLine($"{nameof(a)}={a}, {nameof(b)}={b}");


    }

    
}
