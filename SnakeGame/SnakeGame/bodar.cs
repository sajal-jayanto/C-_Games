using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class bodar
    {
        private int x, y, width, hight;
        public Rectangle [] reg;
        private SolidBrush brush;

        public bodar()
        {
            x = 0;
            y = 0;
            width = 10;
            hight = 10;
            reg = new Rectangle[300];
            brush = new SolidBrush(Color.Blue);
            for(int i = 0 ; i < 35 ; i++)
            {
                reg[i] = new Rectangle(x , y , width , hight);
                x += 10;
            }
            for (int i = 35 ; i < 65 ; i++)
            {
                reg[i] = new Rectangle(x, y, width, hight);
                y += 10;
            }
            for (int i = 65 ; i < 100 ; i++)
            {
                reg[i] = new Rectangle(x, y, width, hight);
                x -= 10;
            }
            for (int i = 100 ; i < 130 ; i++)
            {
                reg[i] = new Rectangle(x, y, width, hight);
                y -= 10;
            }
        }

        public void Drowbordar(Graphics g)
        {
            for(int i = 0 ; i < 130 ; ++i)
            {
                g.FillRectangle(brush, reg[i]);
            }
        }


        

    }
}
