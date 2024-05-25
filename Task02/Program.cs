/*
Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
*/

/*
Ранее никогда не был знаком с этой функцией. Очень тяжело описывать что-либо программно, когда не до конца понимаешь суть явления.
Очень надеюсь, что сделал все правильно, не нагородив ошибок. Рекурсивные вызовы тут просто CRAZY!!!
 */


int CalcAkkermanFunc(int nValue, int mValue) //вычисление функции Акермана
{
    if (nValue < 0 || mValue < 0) return 0; //условие выхода
    if (nValue == 0) return mValue + 1;
    if (mValue == 0) return CalcAkkermanFunc(nValue - 1, 1);
    return CalcAkkermanFunc(nValue - 1, CalcAkkermanFunc(nValue, mValue - 1));
}

void CheckCorrectInput(string input) //впечатлило, что с Try.Parse выходит кратко и эффективно
{
    if (int.TryParse(input, out int _) == false) //проверяем ввод на числовое значение, итог проверки присваиваем временной переменной, завершаем код, еслии введено не число
    {
        Console.WriteLine("Введено не числовое значение, программа завершает работу!");
        Environment.Exit(0); //это я подсмотрел в сети, по кодам не разбирался, но понял что 0 - успешное завершение, поэтому указал его
    }
}

int GetNumN()
{
    Console.WriteLine("Введите натуральное N, это должно быть число! Завершите ввод нажатием Enter...");
    string? inputN = Console.ReadLine(); //знак впороса подавляет вывод предупреждений о пустом значении, подсмотрел в сети
    CheckCorrectInput(inputN);
    int numberN = int.Parse(inputN);
    return numberN;
}

int GetNumM()
{
    Console.WriteLine("Введите натуральное M, это должно быть число! Завершите ввод нажатием Enter...");
    string? inputM = Console.ReadLine();
    CheckCorrectInput(inputM);
    int numberM = int.Parse(inputM);
    return numberM;
}

int numberN = GetNumN();
int numberM = GetNumM();

int result = CalcAkkermanFunc(numberN, numberM);
Console.WriteLine("Результат вычисления функции Аккермана: " + result);