using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snail_Races
{

    class Snail
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Image Image { get; set; }
        public string Name { get; set; }
        static Random r = new Random();
        public Snail()
        {
            
        }

        public void Move()
        {
            X += r.Next(0, 5);
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Image, X, Y);
        }
    }
}
