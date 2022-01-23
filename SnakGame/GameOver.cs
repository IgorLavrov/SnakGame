using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakGame
{
    class GameOver
    {
        public  void EndOfGame(int score)
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("Game Over", xOffset + 1, yOffset++);
            WriteText("Your score : " + score, xOffset + 2, yOffset++);
            WriteText("Author:  Targv21", xOffset + 3, yOffset++);
            WriteText("============================", xOffset, yOffset++);
        }

        public  void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }




    }
}
