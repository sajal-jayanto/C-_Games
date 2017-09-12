using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Snake
    {
        public Rectangle[] rectangle;
        public SolidBrush brush;
        int x, y, width, hight;
        
        public Snake()
        {
            x = 100;
            y = 100;
            width = 10;
            hight = 10;

            rectangle = new Rectangle[3];
            brush = new SolidBrush(Color.Green);

            for (int i = 0; i < rectangle.Length; ++i)
            {
                rectangle[i] = new Rectangle(x, y, width, hight);
                x -= 10;
            }
        }

        public void DrowRectabgle(Graphics g)
        {
            foreach(Rectangle re in rectangle)
            {
                g.FillRectangle(brush , re);
            }
        }

        public void DrowSnake()
        {
            for(int i = rectangle.Length - 1 ; i > 0 ; i--)
            {
                rectangle[i] = rectangle[i - 1];
            }
        }

        public void MoveUp()
        {
            DrowSnake();
            rectangle[0].Y -= 10;
        }

        public void MoveDown()
        {
            DrowSnake();
            rectangle[0].Y += 10;
        }

        public void MoveLeft()
        {
            DrowSnake();
            rectangle[0].X -= 10;
        }

        public void MoveRight()
        {
            DrowSnake();
            rectangle[0].X += 10;
        }

        public void SnakeGrow()
        {
            List<Rectangle> rex = rectangle.ToList();
            rex.Add(new Rectangle( rectangle[rectangle.Length - 1].X , rectangle[rectangle.Length - 1].Y , width , hight) );
            rectangle = rex.ToArray();
        }

      

    }
}
