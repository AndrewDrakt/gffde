using Практическая_4;
using System.Globalization;
using System.Data;

/*static void up(string znach)
{

}
static void down(string znach)
{

}
static void right(string znach)
{
    int[] pos = new int[5]
        {1,2,3,4,5};
    pos++;
    Console.Clear();
    Console.WriteLine(znach[pos]);
}*/
/*static void left(string znach)
{
    int pos = 2;
    pos++;
    Console.Clear();
    Console.WriteLine(znach[pos]);
}*/
Zametka zam1 = new Zametka();
zam1.Name = "Cделать C#";
zam1.Discruption = "Сделать 4ю практическую по С#";
zam1.EndDate = new DateTime(2022, 10, 22);

Zametka zam2 = new Zametka();
zam2.Name = "Поговорить с Софией Алексеевной";
zam2.Discruption = "Спросить как у неё дела, как прошёл её день и сделать ей комплимент";
zam2.EndDate = new DateTime(2022, 10, 23);

Zametka zam3 = new Zametka();
zam3.Name = "Сделать математику";
zam3.Discruption = "Сделать номера 1,2,5";
zam3.EndDate = new DateTime(2022, 10, 24);

Zametka zam4 = new Zametka();
zam4.Name = "Вклеить лист";
zam4.Discruption = "Вклеить листок в тетрадь";
zam4.EndDate = new DateTime(2022, 10, 25);

Zametka zam5 = new Zametka();
zam5.Name = "Спорт";
zam5.Discruption = "Сделать зарядку утром";
zam5.EndDate = new DateTime(2022, 10, 26);

Zametka[] zametki = new Zametka[] { zam1, zam2, zam3, zam4, zam5 };

int position = 1;
DateTime date = new DateTime(2022, 10, 25);
while (clavisha.Key != ConsoleKey.Escape)
{
    ConsoleKeyInfo clav = Console.ReadKey();

    while (clav.Key != ConsoleKey.Enter)
    {

        if (clav.Key == ConsoleKey.LeftArrow)
        {
            date = date.AddDays(-1);
        }
        else if (clav.Key == ConsoleKey.RightArrow)
        {
            date = date.AddDays(1);
        }
        if (clav.Key == ConsoleKey.UpArrow)
        {
            position--;
        }
        else if (clav.Key == ConsoleKey.DownArrow)
        {
            position++;
        }
        Console.Clear();

        Console.WriteLine(date.Date);
        foreach (Zametka item in zametki)
        {
            if (item.EndDate == date)
            {
                Console.WriteLine("  " + item.Name);
            }
        }
        Console.SetCursorPosition(0, position);
        Console.WriteLine("->");
        
        clav = Console.ReadKey();
    }
    Zametka[] zametki2 = zametki.Where(item => item.EndDate == date).ToArray();
    Console.Clear();
    Console.WriteLine(zametki2[position-1].Discruption);
    clavisha = Console.ReadKey();
}

/*position--; //position = position - 1*/
/*Console.WriteLine("  ", zam2.EndDate);
Console.WriteLine("  ", zam3.EndDate);
Console.WriteLine("  ", zam4.EndDate);
Console.WriteLine("  ", zam5.EndDate);*/


/*position++;
Console.WriteLine("->");
Console.SetCursorPosition(0, position);
Console.WriteLine("  ", zam1.EndDate);
Console.WriteLine("  ", zam2.EndDate);
Console.WriteLine("  ", zam3.EndDate);
Console.WriteLine("  ", zam4.EndDate);
Console.WriteLine("  ", zam5.EndDate);*/