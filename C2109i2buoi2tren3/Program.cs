﻿using System.Collections;
using System.Reflection.Metadata;
using System.Text;
using System.Xml;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding= Encoding.Unicode;

int number1= Random.Shared.Next(0, 9);

int number2= Random.Shared.Next(0, 9);

Console.WriteLine($"{nameof(number1)}={number1}, {nameof(number2)}={number2}");



Console.WriteLine("vui long nhap vao");
String? dau = Console.ReadLine();
switch(dau)
{
    case "+" when number1> 0 && number2 > 0:
    Console.WriteLine(number1+ number2);
    break;

    case "-" when number1 >= number2:
    Console.WriteLine(number1 - number2);
    break;

    case "*":
    Console.WriteLine(number1 *number2);
    break;

    case "/":
    Console.WriteLine(number1 /number2);
    break;

    default:
        Console.WriteLine("hi i cant");
    break;
}

//switch expresstion
Console.WriteLine(
    dau switch
    {
        "+" when number1 > 0 && number2 > 0 => number1 + number2,
        "-" when number1 >=   number2  => number1 -number2,
        "+" when number1 > 0 && number2 > 0 => number1 *number2,
        "/" when number2 != 0            => number1 /number2,

      _=> "khong duoc dau"
    }
    );

string[] arrs={ "dat", "manh", "tam", "luan" };

foreach (var t in arrs)
{
    Console.WriteLine(t);
}

IEnumerator e = arrs.GetEnumerator();
while (e.MoveNext())
{
    string? = e.Current.ToString();
    Console.WriteLine(s);
}