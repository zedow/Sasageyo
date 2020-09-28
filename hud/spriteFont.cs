using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Sasageyo
{
    public class spritefont
    {
        SpriteFont Font;
        Vector2 Position;
        string Text;
        Vector2 Origin;
        public Color color;

        public spritefont(SpriteFont _font, Vector2 _position, string _text)
        {
            this.Font = _font;
            this.Position = _position;
            this.Text = _text;
            this.Origin = _font.MeasureString(_text) / 2;
            color = Color.White;
        }
        public void setText(string text)
        {
            this.Text = text;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(this.Font, this.Text, this.Position, color, 0, Origin, 1.0f, SpriteEffects.None, 0.5f);
        }
    }
}
