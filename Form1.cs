using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sideRoad();
            explosion1.Visible = false;
            stop.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(6);
            Explosion();
            cars(4);
            hearts(3);
            can(2);
            heartsTouching();
            canTouching();
            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value > 0)
            {
                progressBar2.Value -= 1;
            }
            else
            {
                gameOver();
            }
        }

        void moveline(int speed)
        {
            if(line1.Top >= 755)
            {
                line1.Top = 0;
            }
            else
            {
                line1.Top += speed;
            }

            if (line2.Top >= 755)
            {
                line2.Top = 0;
            }
            else
            {
                line2.Top += speed;
            }

            if (line3.Top >= 755)
            {
                line3.Top = 0;
            }
            else
            {
                line3.Top += speed;
            }

            if (house.Top >= 755)
            {
                house.Top = -2000;
            }
            else
            {
                house.Top += speed;
            }

            if (tree2.Top >= 755)
            {
                tree2.Top = -2000;
            }
            else
            {
                tree2.Top += speed;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (Player.Left > 120)
                {
                    Player.Left += -20;
                }

            }
            if (e.KeyCode == Keys.Right)
            {
                if (Player.Right < 500)
                {
                    Player.Left += 20;
                }
            }
        }

        Random r = new Random();
        int x;
        void cars(int speed)
        {
            if (Car1.Top >= 755)
            {
                x = r.Next(100, 420);
                Car1.Location = new Point(x, -50);
            }
            else
            {
                Car1.Top += speed;
            }

            if (Car2.Top >= 755)
            {
                x = r.Next(100, 420);
                Car2.Location = new Point(x, -50);
            }
            else
            {
                Car2.Top += speed;
            }

            if (Car3.Top >= 755)
            {
                x = r.Next(100, 420);
                Car3.Location = new Point(x, -50);
            }
            else
            {
                Car3.Top += speed;
            }
        }

        Random b = new Random();
        int y;
        void hearts(int speed)
        {
            if (heart1.Top >= 755)
            {
                y = b.Next(100, 420);
                heart1.Location = new Point(y, -50);
                heart1.Visible = true;
            }
            else
            {
                heart1.Top += speed;
            }

            if (heart2.Top >= 755)
            {
                y = b.Next(100, 420);
                heart2.Location = new Point(y, -50);
                heart2.Visible = true;
            }
            else
            {
                heart2.Top += speed;
            }
        }

        Random c = new Random();
        int y2;
        void can(int speed)
        {
            if (gas.Top >= 755)
            {
                y2 = c.Next(100, 420);
                gas.Location = new Point(y2, -400);
                gas.Visible = true;
            }
            else
            {
                gas.Top += speed;
            }
        }

        void sideRoad()
        {
            pictureBox1.Controls.Add(house);
            house.Location = new Point(10, -700);
            house.BackColor = Color.Transparent;

            pictureBox2.Controls.Add(tree2);
            tree2.Location = new Point(0, 0);
            tree2.BackColor = Color.Transparent;
        }

        void heartsTouching()
        {
            if(progressBar1.Value < 100)
            {
            if (Player.Bounds.IntersectsWith(heart1.Bounds))
               {

                    progressBar1.Value = progressBar1.Value + 1;
                    heart1.Visible = false;
               }
            if (Player.Bounds.IntersectsWith(heart2.Bounds))
               {
                    progressBar1.Value = progressBar1.Value + 1;
                    heart2.Visible = false;
               }
            }
        }

        void canTouching()
        {
            if (progressBar2.Value < 100)
            {
                if (Player.Bounds.IntersectsWith(gas.Bounds))
                {

                    progressBar2.Value = progressBar2.Value + 1;
                    gas.Visible = false;
                }
            }
        }

        void Explosion()
        {
            if(Player.Bounds.IntersectsWith(Car1.Bounds)|| Player.Bounds.IntersectsWith(Car2.Bounds))
            {
                
                progressBar1.Value = progressBar1.Value - 1;
            }
            else
            {
                if (Player.Bounds.IntersectsWith(Car3.Bounds))
                {
                    
                    progressBar1.Value = progressBar1.Value - 1;
                }
                    
            }
            if(progressBar1.Value == 0)
             {
                    gameOver();
             }
        }

        void gameOver()
        {
                timer1.Enabled = false;
                timer2.Enabled = false;
                explosion1.Visible = true;
                Player.Controls.Add(explosion1);
                explosion1.Location = new Point(-8, -10);
                explosion1.BackColor = Color.Transparent;
                stop.Visible = true;
        }

       
    }
}
