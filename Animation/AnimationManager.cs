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
    public class AnimationManager
    {
        public string AssetName { get; set; }
        public Point FrameSize { get; set; }
        public Point NbFrames { get; set; }
        public int FrameRate { get; set; }
        public bool Loop { get; set; }
    }
}
