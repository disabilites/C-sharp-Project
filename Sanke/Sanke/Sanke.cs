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
    class Snake
    {
        public LinkedList<Point> ls_point = new LinkedList<Point>();
        public Point headPoint = new Point(0, 0);
        public Food food = new Food();
        public int count = 0;

        public void Init()  //初始化蛇
        {
            for (int i = 450; i < 500; i += 10)
            {
                Point point = new Point(i, 150);
                ls_point.AddLast(point);
            }
            headPoint = ls_point.First.Value;
        }

        public void Clear()
        {
            ls_point.Clear();
        }

        public void Move(int direction)     //1向上，-1向下，2向左，-2向右；
        {
            int x = 0, y = 0;
            switch (direction)
            {
                case 1: y -= 10; break;
                case -1: y += 10; break;
                case 2: x -= 10; break;
                case -2: x += 10; break;
            }
            Point pre_point = ls_point.First.Value;
            Point next_point = new Point(pre_point.X + x, pre_point.Y + y);
            ls_point.AddFirst(next_point);
            headPoint = ls_point.First.Value;
            if (!IsEat())
                ls_point.RemoveLast();//删除尾节点
            else
                food.CreateFood();

        }
        private bool IsEat()
        {
            if (headPoint.Equals(food.foodPoint))
            {
                count++;
                return true;
            }
            else { return false; }
        }

        public bool Alive()
        {
            int i = 0;
            Point p = ls_point.First.Value;
            foreach (Point sp in ls_point)
            {
                if (sp.Equals(p))
                {
                    i++;
                }
            }
            if (i > 1)      //判断是否撞到自己
            {
                return false;
            }

            else if (headPoint.X > 100 && headPoint.X < 600 && headPoint.Y > 100 && headPoint.Y < 600) //判断是否撞墙
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
