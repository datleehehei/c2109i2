using System;
using System.Text;


Console.InputEncoding = Encoding.Unicode;

Console.OutputEncoding = Encoding.Unicode;

string str = "dat";
double money = 10.5;
bool check = true;
int number = 10;

//trong c sharp thuong co 2 dang kieu chinh
// 1 value type (dang so) khong chua dc null, 2 la reference type (chuoi, doi tuong) cho phep null;

string name = null;

//code cu 
Nullable<int> a = null;

//code moi ==> nullable value type

int? b = null;
bool? flag = null;
//? : => ternary operator
Console.WriteLine(name != null ? true : false);
//is not null (!=)
//is (==)
Console.WriteLine(name is not null ? true : false);

int age = 10;
if (age is 10)
{

}

//? => null conditional operator
//? dung sau dit ten bien, hay doi tuong 
//? tuong tu (!=) neu cai gi khac null thi lay cai ve sau

//int? length = name?.Length;

//if (name != null) ;
//{
//    length = name.Length;
//}
//else
//{
//    //length = null;
//}

//?? => null coalescing operator
//?? tuong tu dau ==, neu cai gi do bang null thi lay  cai ve sau

int? chieudai = name?.Length ?? 10;

