/*
Семинар 7. Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
*/

int[] CreateAndFillArrayRndInt() //создание массива и заполнение его случайными числами
{
    Console.WriteLine("Укажите размер массива и нажмите Enter...");
    string? input = Console.ReadLine(); //знак ? подавляет вывод предупреждения о пустом значении
    CheckCorrectInput(input); //как подавить вывод предупреждения при вызове метода я не знаю, найти не смог
    int size = int.Parse(input);

    Console.WriteLine("Укажите минимальное значение генерации случайного числа и нажмите Enter...");
    string? minValue = Console.ReadLine();
    CheckCorrectInput(minValue);
    int min = int.Parse(minValue);

    Console.WriteLine("Укажите максимальное значение генерации случайного числа и нажмите Enter...");
    string? maxValue = Console.ReadLine();
    CheckCorrectInput(maxValue);
    int max = int.Parse(maxValue);

    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void CheckCorrectInput(string input) //метод проверки на числовое значение, впечатлило, что кратко и эффективно
{
    if (int.TryParse(input, out int _) == false) //проверяем ввод на числовое значение, итог проверки присваиваем временной переменной, завершаем код, если введено не число
    {
        Console.WriteLine("Введено не числовое значение, программа завершает работу!");
        Environment.Exit(0); //подсмотрел в сети такую возможность, только с кодами не разбирался, но как я понял - 0 успешное завершение кода, поэтому его указал
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

void ShowArrayByRecursion(int[] array, int lastIndex) // рекурсивная функция
{
    if (lastIndex < 0) return; //условие выхода из рекурсии
    else
    {
        Console.Write($"{array[lastIndex], 5}");
        ShowArrayByRecursion(array, --lastIndex); //рекурсивный вызов
    }
}

int[] arr = CreateAndFillArrayRndInt();
Console.WriteLine("Исходный массив:");
PrintArray(arr);
int lastIndex = arr.Length - 1;
Console.WriteLine("\n\nВывод массива в обратном порядке с использованием рекурсии:");
ShowArrayByRecursion(arr, lastIndex);