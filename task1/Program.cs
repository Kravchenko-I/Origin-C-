// Задача 32: Напишите программу замены элементов
// массива:положительные замените 
// на соответствующие отрицательные,и наоборот.
// [-4,-8,8,2] -> [4,8,-8,-2]
Console.Clear();

int size = InputNumber("Введите размер массива");
int min = InputNumber ("Введите минимальное значение в массиве");
int max = InputNumber ("Введите максимальное значение в массиве");
int[] array = GetArray(size,min,max);


Console.Clear();
PrintArray(array);
array = ChangeSign(array);
PrintArray(array);

int[] GetArray(int length, int min = -1, int max = 1)
{
    int[] res = new int[length];
    for(int i = 0; i < length; i++) res[i] = new Random().Next(min,max);
    return res;
}
int[] ChangeSign(int[] someArray)
{
    int[] res = someArray ;
    for (int i =0; i <= res.Length -1;i++) res[i] *= (-1);
    return res;
}
void PrintArray(int[] someArray)
{
    Console.Write("[");
    for (int i = 0; i <= someArray.Length -1;i++)
    {
        Console.Write($"{someArray[i]}, ");
    }
    Console.WriteLine($"{someArray[someArray.Length -1]}]");
}
int InputNumber(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}