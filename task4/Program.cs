// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();

// -------
// Inicialization
int siz = 7;
int min = 1;
int max = 9;
int[] arr = GetArray(siz, min, max);

//-------
//Работаем
PrintArray(arr);
PrintArray(MultFirstLast(arr));

//-------
//Методы
int[] MultFirstLast(int[] someArray)
{
    int oldLength = someArray.Length;
    int newLength = (oldLength / 2) + (oldLength % 2); //Если нечетное будет +1 к половинке
    int[] res = new int[newLength];
    for (int i = 0; i < newLength; i++)
    {
        if (i != (oldLength - i - 1))
        {
            res[i] = someArray[i] * someArray[oldLength - i - 1];
        }
        else
        {
            res[i] = someArray[i];
        }
    }
    return res;
}

int[] GetArray(int length, int min = -1, int max = 1)
{
    //Генерирует массив целых чисел заданной длинны length
    //По-умолчанию числа в массиве от -1 до +1, меняется аргументами min и max
    int[] res = new int[length];
    for (int i = 0; i < length; i++) res[i] = new Random().Next(min, max + 1);
    return res;
}
void PrintArray(int[] someArray)
{
    //Выводит массив в консоль в виде [,,]
    Console.Write("[");
    for (int i = 0; i < someArray.Length - 1; i++)
    {
        Console.Write($"{someArray[i]}, ");
    }
    Console.WriteLine($"{someArray[someArray.Length - 1]}]");
}