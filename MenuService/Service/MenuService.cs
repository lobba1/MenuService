using MainApp.Service;
using MenuService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Services
{
    internal static class MenuService

        }


        private static void listAllUsersMenu()
        {
            var user = new User();
            Console.Clear();
            Console.WriteLine("-- CREATE NEW USER --");

            Console.WriteLine("Enter first name: ");
            user.FirstName = Console.ReadLine()??"";

            Console.WriteLine("Enter last name: ");
            user.LastName = Console.ReadLine() ?? "";

            Console.WriteLine("Enter e-mail adress: ");
            user.Email = Console.ReadLine() ?? "";

            Console.WriteLine("Enter phone number: ");
            user.PhoneNumber = Console.ReadLine() ?? "";

            var response = _userService.CreateUser(user);
            Console.WriteLine(response.Messgae);
        }
        {
        private static void (....)
        {
            Environment.Exit(0);
        }

        {
            private static readonly UserService _userService = new UserService();
        

        private static void CreateUserMenu()
        {
            Console.Clear();
        }
        private static bool MenuOptions(string selectedOption)
        {
            if (int.TryParse (selectedOption, out int option))
            {
                switch (option)
                {
                    case 1:
                        CreateUserMenu();   
                        break;

                    case 2:
                        listAllUsersMenu();
                        break;

                    case 0:
                        ExitApplicationMenu();
                        break;

                    default:
                        return false;

                    

                }
                return true;
            }
            return false;
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Create New User");
            Console.WriteLine("2. List All Users");
            Console.WriteLine("0. Exit");

            Console.WriteLine("Enter an option");
            var result = MenuOptions(Console.ReadLine() ?? "");
            if (!result)
            {
                Console.WriteLine("Invalid option selected.");
            }
        }

    }
}