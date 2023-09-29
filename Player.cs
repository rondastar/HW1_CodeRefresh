using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_CodeRefresh
{
    internal class Player
    {
        string name;
        int number;

        public Player(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        public string Name { get => name; set => name = value; }
        public int Number { get => number; set => number = value; }

        public override string ToString()
        {
            return Name + " #" + Number;
        }
    } // class Player
} // namespace
