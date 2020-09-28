using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sasageyo
{
    public class LevelManager
    {
        public Texture2D texture;
        public double speed;
        public double speedMax;
        public Point Position;
        public Rectangle BorderLeft, BorderRight;
        public Character chara;


        public LevelManager()
        {
            Position.X = 0;
            Position.Y = 0;
            BorderLeft = new Rectangle(0, 0, 1, 900);
            BorderRight = new Rectangle(499, 0, 1, 900);
            speedMax = 5;

        }
        public void setPosition()
        {
            this.Position.Y =  900 - this.texture.Height;
        }
        public void Update()
        {
            this.speed = chara.Speed - 3;
            Position.Y += (int)speed;
            if (Position.Y > 900)
                Position.Y = 900 - this.texture.Height;
        }
        public void Load(SpriteBatch spriteBatch)
        {
            Position.X = 0;
            Position.Y = 0;
            
        }
    }
}
