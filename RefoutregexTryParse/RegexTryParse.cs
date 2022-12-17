
namespace RefoutregexTryParse;
internal class RegexTryParse
{
    public void ChecknumberByRegex()
    {
        string? str = null;
        Console.WriteLine("vui long nhap vao: ");
        str = Console.ReadLine();

        if (new Regex("^[0-9]+$").IsMatch(str))
        {
            int result = int.Parse(str);
            Console.WriteLine($"{nameof(result)})={result}");
        }
    }
    public void CheckstringByRegex()
    {
        string? str = null;
        Console.WriteLine("vui long nhap vao: ");
        str = Console.ReadLine();

        
        if (double.TryParse(str, out double i))
        {
            Console.WriteLine($"{nameof(i)}={i}");
        }
    }

    internal void TryCatchBug()
    {
        throw new NotImplementedException();
    }
}

public void TryCatchBug()
{
    Console.WriteLine("vui long nhap so luong: ");
    string? amount = Console.ReadLine();
    try
    {
        int total = int.Parse(amount);
    }
    catch (Exception) when (amount.Contains("$"))
    {
        Console.WriteLine("amount ko dc co dau $: ");
    }
    catch (Exception e)
    {
        Console.WriteLine($"{e.GetType()} :  {e.Message}");
        }

    }
   