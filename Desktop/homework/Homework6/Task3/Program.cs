Console.Write("Введите строку: ");
string input = Console.ReadLine();
if (IsPalindrome(input))
     {
        Console.WriteLine("Строка является палиндромом.");
     }
else
    {
        Console.WriteLine("Строка не является палиндромом.");
    }
bool IsPalindrome(string str)
{
    str = str.Replace(" ", "").ToLower();
char[] charArray = str.ToCharArray();
Array.Reverse(charArray);
string reversedString = new string(charArray);
return str == reversedString;
}