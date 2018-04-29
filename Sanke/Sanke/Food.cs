using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanke
{
    class Food
    {
        public Point foodPoint;
        public void CreateFood()
        {
            Random rd = new Random();
            int x = rd.Next(11, 59) * 10;
            int y = rd.Next(11, 59) * 10;
            foodPoint = new Point(x, y);
        }
    }
}
