Console.Write("Введите число от 10 до 99: "); 
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number / 10;
int secondDigit = number % 10;
if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}