int [] array = {1, 2, 5, 0, 10, 34};
int size = array.Length;
void ShowArray(int[] arr, int size)
{
    if (size == 0)
    {
        Console.Write(arr[size]);
        return;
    }
    Console.Write(arr[size] + " ");
    ShowArray(arr, size - 1);
}
ShowArray (array, size - 1);