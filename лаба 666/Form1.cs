using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GraphicsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "";
            label3.Text = "Таймер";
            label4.Text = "";
            timer1.Start();

        }

        private int v;
        private int tick;
        int r;
        int m;
        int b;
        private bool button1WasClicked = false;
        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            if (button1WasClicked == false)
            {
                label4.Text = "Запустите сначала программу";
                numericUpDown1.Value = 0;
            }
            else
            {

                int k = 0;
                Graphics g = pictureBox1.CreateGraphics();
                v = (int)numericUpDown1.Value;
                Random random = new Random();

                g.DrawRectangle(Pens.White, 0, 0, 547, 389);
                double x = 255;
                double y = 255;
                double a = random.Next(0, 361);

                double vx = v * Math.Cos(a);
                double vy = v * Math.Sin(a);

                while (true)
                {
                    v = (int)numericUpDown1.Value;
                    x += vx;
                    y += vy;
                    SolidBrush brush = new SolidBrush(Color.FromArgb(r, m, b));
                    if (tick < 10)
                    {
                        r = 0;
                        m = 73;
                        b = 255;
                    }

                    if (tick % 10 == 0)
                    {
                        if (k == 0)
                        {

                            r = random.Next(0, 255);
                            m = random.Next(0, 255);
                            b = random.Next(0, 255);
                            k++;
                        }
                    }
                    if (tick % 11 == 0)
                    {
                        k = 0;
                    }

                    if (x < 10) vx = -vx;
                    if (x > 533) vx = -vx;
                    if (y < 0) vy = -vy;
                    if (y > 370) vy = -vy;

                    pictureBox1.Image = null;
                    g.FillEllipse(brush, Convert.ToInt32(Math.Round(x)), Convert.ToInt32(Math.Round(y)), 20, 20);
                    Thread.Sleep(10);
                    Application.DoEvents();
                }
            }


        }


            private void pictureBox1_Paint(object sender, PaintEventArgs e)
            {



            }

            private void timer1_Tick(object sender, EventArgs e)
            {
                tick++;
                label2.Text = tick.ToString();


            }

            private void button1_Click(object sender, EventArgs e)
            {
            label4.Text = "";
            button1WasClicked = true;
            Graphics g = pictureBox1.CreateGraphics();
            Random random = new Random();


            SolidBrush brush = new SolidBrush(Color.Blue);


            g.DrawRectangle(Pens.White, 0, 0, 547, 389);
            double x = 255;
            double y = 255;
            g.FillEllipse(brush, Convert.ToInt32(Math.Round(x)), Convert.ToInt32(Math.Round(y)), 20, 20);

        }

        private void button2_Click(object sender, EventArgs e)
            {
                Environment.Exit(0);
            }



            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
    }
    } 
