using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace SnakGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Console.LargestWindowHeight);
            Walls walls = new Walls(80, 25);

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            Menu menu = new Menu();

            FoodCreator foodCreator = new FoodCreator(40, 10, '$');
            Point food = foodCreator.CreateFood();
            int x = 100;
            int count = 0;
            int n = 0;
            string s, subkey, key;

            Player[] pr = new Player[1000] ;          
            for (int i = 0; i < pr.Length; i++)
            { pr[i] = new Player(); }
            do                               
            {
                menu.Start();
                key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        Console.Clear();
                        string text;
                        Console.WriteLine("Enter your Name: ");
                        s = Console.ReadLine(); pr[n].Fam = s;
                        pr[n].Score = count;
                        n++; 
                        StreamWriter to_file = new StreamWriter(@"ResultTable.txt", true);
                        text = pr[n].Fam + " " + pr[n].Score.ToString();
                        to_file.WriteLine(text + ";");
                        to_file.Close();
                       

                        /*
                        StreamReader from_file = new StreamReader("ResultTable.txt");
                        string text2 = from_file.ReadToEnd();
                        Console.WriteLine(text2);
                        from_file.Close();
                        Console.ReadLine();*/

                        break;
                     
                    case "2":
                        Console.Clear();
                        for (int i = 0; i < n; i++)
                        {
                            pr[i].Show();
                            Console.WriteLine();
                           
                        }
                        break;

                    case "3":
                        Console.Clear();
                        walls.Draw();
                        snake.Drow();
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
                                Thread.Sleep(x);

                                if (Console.KeyAvailable)
                                {
                                    ConsoleKeyInfo key1 = Console.ReadKey();
                                    snake.HandleKey(key1.Key);

                                }

                            }
                        
                        GameOver snake2 = new GameOver();
                        snake2.EndOfGame(count);
                        Console.ReadLine();
                        Console.Clear();
                            break;

                        }
                
                } while (key != "4") ;

                /*
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

                   }*/
            }

       } 
    }

