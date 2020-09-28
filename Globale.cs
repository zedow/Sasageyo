using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sasageyo
{
    public class Globale
    {
        public static Joueur Player;
        public static bool GameOver = false;
        public static List<string> pseudo = new List<string>();
        public static List<string> nom = new List<string>();
        public static List<string> prenom = new List<string>();
        public static List<string> email = new List<string>();
        public static List<string> avatar = new List<string>();
    }
}
