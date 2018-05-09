using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work
{
    public partial class Form1 : Form
    {
        string sign;    //记录运算符
        int pointNum;
        double num1;    //保存第一个数字
        double num2;    //保存第二个数字
        double result;  //保存结果
        bool flag = true;   //判断是否点击“=”和清空的标志

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, EventArgs e)//清空显示栏
        {
            showResult.Clear();
            flag = true;
        }

        private void btn_num1_Click(object sender, EventArgs e)
        {
            if (showResult.Text.Length <= 11 && flag)
            {
                showResult.Text += btn_num1.Text;
            }
            else if (!flag) //如果之前点击过“=”
            {
                showResult.Clear();
                showResult.Text += btn_num1.Text;
            }
        }

        private void btn_num2_Click(object sender, EventArgs e)
        {
            if (showResult.Text.Length <= 11 && flag)
            {
                showResult.Text += btn_num2.Text;
            }
            else if (!flag)
            {
                showResult.Clear();
                showResult.Text += btn_num2.Text;
            }
        }

        private void btn_num3_Click(object sender, EventArgs e)
        {
            if (showResult.Text.Length <= 11 && flag)
            {
                showResult.Text += btn_num3.Text;
            }
            else if (!flag)
            {
                showResult.Clear();
                showResult.Text += btn_num3.Text;
            }
        }

        private void btn_num4_Click(object sender, EventArgs e)
        {
            if (showResult.Text.Length <= 11 && flag)
            {
                showResult.Text += btn_num4.Text;
            }
            else if (!flag)
            {
                showResult.Clear();
                showResult.Text += btn_num4.Text;
            }
        }

        private void btn_num5_Click(object sender, EventArgs e)
        {
            if (showResult.Text.Length <= 11 && flag)
            {
                showResult.Text += btn_num5.Text;
            }
            else if (!flag)
            {
                showResult.Clear();
                showResult.Text += btn_num5.Text;
            }
        }

        private void btn_num6_Click(object sender, EventArgs e)
        {
            if (showResult.Text.Length <= 11 && flag)
            {
                showResult.Text += btn_num6.Text;
            }
            else if (!flag)
            {
                showResult.Clear();
                showResult.Text += btn_num6.Text;
            }
        }

        private void btn_num7_Click(object sender, EventArgs e)
        {
            if (showResult.Text.Length <= 11 && flag)
            {
                showResult.Text += btn_num7.Text;
            }
            else if (!flag)
            {
                showResult.Clear();
                showResult.Text += btn_num7.Text;
            }
        }

        private void btn_num8_Click(object sender, EventArgs e)
        {
            if (showResult.Text.Length <= 11 && flag)
            {
                showResult.Text += btn_num8.Text;
            }
            else if (!flag)
            {
                showResult.Clear();
                showResult.Text += btn_num8.Text;
            }
        }

        private void btn_num9_Click(object sender, EventArgs e)
        {
            if (showResult.Text.Length <= 11 && flag)
            {
                showResult.Text += btn_num9.Text;
            }
            else if (!flag)
            {
                showResult.Clear();
                showResult.Text += btn_num9.Text;
            }
        }

        private void btn_num0_Click(object sender, EventArgs e)
        {
            if (showResult.Text.Length <= 11 && flag)
            {
                showResult.Text += btn_num0.Text;
            }
            else if (!flag)
            {
                showResult.Clear();
                showResult.Text += btn_num0.Text;
            }
        }

        private void btn_Point_Click(object sender, EventArgs e)
        {
            if(showResult.Text.Contains("＋") || showResult.Text.Contains("－") || showResult.Text.Contains("×")
               || showResult.Text.Contains("÷") || showResult.Text.Contains("％"))
            {
                if (showResult.Text.Substring(showResult.Text.IndexOf(sign) + 1,
                    showResult.Text.Length - showResult.Text.IndexOf(sign) - 1) == "")
                {
                    showResult.Text += "0.";
                }
                if (showResult.Text.Substring(showResult.Text.IndexOf(sign) + 1,
                    showResult.Text.Length - showResult.Text.IndexOf(sign) - 1).Contains(".")) { }
                else
                {
                    showResult.Text += ".";
                }
            }
            else
            {
                if (showResult.Text == "")//如果在显示栏为空时点击“.”，自动补上0
                {
                    showResult.Text = "0.";
                }
                else
                {
                    if (showResult.Text.Contains(".")) { }
                    else
                    {
                        showResult.Text += ".";
                    }
                }
            }
        }

        private void btn_Delet_Click(object sender, EventArgs e)
        {
            if (showResult.Text != "")
            {
                showResult.Text = showResult.Text.Substring(0, showResult.Text.Length - 1);//删除最后一个数字或运算符
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (showResult.Text != "" && !showResult.Text.Contains("＋"))
            {
                if (showResult.Text.Contains("－") || showResult.Text.Contains("×")
                || showResult.Text.Contains("÷") || showResult.Text.Contains("％"))
                {
                    {
                        if (showResult.Text.Substring(showResult.Text.Length - 1, 1) == "－"
                        || showResult.Text.Substring(showResult.Text.Length - 1, 1) == "×"
                        || showResult.Text.Substring(showResult.Text.Length - 1, 1) == "÷"
                        || showResult.Text.Substring(showResult.Text.Length - 1, 1) == "％") { }
                        else
                        {
                            num2 = Convert.ToDouble(showResult.Text.Substring(showResult.Text.IndexOf(sign) + 1, 
                                showResult.Text.Length - showResult.Text.IndexOf(sign) - 1));
                            switch (sign)
                            {
                                case "－": result = num1 - num2; break;
                                case "×": result = num1 * num2; break;
                                case "÷": result = num1 / num2; break;
                                case "％": result = num1 % num2; break;
                            }
                            showResult.Text = result.ToString();
                            num1 = Convert.ToDouble(showResult.Text);
                            sign = "＋";
                            showResult.Text += sign;
                        }
                    }
                }
                else
                {
                    sign = "＋";
                    num1 = Convert.ToDouble(showResult.Text);
                    showResult.Text += sign;
                    flag = true;
                }
            }
            else if (showResult.Text.Contains("＋"))
            {
                if (showResult.Text.Substring(showResult.Text.Length - 1, 1) == "＋") { }
                else
                {
                    sign = "＋";
                    num2 = Convert.ToDouble(showResult.Text.Substring(showResult.Text.IndexOf(sign) + 1,
                        showResult.Text.Length - showResult.Text.IndexOf(sign) - 1));
                    result = num1 + num2;
                    showResult.Text = result.ToString();
                    num1 = Convert.ToDouble(showResult.Text);
                    showResult.Text += sign;
                }
            }
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            if (showResult.Text != "" && !showResult.Text.Contains("－"))
            {
                if (showResult.Text.Contains("＋") || showResult.Text.Contains("×")
                || showResult.Text.Contains("÷") || showResult.Text.Contains("％"))
                {
                    {
                        if (showResult.Text.Substring(showResult.Text.Length - 1, 1) == "＋"
                        || showResult.Text.Substring(showResult.Text.Length - 1, 1) == "×"
                        || showResult.Text.Substring(showResult.Text.Length - 1, 1) == "÷"
                        || showResult.Text.Substring(showResult.Text.Length - 1, 1) == "％") { }
                        else
                        {
                            num2 = Convert.ToDouble(showResult.Text.Substring(showResult.Text.IndexOf(sign) + 1,
                                showResult.Text.Length - showResult.Text.IndexOf(sign) - 1));
                            switch (sign)
                            {
                                case "＋": result = num1 + num2; break;
                                case "×": result = num1 * num2; break;
                                case "÷": result = num1 / num2; break;
                                case "％": result = num1 % num2; break;
                            }
                            showResult.Text = result.ToString();
                            num1 = Convert.ToDouble(showResult.Text);
                            sign = "－";
                            showResult.Text += sign;
                        }
                    }
                }
                else
                {
                    sign = "－";
                    num1 = Convert.ToDouble(showResult.Text);
                    showResult.Text += sign;
                    flag = true;
                }
            }
            else if (showResult.Text.Contains("－"))
            {
                if (showResult.Text.Substring(showResult.Text.Length - 1, 1) == "－") { }
                else
                {
                    sign = "－";
                    num2 = Convert.ToDouble(showResult.Text.Substring(showResult.Text.IndexOf(sign) + 1, 
                        showResult.Text.Length - showResult.Text.IndexOf(sign) - 1));
                    result = num1 - num2;
                    showResult.Text = result.ToString();
                    num1 = Convert.ToDouble(showResult.Text);
                    showResult.Text += sign;
                }
            }
        }

        private void btn_Mul_Click(object sender, EventArgs e)
        {
            if (showResult.Text != "" && !showResult.Text.Contains("×"))
            {
                if (showResult.Text.Contains("＋") || showResult.Text.Contains("－")
                || showResult.Text.Contains("÷") || showResult.Text.Contains("％"))
                {
                    {
                        if (showResult.Text.Substring(showResult.Text.Length - 1, 1) == "＋"
                        || showResult.Text.Substring(showResult.Text.Length - 1, 1) == "－"
                        || showResult.Text.Substring(showResult.Text.Length - 1, 1) == "÷"
                        || showResult.Text.Substring(showResult.Text.Length - 1, 1) == "％") { }
                        else
                        {
                            num2 = Convert.ToDouble(showResult.Text.Substring(showResult.Text.IndexOf(sign) + 1, 
                                showResult.Text.Length - showResult.Text.IndexOf(sign) - 1));
                            switch (sign)
                            {
                                case "＋": result = num1 + num2; break;
                                case "－": result = num1 - num2; break;
                                case "÷": result = num1 / num2; break;
                                case "％": result = num1 % num2; break;
                            }
                            showResult.Text = result.ToString();
                            num1 = Convert.ToDouble(showResult.Text);
                            sign = "×";
                            showResult.Text += sign;
                        }
                    }
                }
                else
                {
                    sign = "×";
                    num1 = Convert.ToDouble(showResult.Text);
                    showResult.Text += sign;
                    flag = true;
                }
            }
            else if (showResult.Text.Contains("×"))
            {
                if (showResult.Text.Substring(showResult.Text.Length - 1, 1) == "×") { }
                else
                {
                    sign = "×";
                    num2 = Convert.ToDouble(showResult.Text.Substring(showResult.Text.IndexOf(sign) + 1,
                        showResult.Text.Length - showResult.Text.IndexOf(sign) - 1));
                    result = num1 - num2;
                    showResult.Text = result.ToString();
                    num1 = Convert.ToDouble(showResult.Text);
                    showResult.Text += sign;
                }
            }
        }

        private void btn_Division_Click(object sender, EventArgs e)
        {
            if (showResult.Text != "" && !showResult.Text.Contains("÷"))
            {
                if (showResult.Text.Contains("＋") || showResult.Text.Contains("－")
                || showResult.Text.Contains("％") || showResult.Text.Contains("×"))
                {
                    {
                        if (showResult.Text.Substring(showResult.Text.Length - 1, 1) == "＋"
                        || showResult.Text.Substring(showResult.Text.Length - 1, 1) == "－"
                        || showResult.Text.Substring(showResult.Text.Length - 1, 1) == "×"
                        || showResult.Text.Substring(showResult.Text.Length - 1, 1) == "％") { }
                        else
                        {
                            num2 = Convert.ToDouble(showResult.Text.Substring(showResult.Text.IndexOf(sign) + 1,
                                showResult.Text.Length - showResult.Text.IndexOf(sign) - 1));
                            switch (sign)
                            {
                                case "＋": result = num1 + num2; break;
                                case "－": result = num1 - num2; break;
                                case "×": result = num1 * num2; break;
                                case "％": result = num1 % num2; break;
                            }
                            showResult.Text = result.ToString();
                            num1 = Convert.ToDouble(showResult.Text);
                            sign = "÷";
                            showResult.Text += sign;
                        }
                    }
                }
                else
                {
                    sign = "÷";
                    num1 = Convert.ToDouble(showResult.Text);
                    showResult.Text += sign;
                    flag = true;
                }
            }
            else if (showResult.Text.Contains("÷"))
            {
                if (showResult.Text.Substring(showResult.Text.Length - 1, 1) == "÷") { }
                else
                {
                    sign = "÷";
                    num2 = Convert.ToDouble(showResult.Text.Substring(showResult.Text.IndexOf(sign) + 1,
                        showResult.Text.Length - showResult.Text.IndexOf(sign) - 1));
                    result = num1 - num2;
                    showResult.Text = result.ToString();
                    num1 = Convert.ToDouble(showResult.Text);
                    showResult.Text += sign;
                }
            }
        }

        private void btn_Mod_Click(object sender, EventArgs e)
        {
            if (showResult.Text != "" && !showResult.Text.Contains("％"))
            {
                if (showResult.Text.Contains("＋") || showResult.Text.Contains("－")
                || showResult.Text.Contains("÷") || showResult.Text.Contains("×"))
                {
                    {
                        if (showResult.Text.Substring(showResult.Text.Length - 1, 1) == "＋"
                        || showResult.Text.Substring(showResult.Text.Length - 1, 1) == "－"
                        || showResult.Text.Substring(showResult.Text.Length - 1, 1) == "×"
                        || showResult.Text.Substring(showResult.Text.Length - 1, 1) == "÷") { }
                        else
                        {
                            num2 = Convert.ToDouble(showResult.Text.Substring(showResult.Text.IndexOf(sign) + 1, 
                                showResult.Text.Length - showResult.Text.IndexOf(sign) - 1));
                            switch (sign)
                            {
                                case "＋": result = num1 + num2; break;
                                case "－": result = num1 - num2; break;
                                case "×": result = num1 * num2; break;
                                case "÷": result = num1 / num2; break;
                            }
                            showResult.Text = result.ToString();
                            num1 = Convert.ToDouble(showResult.Text);
                            sign = "％";
                            showResult.Text += sign;
                        }
                    }
                }
                else
                {
                    sign = "％";
                    num1 = Convert.ToDouble(showResult.Text);
                    showResult.Text += sign;
                    flag = true;
                }
            }
            else if (showResult.Text.Contains("％"))
            {
                if (showResult.Text.Substring(showResult.Text.Length - 1, 1) == "％") { }
                else
                {
                    sign = "％";
                    num2 = Convert.ToDouble(showResult.Text.Substring(showResult.Text.IndexOf(sign) + 1, 
                        showResult.Text.Length - showResult.Text.IndexOf(sign) - 1));
                    result = num1 - num2;
                    showResult.Text = result.ToString();
                    num1 = Convert.ToDouble(showResult.Text);
                    showResult.Text += sign;
                }
            }
        }

        private void btn_Equ_Click(object sender, EventArgs e)
        {
            if (!showResult.Text.Contains("＋") && !showResult.Text.Contains("－")
            && !showResult.Text.Contains("÷") && !showResult.Text.Contains("×") && !showResult.Text.Contains("％")) { }
            else
            {
                num1 = Convert.ToDouble(showResult.Text.Substring(0, showResult.Text.IndexOf(sign)));
                num2 = Convert.ToDouble(showResult.Text.Substring(showResult.Text.IndexOf(sign) + 1, 
                    showResult.Text.Length - showResult.Text.IndexOf(sign) - 1));
                switch (sign)
                {
                    case "＋": result = num1 + num2; break;
                    case "－": result = num1 - num2; break;
                    case "×": result = num1 * num2; break;
                    case "÷": result = num1 / num2; break;
                    case "％": result = num1 % num2; break;
                }
                showResult.Text = result.ToString();
                flag = false;
            }
        }
    }
}

