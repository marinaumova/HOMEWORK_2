// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

int[] arr1 = { 1, 5, 4, 8, 7 };
int temp;
Console.Write("Исходный массив: ");
foreach (int number in arr1)
{
    Console.Write(number + " ");
}
for (int i = 0; i < arr1.Length / 2; i++)
{
    temp = arr1[i];
    arr1[i] = arr1[arr1.Length - 1 - i];
    arr1[arr1.Length - 1 - i] = temp;
}
 Console.Write("Перевернутый массив:");      
foreach (int number in arr1)
        {
            Console.Write(number + " ");
        }
 