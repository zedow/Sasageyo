using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sasageyo
{
    public partial class connexion : Form
    {
        
        public connexion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            StreamReader persos = new StreamReader("save.csv");
            string lignefichier = "";


            while ((lignefichier = persos.ReadLine()) != null)
            {
                string[] colonnes;
                colonnes = lignefichier.Split(';');

                Globale.pseudo.Add(colonnes[0]);
                Globale.nom.Add(colonnes[1]);
                Globale.prenom.Add(colonnes[2]);
                Globale.email.Add(colonnes[3]);
                Globale.avatar.Add(colonnes[4]);
            }
            persos.Close();

            for(int i = 0; i < Globale.pseudo.Count -1; i++)
            {
                if(tbPseudo.Text == Globale.pseudo[i])
                {
                    Globale.Player = new Joueur(Globale.nom[i], Globale.prenom[i], Globale.email[i], Globale.pseudo[i], Sasageyo.Properties.Resources.AvatarChopper);
                }
            }
        }

        private void connexion_Load(object sender, EventArgs e)
        {

        }
    }
}
