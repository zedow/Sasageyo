using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sasageyo
{
    public class Joueur
    {
        private string nom, prenom, email, pseudo;
        private int niveau, score;
        public int plafond = 2000;
        public int NvPLafond = 10;
        private Image avatar;

        public Joueur(string _nom, string _prenom, string _email, string _pseudo, Image _avatar)
        {
            this.nom = _nom;
            this.prenom = _prenom;
            this.email = _email;
            this.pseudo = _pseudo;
            this.avatar = _avatar;
            this.niveau = 1;
            this.score = 0;
        }
       
        public string getNom() { return this.nom; }
        public string getPrenom() { return this.prenom; }
        public string getEmail() { return this.email; }
        public string getPseudo() { return this.pseudo; }
        public Image getAvatar() { return this.avatar; }
        public int getNiveau() { return this.niveau;  }
        public int getScore() { return this.score;  }

        public void setEmail(string mail) { this.email = mail;  }
        public void setAvatar(Image img) { this.avatar = img;  }

        public void setPseudo(string pseudo) { this.pseudo = pseudo;  }

        public void Points(int point)
        {
            this.score += point;
            if(score > this.plafond)
            {
                if (this.niveau < this.NvPLafond)
                {
                    this.niveau += 1;
                    this.score = 0;
                }
            }
        }

        public void Evoluer()
        {
            this.niveau += 1;
        }
    }
}
