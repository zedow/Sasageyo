using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sasageyo
{
    public class Avatar
    {
        private Image[] ListeImage;
        public int ImageIndex;

        public Avatar()
        {
            ListeImage = new Image[5];
            ListeImage[0] = Sasageyo.Properties.Resources.AvatarChopper;
            ListeImage[1] = Sasageyo.Properties.Resources.flower;
            ListeImage[2] = Sasageyo.Properties.Resources.fujimoto;
            ListeImage[3] = Sasageyo.Properties.Resources.senjougahara;
            ListeImage[4] = Sasageyo.Properties.Resources._9;
            this.ImageIndex = 0;
        }

        public void LeftRow()
        {
            if (ImageIndex == 0)
                ImageIndex = ListeImage.Length - 1;
            else
                ImageIndex -= 1;
        }

        public void RightRow()
        {
            if (ImageIndex == ListeImage.Length - 1)
                ImageIndex = 0;
            else
                ImageIndex += 1;
        }

        public Image avatar()
        {
            return this.ListeImage[this.ImageIndex];
        }
    }
}
