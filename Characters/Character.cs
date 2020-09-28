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
    public class Character
    {
        public Point position;
        public double Speed, speedMax;
        public int hp;
        public Point BasicPosition;
        public Rectangle Collision;
        public bool Hurt, wallLeft, wallRight;

        public Game game;
        public AnimationSprite[] CharacterChopper { get; set; }

        public AnimationSprite animation { get; set; }

        public Keys[] Config =
        {
            Keys.X, // Aucune action
            Keys.Q, // Avancer vers la gauche
            Keys.D //Avancer vers la droite
        };

        
        public Character()
        {
            Speed = 7;
            speedMax = 10;
            this.BasicPosition.X = 0;
            this.BasicPosition.Y = 650;
            this.position = BasicPosition;
        }
        //Position de départ du personnage


        //Vérifier si une touche est utilisée parmis celles de la configuration
        public int KeyboardCheck()
        {
            int index = 0;
            for (int i = 0; i < Config.Length; i++)
            {
                if (Keyboard.GetState().IsKeyDown(Config[i]))
                {
                    index = i;
                }
            }

            return index;
        }
        //Effecter le déplacement par rapport à la touche utilisée
        public Point CheckPosition()
        {
            this.position.X = 0;
            this.position.Y = 0;
            int lastKey = KeyboardCheck();
            if (KeyboardCheck() == 1)
                this.position.X = -(int)this.Speed;
            if (KeyboardCheck() == 2)
                this.position.X = (int)this.Speed;

            return this.position;
        }
        //En cas de contact avec un obstacle
        public bool Hit()
        {
            if(Hurt == false)
                this.hp -= 1;
            Hurt = true;
            if (hp == 0)
                return true;
            else
                return false;
        }
        //Méthode pour empêcher le personnage de sortir de la fênetre
        public void LevelBorder(levels level)
        {
            if (level.BorderRight.Intersects(this.Collision))
            {
                wallRight = true;
            }
            else if (level.BorderLeft.Intersects(this.Collision))
            {
                wallLeft = true;
            }
            else
            {
                wallLeft = false;
                wallRight = false;
            }
        }
        //Initialiser le personnage, ses animations et ses pv
        public void Initialize()
        {
            this.hp = 3;
            foreach (AnimationSprite anim in this.CharacterChopper)
                anim.Initialize();
        }
        //On charge les animations et leurs positions
        public void Load(SpriteBatch spriteBatch)
        {
            foreach (AnimationSprite anim in CharacterChopper)
            {
                anim.LoadContent(spriteBatch);
                anim.Position.X = 150;
                anim.Position.Y = this.BasicPosition.Y;
            }

        }
        //Met à jour en temps réel la classe personnage
        public void UpdateCharacter(GameTime gametime)
        {
            if (Hurt == true)
            {
                CharacterChopper[2].Update(gametime);
                if (CharacterChopper[2].FinishedAnimation == true)
                {
                    Hurt = false;
                    CharacterChopper[0].Update(gametime);
                }
                
            }
            else
            {
                CharacterChopper[2].Reset();
                CharacterChopper[0].Update(gametime);
            }
            foreach (AnimationSprite anim in CharacterChopper)
            {
                if (Hurt == false)
                {
                    if (wallLeft == true)
                    {
                        if (CheckPosition().X > 0)
                            anim.Position.X += CheckPosition().X;
                    }
                    else if (wallRight == true)
                    {
                        if (CheckPosition().X < 0)
                            anim.Position.X += CheckPosition().X;
                    }
                    else
                        anim.Position.X += CheckPosition().X;
                }
            }
            
        }
        //Affiche  le personnage sur l'écran
        public void Draw(GameTime _gametime)
        {
            if (Hurt == true)
            {
                if (CharacterChopper[2].FinishedAnimation == true)
                {
                    CharacterChopper[0].Draw(_gametime, false);
                }
                else
                    CharacterChopper[2].Draw(_gametime, true);
            }
            else
            {
                //CharacterChopper[2].Reset();
                CharacterChopper[0].Draw(_gametime, false);
            }
        }

        public void Reset()
        {
            this.position = BasicPosition;
            this.hp = 3;
            this.Speed = 7;
        }

    }
}
