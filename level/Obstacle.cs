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
    public class Obstacle : Entity
    {

        public double speed;
        public Character chara;
        public bool hurt;
        public Obstacle(Texture2D _texture, int posY)
        {
            this.texture = _texture;
            this.speed = 13;
            hurt = false;
            this.Position.Y = posY;
            
        }


        public void Load()
        {

            Random randInt = new Random();
            this.Position.X = randInt.Next(0, 500 - this.texture.Width);
            this.BasicPosition.X = randInt.Next(0, 500 - this.texture.Width);
            this.BasicPosition.Y = 0 - this.texture.Height;
            this.Hitbox = new Rectangle(this.Position.X, this.Position.Y, this.texture.Width, this.texture.Height);
        }
        public void UpdateObstacle()
        {
            Position.Y += (int)speed;
            this.Hitbox = new Rectangle(this.Position.X, this.Position.Y, this.texture.Width, this.texture.Height);
            if (Position.Y > 900 + this.texture.Height)
            {
                this.Position.Y = 0 - this.texture.Height;
                Random randInt = new Random();
                this.Position.X = randInt.Next(0, 500 - this.texture.Width);
                hurt = false;
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.texture, new Rectangle(this.Position.X, this.Position.Y, this.texture.Width, this.texture.Height), Color.White);
        }
        public void Reset()
        {
            Position = BasicPosition;
        }
    }
}
