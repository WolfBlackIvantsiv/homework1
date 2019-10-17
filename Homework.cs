using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{

    class User
    {
        public string name;
        public int age;
        public string address;
    }

    class Homework
    {
        private const int maxUserCount = 10;
        private static int currentUserCount;

        private static User[] users = new User[maxUserCount];


        Homework()
        {
            currentUserCount = 0;
            for(int i = 0; i < maxUserCount; i++)
            {
                users[i] = new User();
            }
        }

        public static bool IsEven(int number)
        {
            bool returnB = false;
            if (number % 2 == 0)
            {
                returnB = true;
            }
            return returnB;
        }

        public static void WriteToNumber(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static User NewUser()
        {
            User user = new User();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===================================================================================");
            Console.WriteLine("-                 User registering                       ");
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("Please enter your name");
            user.name = Console.ReadLine();  // Read naame
            Console.WriteLine("________________________________________________________");
            Console.WriteLine(user.name + ", enter your age, please!");
            user.age = Convert.ToInt32(Console.ReadLine()); // Read age
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("Please enter your address(hometown)");
            user.address = Console.ReadLine(); // Read address
            Console.WriteLine("________________________________________________________");
            Console.WriteLine("===================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            if (currentUserCount < maxUserCount)
            {
                users[currentUserCount] = user;
                currentUserCount++;
            }
            return user;
        }

        public static void ShowUserInfo(int id)
        {
            if(id <= currentUserCount)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("===================================================================================");
                Console.WriteLine("-                 User Info                       ");
                Console.WriteLine("________________________________________________________");
                Console.WriteLine("Name: " + users[id].name);
                Console.WriteLine("Age: " + users[id].age);
                Console.WriteLine("Address: " + users[id].address);
                Console.WriteLine("________________________________________________________");
                Console.WriteLine("===================================================================================");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public static void ShowAllUsers()
        {
            for(int i = 0; i < currentUserCount; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("===================================================================================");
                Console.WriteLine("-                 User Info                       ");
                Console.WriteLine("________________________________________________________");
                Console.WriteLine("Name: " + users[i].name);
                Console.WriteLine("Age: " + users[i].age);
                Console.WriteLine("Address: " + users[i].address);
                Console.WriteLine("________________________________________________________");
                Console.WriteLine("===================================================================================");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
