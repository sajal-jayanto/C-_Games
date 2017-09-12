using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        Graphics bord;
        Snake Snake = new Snake();
        Random random = new Random();
        Food food;
        bodar Bodar;
        Rectangle temprec;

        bool Up = false;
        bool Down = false;
        bool Left = false;
        bool Right = true;

        public Form1()
        {
            InitializeComponent();
            food = new Food(random);
            Bodar = new bodar();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            bord = e.Graphics;
            Bodar.Drowbordar(bord);
            food.DrowFood(bord);
            Snake.DrowRectabgle(bord);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Up && !Down)
            {
                Up = true;
                Down = false;
                Left = false;
                Right = false;
            }
            if (e.KeyData == Keys.Down && !Up)
            {
                Up = false;
                Down = true;
                Left = false;
                Right = false;
            }
            if (e.KeyData == Keys.Left && !Right)
            {
                Up = false;
                Down = false;
                Left = true;
                Right = false;
            }
            if (e.KeyData == Keys.Right && !Left)
            {
                Up = false;
                Down = false;
                Left = false;
                Right = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Up) { Snake.MoveUp();  }
            if (Down) { Snake.MoveDown(); }
            if (Right) { Snake.MoveRight(); }
            if (Left) { Snake.MoveLeft(); }
           
            for (int i = 0; i < Snake.rectangle.Length; ++i)
            {
                if (Snake.rectangle[i].IntersectsWith(food.Afood))
                {
                    Snake.SnakeGrow();
                    food.RandFood(random);
                }
            }

            collision();
            bodarCollision();
            this.Invalidate();
        }

        public void collision()
        {
            for(int i = 1 ; i < Snake.rectangle.Length ; ++i)
            {
                if( Snake.rectangle[i].IntersectsWith(Snake.rectangle[0]) )
                {
                    GameOver();
                }
            }
        }

        public void bodarCollision()
        {
            for (int i = 0; i < 130; ++i)
            {
                if (Bodar.reg[i].IntersectsWith(Snake.rectangle[0]) )
                {
                    GameOver();
                }
            }
        }

        public void GameOver()
        {
            timer1.Enabled = false;
            MessageBox.Show("Game Over!");
            Snake = new Snake();
            Up = false;
            Down = false;
            Left = false;
            Right = true;
            timer1.Enabled = true;
        }

    }
}
