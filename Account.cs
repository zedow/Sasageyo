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
    public partial class Account : Form
    {
        public Avatar _avatar = new Avatar();
        public Account()
        {
            InitializeComponent();

            LeftArrow.Image = Sasageyo.Properties.Resources.arrows;
            RightArrow.Image = Sasageyo.Properties.Resources.arrows2;
            pbAvatar.Image = _avatar.avatar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void Left_Click(object sender, EventArgs e)
        {
            _avatar.LeftRow();
            pbAvatar.Image = _avatar.avatar();
            
        }

        private void Right_Click(object sender, EventArgs e)
        {
            _avatar.RightRow();
            pbAvatar.Image = _avatar.avatar();
        }
        public void CheckMail(string mail)
        {

        }
        private void btValider_Click(object sender, EventArgs e)
        {
            if (tbNom.Text != "" && tbPrenom.Text != "" && tbMail.Text != "" && tbPseudo.Text != "")
            {
                if (tbMail.Text.Contains("@") && tbMail.Text.Contains("."))
                {
                    Globale.Player = new Joueur(tbNom.Text, tbPrenom.Text, tbMail.Text, tbPseudo.Text, pbAvatar.Image);
                }
                else
                {
                    MessageBox.Show("L'email indiqué est incorrecte");
                }
            }
            else
            {
                MessageBox.Show("Aucun champs ne doit être laissé vide");
            }
        }

        private void pbRetour_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
