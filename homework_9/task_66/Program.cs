// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt (строковое сообщение)
{
  Console.Write(сообщение);
  результат int = Convert.ToInt32(Console.ReadLine());
  вернуть результат;
}

int SumOfElements (int n, int m)
{
  если (n == m) вернуть n;
  иначе вернуть SumOfElements(n + 1, m) + n;
}

int n = Подсказка («Введите N:»);
int m = Подсказка («Ввод M:»);

Console.WriteLine(СуммаЭлементов(n, m));
