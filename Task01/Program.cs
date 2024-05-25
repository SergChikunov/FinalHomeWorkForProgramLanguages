/*
ДЗ семинар 7. Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.
 */

void ShowNumbersFromNtoM(int valueN, int valueM) //рекурсивная функция
{
    int tmpValue = valueN - valueM; //определяем разность двух чисел, для понимания в каком направлении двигаться - на возрастание или убывание
    if (tmpValue > 0)
    {
        ShowNumbersFromNtoM(valueN, ++valueM); // если N большее, тогда значение M последовательно увеличиваем в рекурсивном вызове
        Console.Write($"{valueM}\t");
    }
    else if (tmpValue < 0) //если N меньшее, тогда значение M последовательно уменьшаем в рекурсивном вызове
    {
        ShowNumbersFromNtoM(valueN, --valueM);
        Console.Write($"{valueM}\t");
    }
    else return; //а это условие выхода, собственно, если оба условия выше не соблюдаются, то выходим из метода
}

void CheckCorrectInput(string input) //впечатлило, что с Try.Parse выходит кратко и эффективно
{
    if (int.TryParse(input, out int _) == false) //проверяем ввод на числовое значение, итог проверки присваиваем временной переменной, завершаем код, еслии введено не число
    {
        Console.WriteLine("Введено не числовое значение, программа завершает работу!");
        Environment.Exit(0); //это я подсмотрел в сети, по кодам не разбирался, но понял что 0 - успешное завершение, поэтому указал его
    }
}

int GetNum()
{
    Console.WriteLine("Введите натуральное N, это должно быть число! Завершите ввод нажатием Enter...");
    string? input = Console.ReadLine(); //знак впороса подавляет вывод предупреждений о пустом значении, подсмотрел в сети
    CheckCorrectInput(input);
    int number = int.Parse(input);
    return number;
}


int numberN = GetNum();
int numberM = GetNum();

ShowNumbersFromNtoM(numberN, numberM);
Console.Write(numberM); //по условию задачи необходимо вывести весь диапазон между N и M, эта строка добавляет значение M в конец строки