// Задача 64: Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

Console.Clear();
Console.WriteLine("Программа выдаёт все чётные натуральные числа в промежутке от M до N с помощью рекурсии");

int first = 0;
first = AskForInput("меньшее");
int second = AskForInput("большее");

System.Console.WriteLine("\nВсе ЧЁТНЫЕ натуральные числа в промежутке от " + first + " до " + second + ": ");
PrintAllEvenNumbers(first, second);


//////////////////////////// функции ////////////////////////////////////////////////////


int AskForInput(string str)
{
    while (true)
    {
        Console.Write($"\nНапишите {str} натуральное число интервала :");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number > 0 && number > first) 
            {
                return number;
                break;
            }
            else Console.WriteLine($"Некорректно указано {str} натуральное число интервала!\n");
        }
        else Console.WriteLine($"Некорректно указано {str} натуральное число интервала!\n");
    }
}

void PrintAllEvenNumbers(int first, int second)
{
    first++;
    if(first == second) return;
    else
    {
        if(first % 2 == 0) System.Console.Write(first + "; ");
        PrintAllEvenNumbers(first, second);
    }
}

