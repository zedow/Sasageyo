
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Sasageyo
{
    public class Entity
    {
        public Texture2D texture;
        public Rectangle Hitbox, hitbox2;
        public Point Position, BasicPosition;

        public void setTexture(Texture2D _texture)
        {
            this.texture = _texture;
        }
        public Texture2D getTexture() { return this.texture;  }
    }

}