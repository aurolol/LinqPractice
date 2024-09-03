using System.Threading.Channels;

List<int> numbers = new List<int> { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };

Console.WriteLine("↓ Çift olan sayılar ↓");

var evenNumbers = numbers.Where(x => x % 2 == 0);

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("\n↓ Tek olan sayılar ↓");

var oddNumbers = numbers.Where(x => x % 2 != 0);

foreach (var number in oddNumbers)
{

    Console.WriteLine(number);
}

Console.WriteLine("\n↓ Negatif olan sayılar ↓");

var negativeNumbers = numbers.Where(x => x < 0);

foreach (var number in negativeNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("\n↓ Pozitif olan sayılar ↓");

var positiveNumbers = numbers.Where(x => x > 0);

foreach (var number in positiveNumbers)
{
    Console.WriteLine(number);
}

Random random = new Random();

List<int> numbers2 = new List<int>();

for (int i = 0; i < 10; i++)
{
    numbers2.Add(random.Next(-50, 51));
}

Console.WriteLine("\n↓ 15'ten büyük ve 22'den küçük sayılar ↓");

numbers2.Where(x => (x > 15 && x < 22)).ToList().ForEach(x => Console.WriteLine(x));

Console.WriteLine("\n↓ Listedeki her bir sayının karesi ↓");

var squaredNumberList = numbers2.Select(num => num * num).ToList();

foreach (var item in squaredNumberList)
{
    Console.WriteLine(item);
}
