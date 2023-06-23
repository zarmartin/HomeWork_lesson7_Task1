
Console.WriteLine("Введите 6 чисел:");

int[] numbers = new int[6];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(numbers);

Array.Reverse(numbers);

Console.WriteLine("Результат отсортирован по убыванию:");

foreach (int i in numbers)
{
    
    Console.WriteLine(i);
}
