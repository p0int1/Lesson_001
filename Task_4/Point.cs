using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Point
    {
        int x, y;
        string letter;

        public double X
        {
            get
            {
                return x;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
        }

        public string Letter
        {
            get
            {
                return letter;
            }
        }

        public Point(int x, int y, string letter)
        {
            this.x = x;
            this.y = y;
            this.letter = letter;
        }
    }
}
