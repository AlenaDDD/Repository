using System;

namespace Итог_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnterUser();
        }
        static (string Name, string LastName, int Age, bool HasPet,
        int Number, string[] PetName, int Count, string[] FavColors) EnterUser()
        {
            (string Name, string LastName, int Age, bool HasPet, int Number, string[] PetName,
            int Count, string[] FavColors) User = (" ", " ", 0, true, 0, new string[] { }, 0, new string[] { });

            Console.WriteLine("Введите ваше имя: ");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите свою фамилию: ");
            User.LastName = Console.ReadLine();

            string age;
            int intage;

            do
            {
                Console.WriteLine("Введите ваш возраст цифрами:");
                age = Console.ReadLine();
            }
            while (CheckNum(age, out intage));

            User.Age = intage;

            Console.WriteLine("У вас есть домашнее животное? Да или Нет");
            var result = Console.ReadLine();


            if (result == "Да")
            {
                User.HasPet = true;

                string number;
                int intnumber;

                do
                {
                    Console.WriteLine("Введите количество ваших домашних питомцев: ");
                    number = Console.ReadLine();
                }
                while (CheckNum(number, out intnumber));

                User.Number = intnumber;

                User.PetName = new string[User.Number];
                Console.WriteLine("Напишите клички питомцев: ");
                for (int i = 0; i < User.Number; i++)
                {
                    User.PetName[i] = Console.ReadLine();
                }
            }
            else
            {
                User.HasPet = false;
            }

            string col;
            int intcol;
            do
            {
                Console.WriteLine("Введите количество ваших любимых цветов: ");
                col = Console.ReadLine();
            }
            while (CheckNum(col, out intcol));

            User.Count = intcol;

            Console.WriteLine("Введите названия ваших любимых цветов: ");
            User.FavColors = new string[User.Count];
            for (int i = 0; i < User.Count; i++)
            {
                User.FavColors[i] = Console.ReadLine();
            }

            Console.WriteLine("Ваше имя: {0} \nВаша фамилия: {1} \nВаш возраст {2}", User.Name, User.LastName, User.Age);

            if (User.HasPet == true)
            {
                Console.WriteLine("Количество домашних животных: {0}", User.Number);
                foreach (var pet in User.PetName)
                {
                    Console.WriteLine(pet);
                }
            }
            else
            {
                Console.WriteLine("У вас нет домашних животных");
            }

            Console.WriteLine("Ваши любимые цвета: ");
            foreach (var color in User.FavColors)
            {
                Console.WriteLine(color);
            }
            return User;
        }

        static bool CheckNum(string number, out int cornumber)
        {
            if (int.TryParse(number, out int intnumber))
            {
                if (intnumber > 0)
                {
                    cornumber = intnumber;
                    return false;
                }
            }
            {
                cornumber = 0;
                return true;
            }
        }
    }
}


      
