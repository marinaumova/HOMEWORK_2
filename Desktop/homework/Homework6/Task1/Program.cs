﻿char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
string result = GetStringFromCharArray(charArray);
Console.WriteLine(result);
static string GetStringFromCharArray(char[,] array)
{
    string result = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j];
        }
    }
    return result;
}