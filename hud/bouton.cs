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
    class bouton
    {
        public SpriteFont spriteFont;
        public Point Position;
        public Texture2D texture;
        public Rectangle rectangle;

        public bouton(Texture2D _texture, Point _Position)
        {
            this.Position = _Position;
            this.texture = _texture;
            this.rectangle = new Rectangle(this.Position.X, this.Position.Y, this.texture.Width, this.texture.Height);
        }

        public void Draw(SpriteBatch sprite)
        {
            sprite.Draw(this.texture, new Rectangle(this.Position.X, this.Position.Y, this.texture.Width, this.texture.Height), Color.White);
        }
    }
}
