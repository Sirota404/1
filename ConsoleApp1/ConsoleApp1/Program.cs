using System;
using System.Collections.Generic;

var size = 0;


//Запрос у пользователя размеров таблицы.

{
    Console.WriteLine("Введите размерность таблицы (от 1 до 6): ");

    while (!int.TryParse(Console.ReadLine(), out size) || size < 1 || size > 6)
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите размерность таблицы от 1 до 6: ");
    }
    Console.WriteLine("Вы выбрали размерность " + size + " для таблицы.");
}

//Запрос содержания таблицы.

Console.WriteLine("Введите Текст для таблицы.");
var text = "";

text = Console.ReadLine();
if (string.IsNullOrEmpty(text) || text.Length > 40)
{ Console.WriteLine("Таблица не может быть пустой и не может содержать больше 40 символов. Введите текст"); }
else
{ Console.WriteLine("Вы ввели:" + text); }


//строки разделителя.
static string Separation(int a)
{
    var s = "";
    for (int i = 0; i <= a; i++)
    { s = s + "+"; }
    return s;
}
//горизонтальные, пустые строки.
static void Empty(int a, int b)
{
    var empty = "";
    for (int i = 0; i < a - 1; i++)
    { empty = empty + " "; }
    string second = "+" + empty + "+";
    for (int i = 0; i < b - 1; i++)
    { Console.WriteLine(second); }
}
//строка с текстом
static string TextInBox(int st, string t)
{
    var text = "";
    for (int i = 0; i < st - 1; i++)
    { text += " "; }
    var line = "+" + text + t + text + "+";
    return line;
}

//вывод шахматной доски

static void Chess(int ch, int st)
{
    for (int i = 0; i < st; i++)
    {
        Console.Write("+");
        string chess1 = "+";
        string chess2 = " ";
        for (int j = 0; j < ch; j++)
        {
            if ((i + j) % 2 == 0)
            {
                Console.Write(chess1);
            }
            else
            {
                Console.Write(chess2);
            }
        }
        Console.Write("+"); 
        Console.WriteLine();
    }
}

// крест
static void Cross(int ch)
{
    char[] cross = new char[ch - 1];
    cross[0] = '+';
    cross[cross.Length - 1] = '+';
    for (int i = 0; i < cross.Length; i++)
    { cross[i] = ' '; }

    for (int i = 0; i < cross.Length; ++i)
    {
        cross[i] = '+';
        cross[cross.Length - 1 - i] = '+';
        string crossString = new string(cross);
        crossString = "+" + crossString + "+";
        Console.WriteLine(crossString);
        cross[i] = ' ';
        cross[cross.Length - 1 - i] = ' ';
    }
}


var lenghtString = text.Length + size * 2 - 1;
string separation = Separation(lenghtString);
string textInBox = TextInBox(size, text);

Console.WriteLine(separation);
Empty(lenghtString, size);
Console.WriteLine(textInBox);
Empty(lenghtString, size);
Console.WriteLine(separation);
Chess(lenghtString - 1, size * 2 - 1);
Console.WriteLine(separation);
Cross(lenghtString);
Console.WriteLine(separation);

