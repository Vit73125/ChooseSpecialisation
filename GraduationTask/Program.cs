//===================================================================================
// # Написать программу, которая из имеющегося массива строк формирует массив из
// строк, длина которых меньшелибо равна 3 символа.
//===================================================================================

string[] inputStrings = { "hello", "2", "world", ":-)" };
PrintStrings(inputStrings);
PrintStrings(GetFixStrings(inputStrings));
PrintStrings(inputStrings);

// Выбор строк меньше 3 символов
string[] GetFixStrings(string[] str)
{
    int len = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            string buf = str[len];
            str[len] = str[i];
            str[i] = buf;
            len++;
        }
    }
    string[] strOut = new string[len];
    Array.Copy(str, 0, strOut, 0, len);
    return strOut;
}

// Вывод строк
void PrintStrings(string[] str)
{
    Console.Write("[");
    if (str.Length > 0)
    {
        Console.Write("\"" + str[0] + "\"");
        for (int i = 1; i < str.Length; i++)
        {
            Console.Write(", \"" + str[i] + "\"");
        }
    }
    Console.Write("]\n");
}