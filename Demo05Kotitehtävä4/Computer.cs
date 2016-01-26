
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05Kotitehtävä4
{
    class Computer
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public List<Keyboard> Keyboards { get; }

        public Computer()

        {
            Keyboards = new List<Keyboard>();
        }


        public void addKeyboard(Keyboard keyboard)
        {
            Keyboards.Add(keyboard);
        }


        public override string ToString()


        {
            string sComputer = " Computer Name: " + Name + " Model: " + Model + "\n";
            foreach (Keyboard keyboard in Keyboards)

            {
                sComputer += keyboard.ToString() + "\n";
            }
            return sComputer;
         }
         }
         }