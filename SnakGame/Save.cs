using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakGame
{
    public class Save
    {
       
            public string username;
            public static int rate;

            public Save()
            {

            }

            public Save(string username)
            {
                this.username = username;
            }

            public static void Rate()
            {
            //make a list and sort method
            rate++;
            Console.WriteLine("Очки: " + rate, 81, 1);

            }
            public static void ScoresSave(string name, int score)
            {
                string text;
                StreamWriter use = new StreamWriter(@"ResultTable.txt", true);
                text = score + " " + name;
                use.WriteLine(text);
                use.Close();
            }

            public static void ShowRate(int xOffset, int yOffset)
            {
                using (StreamReader usefrom = new StreamReader(@"ResultTable.txt"))
                {
                    List<string> list = new List<string>();
                    list = File.ReadAllLines(@"ResultTable.txt").ToList();
                    var sortedUsers = from u in list
                                      orderby u descending
                                      select u;
                    foreach (var u in sortedUsers)
                    {
                    Console.WriteLine(u, xOffset, yOffset++);
                    }
                }
            }
        }
}
