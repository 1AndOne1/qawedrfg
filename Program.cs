using System;
using System.Collections.Generic;

// Класс Videocard
public class Videocard
{
    public string Model { get; set; }
    public int Type { get; set; }
    public string Maker { get; set; }

    // Конструктор класса Videocard
    public Videocard(string model, int type, string maker)
    {
        Model = Model;
        Type = type;
        Maker = maker;
    }
}

// Класс для списка видеокарт
public class Videocardlist
{
    private List <Videocard> videocards;

    // Конструктор класса Videocardlist
    public Videocardlist()
    {
        videocards = new List<Videocard>();
    }

    //Добавление новой видеокарты в список
    public void AddVideocard(Videocard videocard)
    {
        videocards.Add(videocard);
    }

    // Метод для вывода списка всех видеокарт
    public void ShowVideoCards()
    {
        if (videocards.Count == 0)
        {
            Console.WriteLine("Видеокарт нет в наличии");
        }
        else
        {
            Console.WriteLine("Информация о видеокарте: ");

            foreach (Videocard videocard in videocards)
            {
                Console.WriteLine("Название видеокарты: " + videocard.Model);
                Console.WriteLine("Тип видеокарты: " + videocard.Type);
                Console.WriteLine("Производитель: " + videocard.Maker);
                Console.WriteLine();
            }
        }
    }
}

// Главный класс программы
public class Program
{
    public static void Main(string[] args)
    {
        // Создание экземпляра класса Videocardlist
        Videocardlist videocardlist = new Videocardlist();

        // Добавление видеокарт в список
        Videocard videocard1 = new Videocard("GTX", 1070, "MSI");
        Videocard videocard2 = new Videocard("RTX", 3070, "Gigabyte");
        Videocard videocard3 = new Videocard("Radeon RX", 6600, "AMD");

        videocardlist.AddVideocard(videocard1);
        videocardlist.AddVideocard(videocard2);
        videocardlist.AddVideocard(videocard3);

        // Вывод списка видеокарт
        videocardlist.ShowVideoCards();
    }
}