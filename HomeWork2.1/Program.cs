// Является ли день недели выходным?

Console.WriteLine("Введите порядковое число дня недели: ");
int x = int.Parse(Console.ReadLine());
int[] array = {0, 1, 2, 3, 4, 5, 6, 7};
int a = x;
int index = array[a]-1;
array[a] = array[x];

if (array[x]<array[6])
{
    Console.WriteLine("Сегодня будний день(");
}
else
{
    Console.WriteLine("Сегодня ВЫХОДНОЙ!");
}