using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilies.Helper;

namespace ConsoleApp_Layer_Architecture.Controllers
{
    internal class GroupController
    {
        private GroupServices groupServices;

        public GroupController()
        {
            groupServices=new GroupServices();
        }
        public void CreateGroup()
        {
            Extentions.Print(ConsoleColor.Yellow, $"Group Name: ");
            string name = Console.ReadLine();
            Extentions.Print(ConsoleColor.Yellow, $"Group Size: ");
            string groupSize = Console.ReadLine();
            int size;
            bool IsSize = int.TryParse(groupSize, out size);
        EnterName:

            if (IsSize)
            {
                Group group = new Group()
                {
                    Name = name,
                    MaxSize=size
                };

                groupServices.Creat(group);
                Extentions.Print(ConsoleColor.Green, $"{group.Name} created");

            }
            else
            {
                Console.WriteLine("Duzgen daxil et");
                goto EnterName;
            }

        }

        public void GetAllGroup()
        {
            foreach (var item in groupServices.GetAll())
            {
                Extentions.Print(ConsoleColor.Green, item.Name);
            }
        }

        public void RemoveGroup()
        {
            int id=int.Parse(Console.ReadLine());
          
            Extentions.Print(ConsoleColor.Red, groupServices.Delete(id).Name);

        }

        public void GetGroup()
        {
            string name2 = Console.ReadLine();
            Group get = groupServices.GetGroup(name2);
            Extentions.Print(ConsoleColor.Green, get.Name);
        }
    }
}
