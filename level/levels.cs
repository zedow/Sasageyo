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
    public class levels : LevelManager
    {
        public levels(Texture2D texture, Character leChara)
        {
            this.texture = texture;
            this.speed = leChara.Speed - 3;
            chara = leChara;
        }
    }
}
