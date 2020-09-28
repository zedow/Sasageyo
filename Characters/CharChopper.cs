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
    public class CharChopper : Character
    {
        public CharChopper(AnimationSprite[] list, Game _game)
        {
            this.CharacterChopper = list;
            this.game = _game;
        }
        public void CreateAnimation()
        {
            //On créé toutes les animations requises
            CharacterChopper[0] = new AnimationSprite(game, new AnimationManager()
            {
                AssetName = "Chopper",
                FrameRate = 10,
                FrameSize = new Point(150, 131),
                Loop = true,
                NbFrames = new Point(3, 1),
            });
            
            CharacterChopper[1] = new AnimationSprite(game, new AnimationManager()
            {
                AssetName = "Chopper2",
                FrameRate = 10,
                FrameSize = new Point(160, 186),
                Loop = true,
                NbFrames = new Point(2, 1),
                
            });
            CharacterChopper[1].Collision = new Rectangle(this.position.X, this.position.Y, 160, 186);
            CharacterChopper[2] = new AnimationSprite(game, new AnimationManager()
            {
                AssetName = "ChopperHurt",
                FrameRate = 10,
                FrameSize = new Point(156, 148),
                Loop = false,
                NbFrames = new Point(5, 1),
            });
            CharacterChopper[2].Collision = new Rectangle(this.position.X, this.position.Y, 160, 186);
            this.Collision = new Rectangle(CharacterChopper[0].Position.X, CharacterChopper[0].Position.Y, 150, 131);
            foreach(AnimationSprite anim in CharacterChopper)
            {
                anim.Position.X = this.BasicPosition.X;
                anim.Position.Y = this.BasicPosition.Y;
            }
            //Méthode de la classe parent Character
            Initialize();
        }
        public void Update(GameTime gametime)
        {
            //Méthode de la classe parent Character
            UpdateCharacter(gametime);
            this.Collision = new Rectangle(CharacterChopper[0].Position.X + 27, CharacterChopper[0].Position.Y, 100, 117);
            
        }
    }
}
