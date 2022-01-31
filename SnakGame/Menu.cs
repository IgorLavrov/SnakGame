using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakGame
{
    class Menu
    {
        public void Start()
        {

          
            Console.ForegroundColor = ConsoleColor.White;

           
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("----------------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Игра 'Змейка'");
           
            Console.ForegroundColor = ConsoleColor.Blue;
        

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***Menu***");
            Console.WriteLine("1 - Make  a record ");
            Console.WriteLine("2 - Show Result");
            Console.WriteLine("3 - Play"); 
            Console.WriteLine("4 - Speed increase");
            Console.WriteLine("5 - Exit");
            Console.WriteLine();
            Console.WriteLine(" Your Choose...");
 

            Console.ForegroundColor = ConsoleColor.Green;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------");

            Console.ForegroundColor = ConsoleColor.Green;
         
           
           


        }
    }
}
