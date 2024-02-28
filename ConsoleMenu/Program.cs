using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //приложение, которое может обрабатывать команды.Т.е.вы создаете меню, ожидаете ввода нужной команды, после чего выполняете действие, которое присвоено этой команде.
            //Примеры команд(Требуется 4 - 6 команд, придумать самим)
            //SetName – установить имя
            //ChangeColor - изменить цвет консоли
            //SetPassword – установить пароль
            //WriteName – вывести имя(после ввода пароля)
            //Esc – выход из программы
            //Программа не должна завершаться после ввода, пользователь сам должен выйти из программы при помощи команды.

            bool Esc = false;
            string password = null;
            string name = null;
            string backColor = null;
            int age = 0;
            

            Console.Write("Чтобы посмотреть список команд напишите 'help': "); 
            string userInput = Console.ReadLine();Console.Clear();
            if (userInput == "help")
            {
                Console.WriteLine("SetName – установить имя\nSetAge - установить возраст\nSetPassword – установить пароль\nInfo - вывести информацию о пользователе (если она есть)" +
                    "\nChangeColor - изменить цвет консоли\nEsc – выход из программы");
            }
            else
            {
                Console.WriteLine("Неизвестная команда"); Console.ReadKey(); Console.Clear();
            }

            while (Esc != true)
            {
                string s = "|КОНСОЛЬНОЕ МЕНЮ|";
                Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                Console.WriteLine(s);

                Console.Write("\nВведите команду: ");
                userInput = Console.ReadLine();
                switch(userInput)
                {
                    case "SetName":
                        Console.Write("Установить имя пользователя: ");
                        name = Console.ReadLine();
                        Console.Write("Имя пользователя установленно"); Console.ReadKey(); Console.Clear();
                        break;

                    case "SetPassword":
                        Console.Write("Установить пароль: ");
                        password = Console.ReadLine();
                        Console.Write("Пароль установлен"); Console.ReadKey(); Console.Clear();
                        break;

                    case "SetAge":
                        Console.Write("Установить возраст пользователя: ");
                        age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Возраст пользователя установлен"); Console.ReadKey(); Console.Clear();
                        break;

                    case "Info":
                        Console.Write("Введите пароль:");
                        string enteredPassword = Console.ReadLine();
                        if (enteredPassword == password)
                        {
                            Console.WriteLine("Доступ разрешен.");
                            Console.Write($"Имя пользователя - {name}, возраст пользователя - {age}"); Console.ReadKey(); Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Неверный пароль. Доступ запрещен.");
                            Console.WriteLine("Если у вас нет пароля напишите 'SetPassword' чтобы установить пароль");
                        }
                        break;

                    //case "ChangeColor":
                      // Console.WriteLine("Выберите цвет");
                        //switch (backColor)
                        //{
                            //case "green":
                                //Console.BackgroundColor = ConsoleColor.Green;
                                //break;

                            //case "red":
                                //Console.BackgroundColor = ConsoleColor.DarkRed;
                                //break;
                        //}
                        //break;

                    case "Esc":
                        Esc = true; Console.Clear();
                        break;
                    default: Console.WriteLine("Неизвестная команда");
                        return;
                }
            }
            
        }
    }
}
