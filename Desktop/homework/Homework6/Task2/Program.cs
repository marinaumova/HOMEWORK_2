Console.WriteLine("Введите строку, содержащую латинские буквы в обоих регистрах:");
string input = Console.ReadLine();
string result = input.ToLower();
Console.WriteLine("Результат: " + result);