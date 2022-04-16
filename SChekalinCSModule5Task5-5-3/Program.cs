using System;

namespace SChekalinCSModule5Task5_5_3
{
    class MainClass
    {
        static void Main()
        {
            (string m_firstName, string m_lastName, int m_age) main_User; //Сохраняем ФИО, возраст
            string[] Pets;                                                //Сохраняем питомцев
            string[] Colors;                                              //Сохраняем цвета
            
            main_User = EnterUser();                                      //Вводим ФИО, возраст

            Pets = GetArrayPets();                                        //Вводим питомцев

            Colors = GetArrayColors();                                    //Вводим любимые цвета

            Console.WriteLine($"{main_User.m_firstName} {main_User.m_lastName}, возраст {main_User.m_age}"); // Вывод на экран ФИО, возраст

            if (Pets.Length > 0)                                                                             // Вывод на экран питомцев
            {
                Console.WriteLine("Питомцы:");
                foreach (string p_name in Pets)
                {
                    Console.Write(p_name + " ");
                }
                Console.WriteLine();                                                                         //перевод на новую строку
            }
            else
            {
                Console.WriteLine("Нет питомцев");
            }


            if (Colors.Length > 0)                                                                          // Вывод на экран цветов
            {
                Console.WriteLine("Любимые цвета:");
                foreach (string c_name in Colors)
                {
                    Console.Write(c_name + " ");
                }
                Console.WriteLine();                                                                        //перевод на новую строку
            }
            else
            {
                Console.WriteLine("Нет любимых цветов");
            }

        }
       static (string firstName, string lastName, int age) EnterUser()  //Метод для ввода ФИО, возраста
        {
            (string firstName, string lastName, int age) User;
            Console.WriteLine("Введите имя:");
            User.firstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            User.lastName = Console.ReadLine();

            string ageStr;                                          //Проверка
            int intAge = 0;                                         //корректности
                                                                    //ввода
            do                                                      //возраста
            {                                                       //
                Console.WriteLine("Введите возраст цифрами:");
                ageStr = Console.ReadLine();
            } while (CheckNum(ageStr, ref intAge));
            User.age = intAge;
            return User;
        }
        static string[] GetArrayPets()                           //Метод для ввода питомцев
        {
            string numStr;                                          //Проверка
            int numInt = 0;                                         //корректности
                                                                    //ввода
            do                                                      //кол-ва питомцев
            {                                                       //
                Console.WriteLine("Введите количество питомцев цифрами:");
                numStr = Console.ReadLine();
            } while (CheckNumPet(numStr, ref numInt));
            
            string[] result = new string[numInt];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Введите имя питомца {i + 1}:");
                result[i] = Console.ReadLine();
            }
            return result;
        }
        static string[] GetArrayColors()                         //Метод для ввода цветов
        {
            string numStr;                                          //Проверка
            int numInt = 0;                                         //Проверка
                                                                    //корректности
            do                                                      //ввода
            {                                                       //кол-ва любимых цветов
                Console.WriteLine("Введите количество любимых цветов цифрами:");
                numStr = Console.ReadLine();
            } while (CheckNumPet(numStr, ref numInt));

            string[] result = new string[numInt];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Введите любимый цвет {i + 1}:");
                result[i] = Console.ReadLine();
            }
            return result;
        }
        static bool CheckNum(string number, ref int corrnumber)         //Метод проверки корректности введенного возраста
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            return true;
        }
        static bool CheckNumPet(string number, ref int corrnumber)         //Метод проверки корректности введенного количества питомцев/цветов
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum >= 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            return true;
        }

    }
}
