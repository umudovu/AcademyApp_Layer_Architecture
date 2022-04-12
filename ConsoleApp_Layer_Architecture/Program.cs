using Business.Services;
using ConsoleApp_Layer_Architecture.Controllers;
using Entities.Models;
using System;
using Utilies.Helper;

namespace ConsoleApp_Layer_Architecture
{
    internal class Program

    {
        //private static GroupServices _groupServices;
        //public Program()
        //{
        //    _groupServices=new GroupServices();
        //}


        static void Main(string[] args)
        {
            Extentions.Print(ConsoleColor.Green, "Welcome");

            while (true)
            {
                GroupController groupController=new GroupController();
                Extentions.Print(ConsoleColor.Cyan, "1-Add Group \n" +
                    "2-Update Group \n" +
                    "3-Remove Group \n" +
                    "4-Get Group \n" +
                    "5-Getall Groups");


                int input;
                string num = Console.ReadLine();
                bool IsNum = int.TryParse(num, out input);

                if (IsNum && input>0 && input<7)
                {
                    switch (input)
                    {

                        case (int)Extentions.Menu.CreateGroup:
                           groupController.CreateGroup();

                            break;
                        case (int)Extentions.Menu.UpdateGroup:
                            break;
                        case (int)Extentions.Menu.RemoveGroup:
                            groupController.RemoveGroup();
                            break;
                        case (int)Extentions.Menu.GetGroup:
                            groupController.GetGroup();
                            break;
                        case (int)Extentions.Menu.GetAllGroups:
                            groupController.GetAllGroup();

                            break;
                    }
                }

            }
        }
    }
}
