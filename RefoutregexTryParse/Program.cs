
//int a = 10;
//int b = 11;


//Refout.ChangeVar(ref a, ref b);
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
Refout.ChangeVar(out int a, out int b);
Console.WriteLine("main :");
Console.WriteLine($"{nameof(a)}={a}, {nameof(b)}={b}");

////pure oop => oop nguyen thuy, thuan oop => c# cu
//RegexTryParse parse = new RegexTryParse();

////dung tu var
//var par = new RegexTryParse();

////target-type
RegexTryParse p = new();
//p.CheckstringByRegex();
p.TryCatchBug();




