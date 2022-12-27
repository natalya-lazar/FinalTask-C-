int CountThreeDigitElements(string[] array)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            k++;
        }
    }
    return k;
}
void CreateNewArray(string[] array1, string[] array2)
{
    int m = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[m] = array1[i];
            m++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("\b\b ");
    Console.WriteLine();
}
string[] array1 = new string[4] { "hello", "2", "world", ":-)" };
int l = CountThreeDigitElements(array1);
string[] array2 = new string[l];
CreateNewArray(array1, array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);