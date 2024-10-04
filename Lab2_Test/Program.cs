using Lab2_Test;

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
LabTask task = new LabTask();
Console.WriteLine($"НОД = {task.Euclid(a, b)}");
