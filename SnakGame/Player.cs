using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakGame
{
  public  class Player
 
        {
            string fam;     // поле фамилия
            string status;  // поле статус
            int score;        // поле возраст 

            public Player() { }
            public Player(string _fam)
            {
                fam = _fam;
            }
            public string Fam  //свойство для поля фамилия
            {
                set { if (fam == null) fam = value; }     //код - установка значения поля фамилия
                get { return fam; }                     //код - чтение значения поля  фамилия
            }
            public int Score        //свойство для поля возраст
            {
                set                    //код - установка значения полей возраст и статус
                {
                    score = value;
                    if (score < 2) status = " Child";
                    else if (score < 7) status = "Scholar";
                    else if (score < 12) status = " Mature";
                    else status = "Expert";

                }
                get { return (score); }       //код - чтение значения поля  возраст
            }
            public string Status  //свойство для поля статус
            {
                get { return status; }    // код - чтение поля статус
            }
          
            public void Show()  // метод вывода значений полей
            {
                Console.WriteLine("Surname " + fam);
                Console.WriteLine("Score " + score);
                Console.WriteLine("Status " + status);


            }
        }

    }



