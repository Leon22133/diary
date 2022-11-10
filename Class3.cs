using diary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Class3
    {
        static void Main()
        {

            int position = 1;

            DateTime date = DateTime.Today;
            List<Ежедневник> zametki = Menu();
            Console.SetCursorPosition(0, position);
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                else if (key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.LeftArrow)
                {
                    date = changingday(key, date);
                }

                Console.Clear();


                Console.WriteLine(date);
                foreach (Ежедневник zametka in zametki)
                {
                    if (zametka.Time == date)
                    {

                        Console.WriteLine(" " + zametka.name);
                    }
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    for (int i = 0; i < zametki.Count; i++)
                    {
                        if (zametki[i].Time == date)
                        {
                            Console.WriteLine(zametki[i].Description);
                        }
                    }
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

            }
        }
        static DateTime changingday(ConsoleKeyInfo key, DateTime date)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    date = date.AddDays(-1);
                    break;
                case ConsoleKey.RightArrow:
                    date = date.AddDays(1);
                    break;
            }

            return date;
        }


        static List<Ежедневник> Menu()
        {
            DateTime dateTime = DateTime.Today;

            Ежедневник zametka1 = new Ежедневник();
            zametka1.name = "  Сыграть в футбол с друзьями";
            zametka1.Description = "  2 часа";
            zametka1.Time = dateTime;

            Ежедневник zametka2 = new Ежедневник();
            zametka2.name = "  Пойти на пары";
            zametka2.Description = "  Ответить тему ";
            zametka2.Time = dateTime.AddDays(+2);

            Ежедневник zametka3 = new Ежедневник();
            zametka3.name = "  Лежать дома";
            zametka3.Description = " Спать и играть в плейстейшен  ";
            zametka3.Time = dateTime.AddDays(+3);

            Ежедневник zametka4 = new Ежедневник();
            zametka4.name = "   Сходить в магазин ";
            zametka4.Description = "   Купить всё по списку";
            zametka4.Time = dateTime.AddDays(+4);

            Ежедневник zametka5 = new Ежедневник();
            zametka5.name = "  Поехать к бабушке ";
            zametka5.Description = "  И помочь ей с компьютером ";
            zametka5.Time = dateTime.AddDays(+1);

            Ежедневник zametka6 = new Ежедневник();
            zametka6.name = "   Встретиться с друзьями";
            zametka6.Description = "   И пойти на квест";
            zametka6.Time = dateTime.AddDays(+5);

            Ежедневник zametka7 = new Ежедневник();
            zametka7.name = "  Съездить в Торговый центр ";
            zametka7.Description = "  Купить зимнюю куртку ";
            zametka7.Time = dateTime.AddDays(+6);

            List<Ежедневник> zametki = new List<Ежедневник>();
            zametki.Add(zametka1);
            zametki.Add(zametka2);
            zametki.Add(zametka3);
            zametki.Add(zametka4);
            zametki.Add(zametka5);
            zametki.Add(zametka6);
            zametki.Add(zametka7);


            return zametki;


        }
    }
}
    
