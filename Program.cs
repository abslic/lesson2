using System;
class Program
{//Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
 //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
 //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
 //С помощью цикла do while ограничить ввод пароля тремя попытками.
    static void Main(string[] args)
    {
        string login = "root";
        string password = "GeekBrains";

        int count = 0;
        do
        {
            Console.WriteLine("\nВведите логин: \n");
            string checkLogin = Console.ReadLine();

            Console.WriteLine("\nВведите пароль:\n ");
            string checkPassword = Console.ReadLine();


            if (login == checkLogin && password == checkPassword)
            {

                Console.WriteLine("\nДобро пожаловать\n");
                Console.ReadLine();
                break;
            }
            Console.WriteLine("\nНеверно введен логин или пароль\n");
            Console.ReadLine();
            ++count;
        } while (count < 3);



    }
}
