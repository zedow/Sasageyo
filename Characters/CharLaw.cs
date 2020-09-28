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
    class CharLaw : Character
    {
        /*
        public AnimationSprite[] CharacterLaw { get; set; }
        public AnimationSprite[] CharacterChopper { get; set; }

        public Game game;
        public Point Position;

        public CharLaw(AnimationSprite[] list, Game _game)
        {
            this.CharacterLaw = list;
            this.game = _game;
        }
        public void CreateAnimation()
        {
            CharacterLaw[0] = new AnimationSprite(game, new AnimationManager()
            {
                AssetName = "LawStanding",
                FrameRate = 5,
                FrameSize = new Point(124, 162),
                Loop = true,
                NbFrames = new Point(6, 1)
            });
            this.CharacterLaw[0].Position.X = 150;
            this.CharacterLaw[0].Position.Y = 150;

            CharacterLaw[1] = new AnimationSprite(game, new AnimationManager()
            {
                AssetName = "LawWalking",
                FrameRate = 15,
                FrameSize = new Point(170, 164),
                Loop = true,
                NbFrames = new Point(8, 1)
            });
            this.CharacterLaw[1].Position.X = 150;
            this.CharacterLaw[1].Position.Y = 150;

            this.CharacterLaw[2] = new AnimationSprite(game, new AnimationManager()
            {
                AssetName = "LawRunning",
                FrameRate = 15,
                FrameSize = new Point(168, 156),
                Loop = true,
                NbFrames = new Point(6, 1)
            });
            this.CharacterLaw[2].Position.X = 150;
            this.CharacterLaw[2].Position.Y = 150;

            foreach (AnimationSprite anim in this.CharacterLaw)
                anim.Initialize();
        }
        public void Load(SpriteBatch spriteBatch)
        {
            foreach (AnimationSprite anim in CharacterLaw)
                anim.LoadContent(spriteBatch);
        }
        public void Update(GameTime gametime)
        {
            CharacterLaw[KeyboardCheck()].Update(gametime);
            foreach (AnimationSprite anim in CharacterLaw)
                anim.Position.X += CheckPosition().X;
        }
        public void Draw(GameTime _gametime)
        {
            CharacterLaw[KeyboardCheck()].Draw(_gametime, false);
        }
        */
    }
}
