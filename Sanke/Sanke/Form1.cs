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
    public partial class Form1 : Form
    {
        Snake snake = new Snake();
        Food food = new Food();
        int dirction;
        bool Start = false;
        //Color[] color = { Color.Yellow, Color.Blue, Color.Green };  //存储食物颜色
        //Random chooseColor = new Random();                          //创建随机数选择食物颜色
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!Start)                                 //如果蛇死亡，显示死亡界面
            {
                timer1.Enabled = false;                //停止计时器
            }
            else
            {
                timer1.Enabled = true;                           //启动计时器
                Graphics graphics = this.CreateGraphics();       //生成画板
                Pen pen = new Pen(Color.Black);                  //生成画笔
                graphics.DrawRectangle(pen, 100, 100, 500, 500); //创建矩形（游戏界面）
                SolidBrush brush_black = new SolidBrush(Color.Black);
                SolidBrush brush_red = new SolidBrush(Color.Red);
                graphics.FillEllipse(new SolidBrush(Color.Blue), new Rectangle(food.foodPoint, new Size(10, 10))); //生成食物
                foreach (Point point in snake.ls_point)
                {
                    graphics.FillEllipse(brush_red, new Rectangle(snake.headPoint, new Size(10, 10)));
                    graphics.FillEllipse(brush_black, new Rectangle(point, new Size(10, 10)));
                }
                count.Text = snake.count.ToString();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!snake.Alive())             //如果蛇死亡，则不允许操作
            {
                timer1.Enabled = false;
                GameOver();
                return;
            }
            else
            {
                    int dir = 0;                                                  //保存方向信息
                    switch (e.KeyCode)
                    {
                        case Keys.Up: dir = 1; break;
                        case Keys.Down: dir = -1; break;
                        case Keys.Left: dir = 2; break;
                        case Keys.Right: dir = -2; break;
                        default: dir = 0; break;
                    }
                    if (dirction + dir != 0)
                    {
                        dirction = dir;
                        snake.Move(dir);
                        this.Invalidate();
                    }
            }
        }

        private void GameOver()
        {
            btn_keep.Visible = true;
            btn_keep.Enabled = true;
            txt_die.Visible = true;
            txt_die.Enabled = true;
            Start = false;
            snake.Clear();
            this.Invalidate();
        }

        private void GameInit()
        {
            dirction = 2;
            snake.Init();
            food.CreateFood();
            snake.food = food;
            Start = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!snake.Alive())
            {
                timer1.Enabled = false;
                GameOver();
                return;
            }
            else
            {
                switch (snake.count)
                {
                    case 10: timer1.Interval = 400;break;
                    case 20: timer1.Interval = 300;break;
                    case 30: timer1.Interval = 200;break;
                    case 40: timer1.Interval = 100;break;
                    case 50: timer1.Interval = 50;break;
                    default:break;
                }
                snake.Move(dirction);
                this.Invalidate();
            }

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            GameInit();
            btn_start.Visible = false;
            btn_start.Enabled = false;
            btn_out.Visible = false;
            btn_out.Enabled = false;
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_keep_Click(object sender, EventArgs e)
        {
            btn_keep.Visible = false;
            btn_keep.Enabled = false;
            txt_die.Visible = false;
            txt_die.Enabled = false;
            timer1.Enabled = true;
            snake.count = 0;
            GameInit();
        }
    }
}
