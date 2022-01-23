using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.LargestWindowHeight);
          

            Walls walls = new Walls(80, 25);
            walls.Draw();



            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            int count = 0 ;

            FoodCreator foodCreator = new FoodCreator(60, 15, '$');
            Point food = foodCreator.CreateFood();
            food.draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.isHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    count++;
                    food = foodCreator.CreateFood();
                    food.draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);

                }

            }

            GameOver snake2 = new GameOver();
            snake2.EndOfGame(count);
            Console.ReadLine();
        }

       
    }
}
