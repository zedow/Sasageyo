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
    public class AnimationSprite
    {
        public Point Position;
        protected Game Game;
        protected AnimationManager Definition;
        protected SpriteBatch spriteBatch;
        public Texture2D sprite;
        protected Point CurrentFrame;
        public bool FinishedAnimation = false;
        protected double TimeBetweenFrame = 16; // 60 fps 
        protected double lastFrameUpdatedTime = 0;
        public Rectangle Collision { get; set; }

        private int _Framerate = 60;
        public int Framerate
        {
            get { return this._Framerate; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Framerate can't be less or equal to 0");
                if (this._Framerate != value)
                {
                    this._Framerate = value;
                    this.TimeBetweenFrame = 1000.0d / (double)this._Framerate;
                }
            }
        }
        public Texture2D getTexture() { return this.sprite; }

        public AnimationSprite(Game game, AnimationManager definition)
        {
            this.Game = game;
            this.Definition = definition;
            this.Position = new Point();
            this.CurrentFrame = new Point();
        }

        public void Initialize()
        {
            this.Framerate = this.Definition.FrameRate;
        }

        public void LoadContent(SpriteBatch spritebatch = null)
        {
            this.sprite = this.Game.Content.Load<Texture2D>(this.Definition.AssetName);
            if (spritebatch == null)
                this.spriteBatch = new SpriteBatch(this.Game.GraphicsDevice);
            else
                this.spriteBatch = spritebatch;
        }

        public void Reset()
        {
            this.CurrentFrame = new Point();
            this.FinishedAnimation = false;
            this.lastFrameUpdatedTime = 0;
        }

        public void Update(GameTime time)
        {
            if (FinishedAnimation) return;
            this.lastFrameUpdatedTime += time.ElapsedGameTime.Milliseconds;
            if (this.lastFrameUpdatedTime > this.TimeBetweenFrame)
            {
                this.lastFrameUpdatedTime = 0;
                if (this.Definition.Loop)
                {
                    this.CurrentFrame.X++;
                    if (this.CurrentFrame.X >= this.Definition.NbFrames.X)
                    {
                        this.CurrentFrame.X = 0;
                        this.CurrentFrame.Y++;
                        if (this.CurrentFrame.Y >= this.Definition.NbFrames.Y)
                            this.CurrentFrame.Y = 0;
                    }
                }
                else
                {
                    this.CurrentFrame.X++;
                    if (this.CurrentFrame.X >= this.Definition.NbFrames.X)
                    {
                        this.CurrentFrame.X = 0;
                        this.CurrentFrame.Y++;
                        if (this.CurrentFrame.Y >= this.Definition.NbFrames.Y)
                        {
                            this.CurrentFrame.X = this.Definition.NbFrames.X - 1;
                            this.CurrentFrame.Y = this.Definition.NbFrames.Y - 1;
                            this.FinishedAnimation = true;
                        }
                    }
                }
            }
        }
        public void Draw(GameTime time, bool DoBeginEnd = true)
        {

            this.spriteBatch.Draw(this.sprite,
                                  new Rectangle(this.Position.X, this.Position.Y, this.Definition.FrameSize.X, this.Definition.FrameSize.Y),
                                  new Rectangle(this.CurrentFrame.X * this.Definition.FrameSize.X, this.CurrentFrame.Y * this.Definition.FrameSize.Y, this.Definition.FrameSize.X, this.Definition.FrameSize.Y),
                                  Color.White);
        }
    }
}
