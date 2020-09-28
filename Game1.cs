using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using System;
using Microsoft.Xna.Framework.Media;

namespace Sasageyo
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        static AnimationSprite[] CharacterLaw;
        static AnimationSprite[] CharacterChopper;
        bouton[] boutons;
        //CharLaw Law;
        CharChopper Chopper;
        Obstacle wall;
        Textures textures;
        levels Level01, level01_parallax;
        Entity Coeurs;
        spritefont score, defeat, victoire;
        public static float metters;
        bool GameOver, Win, transition, keySpacePressed;
        int seconde;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 500;  // set this value to the desired width of your window
            graphics.PreferredBackBufferHeight = 900;   // set this value to the desired height of your window
            graphics.ApplyChanges();
            Content.RootDirectory = "Content";
        }
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            //Personnage Law
            CharacterChopper = new AnimationSprite[3];
            CharacterLaw = new AnimationSprite[3];
            boutons = new bouton[2];
            Texture2D wall01 = Content.Load<Texture2D>("spike");
            //this.Law = new CharLaw(CharacterLaw, this);
            this.Chopper = new CharChopper(CharacterChopper, this);
            this.textures = new Textures(this);
            textures.InitializeTextures();
            //this.Law.setBasicPosition();
            this.wall = new Obstacle(wall01, 0 - wall01.Height);
            //Law.CreateAnimation();
            Chopper.CreateAnimation();

            boutons[0] = new bouton(textures.buton01, new Point(500 / 2 - textures.buton01.Width / 2,100));
            boutons[1] = new bouton(textures.buton01, new Point(500 / 2 - textures.buton01.Width / 2, 200));
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
           // this.Law.Load(spriteBatch);
            this.Chopper.Load(spriteBatch);
            MediaPlayer.Play(textures.stars);
            Coeurs = new Entity();
            metters = 0;
            GameOver = false;
            Win = false;
            keySpacePressed = false;
            seconde = 0;
            transition = true;
            score = new spritefont(textures.score,new Vector2(425,40), metters.ToString());
            string texteD = "Vous etes mort";
            string texteV = "Gagne !";
            defeat = new spritefont(textures.score, new Vector2(graphics.GraphicsDevice.Viewport.Width / 2, graphics.GraphicsDevice.Viewport.Height / 2), texteD);
            victoire = new spritefont(textures.score, new Vector2(graphics.GraphicsDevice.Viewport.Width / 2, graphics.GraphicsDevice.Viewport.Height / 2), texteV);
            defeat.color = Color.Red;
            victoire.color = Color.Green;
            Coeurs.setTexture(textures.Hearth01);
            Level01 = new levels(textures.Level01, Chopper);
            level01_parallax = new levels(textures.Level01, Chopper);
            Level01.setPosition();
            
            wall.Load();
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

           
            //this.Law.Update(gameTime);
            if (GameOver == false)
            {
                
                this.Chopper.Update(gameTime);
                if(transition == false)
                {
                    Level01.Update();
                    level01_parallax.Update();
                    wall.UpdateObstacle();
                    metters += 0.1f;
                    Chopper.Speed += 0.001f;
                    wall.speed += 0.001f;
                    score.setText(Math.Round(metters, 0).ToString() + " m");
                }
                else
                {
                    if(transition == true)
                    {
                        Level01.texture = textures.moon;
                    }
                }
                if (Keyboard.GetState().IsKeyDown(Keys.Space) && transition == true) 
                {
                    keySpacePressed = true;
                }
                if(keySpacePressed == true)
                {
                    Level01.Update();
                    level01_parallax.Update();
                    if (Level01.Position.Y > 600)
                    {
                        transition = false;
                        Level01.texture = textures.Level01;
                        keySpacePressed = false;
                    }
                        
                }
                    
                Chopper.LevelBorder(Level01);
                Chopper.LevelBorder(level01_parallax);
                switch (Chopper.hp)
                {
                    case 0:
                        Coeurs.setTexture(textures.Hearth04);
                        break;
                    case 1:
                        Coeurs.setTexture(textures.Hearth03);
                        break;
                    case 2:
                        Coeurs.setTexture(textures.Hearth02);
                        break;
                    case 3:
                        Coeurs.setTexture(textures.Hearth01);
                        break;
                }
                if (Chopper.Collision.Intersects(wall.Hitbox))
                {
                    if (wall.hurt == false)
                        Chopper.Hit();
                    if (Chopper.Hit() == true)
                    {
                        GameOver = true;
                    }
                    wall.hurt = true;
                }
                if(metters > 1000)
                {
                    MediaPlayer.Stop();
                    
                    Win = true;
                    if(Win == true)
                    {
                        seconde += gameTime.ElapsedGameTime.Milliseconds;
                        if (seconde > 3000)
                        {
                            if (Globale.Player != null)
                            {
                                Globale.Player.Points((int)metters);
                            }
                            Chopper.Reset();
                            
                            MediaPlayer.Play(textures.stars);
                            wall.Reset();
                            metters = 0;
                            Win = false;
                            seconde = 0;
                        }
                    }
                }
            }
            else
            {
                MediaPlayer.Stop();
                
                seconde += gameTime.ElapsedGameTime.Milliseconds;
                if(seconde > 3000)
                {
                    if (Globale.Player != null)
                    {
                        int scorePoint = Convert.ToInt32(metters / 4);
                        Globale.Player.Points(scorePoint);
                    }
                    Chopper.Reset();
                    MediaPlayer.Play(textures.stars);
                    wall.Reset();
                    metters = 0;
                    GameOver = false;
                    seconde = 0;
                }
            }
            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            this.spriteBatch.Begin();
            // this.Law.Draw(gameTime);
            spriteBatch.Draw(Level01.texture, new Rectangle(Level01.Position.X, Level01.Position.Y, Level01.texture.Width, Level01.texture.Height), Color.White);
            spriteBatch.Draw(level01_parallax.texture, new Rectangle(level01_parallax.Position.X, level01_parallax.Position.Y - level01_parallax.texture.Height, level01_parallax.texture.Width, level01_parallax.texture.Height), Color.White);
            score.Draw(spriteBatch);
            if (GameOver == true)
                defeat.Draw(spriteBatch);
            if (Win == true)
                victoire.Draw(spriteBatch);
            wall.Draw(gameTime, spriteBatch);
            this.Chopper.Draw(gameTime);
            spriteBatch.Draw(Coeurs.texture, new Rectangle(25, 25, Coeurs.texture.Width, Coeurs.texture.Height), Color.White);
            this.spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
