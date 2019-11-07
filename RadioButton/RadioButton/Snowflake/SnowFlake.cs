using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snowflake
{
    class SnowFlake
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; }
        static Image image = Properties.Resources.flake;
        static Random r = new Random();

        public SnowFlake()
        {
            X = r.Next(640);
            Y = r.Next(480);
            Speed = r.Next(1, 3);
            
        }

        public void Move()
        {

            Y += Speed;

            if ( Y > 480)
            {
                Y = -20;
            }
            
            
     
        }

        /// Draw(Graphics g)
        /// Draws the snowflake
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            g.DrawImage(image, X, Y);
        }


    }
}
