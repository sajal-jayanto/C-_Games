using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Food
    {
        private int x , y , width , hight;
        private SolidBrush brush;
        public Rectangle Afood;

        public Food(Random re)
        {
            brush = new SolidBrush(Color.Red);

            x = re.Next(3, 28) * 10;
            y = re.Next(3, 28) * 10;

            width = 10;
            hight = 10;

            Afood = new Rectangle(x, y, width, hight);
        }

        public void RandFood(Random re)
        {
            x = re.Next(3, 28) * 10;
            y = re.Next(3, 28) * 10;
        }

        public void DrowFood(Graphics g)
        {
            Afood.X = x;
            Afood.Y = y;
            g.FillRectangle(brush, Afood);
        }

    }
}
