// 1-й тип функций
void Method1();
{
    Console.WriteLine(Athor: Alex);
}
Method1();//вызов метода (функции)

// 2-й тип функций
void Method2(string msg);
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

// 3-й тип функций
int Method3()
{
    return DataTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//4-й тип функций
string Method4(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "Раз");
Console.WriteLine();
