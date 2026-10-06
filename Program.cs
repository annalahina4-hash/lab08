int lessonNumber = 5;
int totalLessons = 1;
while (lessonNumber  >= totalLessons)
{
    Console.WriteLine($"пара{lessonNumber}");
    lessonNumber--;
}
Console.WriteLine("пара закончилась");


Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
int count = 0;
while (grade != -1)
{
    count++;
    Console.WriteLine($"Оценка принята: {grade}");
    grade = int.Parse(Console.ReadLine());
}
Console.WriteLine($"счет оценок{count}");
Console.WriteLine("Ввод завершен");

int summ = 0;
int countt = 0;
int max = 0;
Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int gradee = int.Parse(Console.ReadLine());

if (gradee != -1) {
    max = gradee;
}
while (gradee != -1)
{
    summ += gradee;
    countt++;

    if (gradee > max)
    {
        max = gradee;
    }
    gradee = int.Parse(Console.ReadLine());
}
if (count > 0)
{
    Console.WriteLine($"Средний балл: {(double)summ / count}");
}
else
{
    Console.WriteLine("Оценок не было введено");
}

//4
string correctPassword = "qwerty123";
int neydah = 0;
while (true)
{
    Console.WriteLine("Введите пароль от личного кабинета:");
    string password = Console.ReadLine();

    if (password == correctPassword)
    {
        Console.WriteLine("Доступ разрешен");
        break;
    }
    neydah++;
    Console.WriteLine("Неверный пароль, попробуйте снова");
    Console.WriteLine($"{neydah}");
}

//5
string answer;
do
{
    Console.WriteLine("Введите дату посещения(например, 01.09)");
    string date = Console.ReadLine();
    Console.WriteLine($"Запись добавлена: {date}");

    Console.WriteLine("Добавить еще одну запись? (да/нет) ");
    answer = Console.ReadLine();
} while (answer == "да");

Console.WriteLine("Дневник сохранен");

//самостоятельные
//A
int N = 7;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{N} x {i} = {N * i}");
}

//Б
int couunt = 0;
while (true)
{
    Console.Write("Введите имя ученика (или 'конец' для завершения): ");
    string nam = Console.ReadLine();
    if (nam.ToLower() == "конец")
    {
        break; 
    }

    couunt++;
}
Console.WriteLine($"Всего введено имён: {couunt}");


//1
 int e = 5;
for (int u = e; u >= 1; u--)
{
  Console.WriteLine(u);
}
Console.WriteLine("Старт!");
//5
string correctCode = "1234";
while (true)
{
    Console.Write("Введите код домофона: ");
    string userCode = Console.ReadLine();

    if (userCode == correctCode)
    {
        Console.WriteLine("Дверь открыта");
        break;  
    }
    else
    {
        Console.WriteLine("Неверный код, попробуйте ещё раз.");
    }
}