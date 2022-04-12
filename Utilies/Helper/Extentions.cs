using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilies.Helper
{
    public static class Extentions
    {
        public static void Print(ConsoleColor color,string message)
        {
            Console.ForegroundColor= color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
       
        public enum Menu
        {
            CreateGroup=1,
            UpdateGroup,
            RemoveGroup,
            GetGroup,
            GetAllGroups
            
        }
    }
}
