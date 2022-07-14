using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int rubToUsd = 55, usdToRub = 50, rubToEuro = 65, euroToRub = 60;
            int rub;
            int usd;
            int euro;
            string userInput;
            int currencyCount;

            Console.Write("Введите кол-во ваших рублей: ");
            rub = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во ваших долларов: ");
            usd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во ваших евро: ");
            euro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1 - обменять рубли на доллары");
            Console.WriteLine("2 - обменять доллары на рубли");
            Console.WriteLine("3 - обменять рубли на евро");
            Console.WriteLine("4 - обменять евро на рубли");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на доллары");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToInt32(Console.ReadLine());
                    if (rub >= currencyCount)
                    {
                        rub -= currencyCount;
                        usd += currencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно рублей");
                    }
                    break;
                case "2":
                    Console.WriteLine("Обмен долларов на рубли");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToInt32(Console.ReadLine());
                    if (usd >= currencyCount)
                    {
                        usd -= currencyCount;
                        rub += currencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно рублей");
                    }
                    break;
                case "3":
                    Console.WriteLine("Обмен рублей на евро");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToInt32(Console.ReadLine());
                    if (rub >= currencyCount)
                    {
                        rub -= currencyCount;
                        euro += currencyCount / rubToEuro;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно рублей");
                    }
                    break;
                case "4":
                    Console.WriteLine("Обмен евро на рубли");
                    Console.Write("Сколько вы хотите обменять: ");
                    currencyCount = Convert.ToInt32(Console.ReadLine());
                    if (euro >= currencyCount)
                    {
                        euro -= currencyCount;
                        rub += currencyCount * euroToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно рублей");
                    }
                    break;
            }
            Console.WriteLine("Ваш баланс " + rub + " рублей, " + usd + " долларов, " + euro + " евро");
            }
    }
}
