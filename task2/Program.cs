// Задача 33: Задайте массив.Напишите программу, которая
// определяет, присутствеут ли заданное число в массиве.
// 4; массив[6, 7, 19, 345, 3]->Нет
// - 3; массив[6, 7, 19, 345, 3,]->Да

int siz, min, max, num;
int[] array;
Console.Clear();


siz = InputNumber("Введите размер массива");
min = InputNumber ("Введите минимальное значение в массиве");
max = InputNumber ("Введите максимальное значение в массиве");
num = InputNumber("Введите число которое нужно найти в массиве");

array = GetArray(siz,min,max);
PrintArray(array);
Console.Write($"Число {num} в массиве ");
if(CheckArrayNum(array, num)) Console.WriteLine ("Присутствует");
else Console.WriteLine("Отсутствует");

bool CheckArrayNum(int[] someArray, int checkNum)
{
    bool flag = false;
    for (int i = 0; i <= someArray.Length -1;i++)
    if (someArray[i] == checkNum) flag = true;
    return flag;
} 

int[] GetArray(int length, int min = -1, int max = 1)
{
    int[] res = new int[length -1];
    for(int i = 0; i < length; i++) res[i] = new Random().Next(min,max +1);
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