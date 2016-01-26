
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05Kotitehtävä4
{
    class Keyboard
    {
        public string Name { get; set; }

        public string Model { get; set; }

        public string Type { get; set; }




        public override string ToString()

        {
            return " Keyboard Name:" + Name + "  Model:" + Model + "  KeyboardType:" + Type;
        }

    }
    }