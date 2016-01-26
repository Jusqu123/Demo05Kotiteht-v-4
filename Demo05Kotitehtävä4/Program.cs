
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05Kotitehtävä4
{
    class Program
    {
        static void Main(string[] args)
        {
        




            Keyboard keyboard = new Keyboard { Name = " Corsair ", Model = " K70 ", Type = " Mechanic " };
            Keyboard keyboard2 = new Keyboard { Name = " zingzong ", Model = " pong ", Type = " Mechanic " };

         

            Computer computer = new Computer { Model = "Fury X", Name = "Alienware" };
            computer.addKeyboard(keyboard);
            Console.WriteLine(computer.ToString());



            Computer computer2 = new Computer { Model = "Blade", Name = "Razer" };
            computer2.addKeyboard(keyboard2);
            Console.WriteLine(computer2.ToString());


        }
        }
        }