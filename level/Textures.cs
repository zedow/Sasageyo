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
    public class Textures
    {
        Game game;
        public Texture2D Level01;
        public Texture2D wall01, menu, buton01, Hearth01, Hearth02, Hearth03, Hearth04, moon;
        public Song stars;
        public SpriteFont score;

        public Textures(Game _game)
        {
            this.game = _game;
        }
        public void InitializeTextures()
        {
            Level01 = this.game.Content.Load<Texture2D>("level01");
            wall01 = this.game.Content.Load<Texture2D>("spike");

            buton01 = this.game.Content.Load<Texture2D>("bouton");
            Hearth01 = this.game.Content.Load<Texture2D>("coeurFull");
            Hearth02 = this.game.Content.Load<Texture2D>("coeur01");
            Hearth03 = this.game.Content.Load<Texture2D>("coeur02");
            Hearth04 = this.game.Content.Load<Texture2D>("coeur03");
            moon = this.game.Content.Load<Texture2D>("moon");
            stars = this.game.Content.Load<Song>("stars");
            score = this.game.Content.Load<SpriteFont>("police");
        }
    }
}
