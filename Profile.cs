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
    public partial class Profile : Form
    {
        public Avatar _avatar = new Avatar();
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            pbLeft.Image = Sasageyo.Properties.Resources.arrows;
            pbRight.Image = Sasageyo.Properties.Resources.arrows2;
            if (Globale.Player != null)
            {
                pbAvatar.Image = Globale.Player.getAvatar();
                tbNom.Text = Globale.Player.getNom();
                tbPrenom.Text = Globale.Player.getPrenom();
                tbEmail.Text = Globale.Player.getEmail();
                tbPseudo.Text = Globale.Player.getPseudo();
                tbNiveau.Text = Globale.Player.getNiveau().ToString();
                tbScore.Text = Globale.Player.getScore().ToString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbLeft.Visible = true;
            pbRight.Visible = true;
        }

        private void pbLeft_Click(object sender, EventArgs e)
        {
            _avatar.LeftRow();
            pbAvatar.Image = _avatar.avatar();
        }

        private void pbRight_Click(object sender, EventArgs e)
        {
            _avatar.RightRow();
            pbAvatar.Image = _avatar.avatar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(pbAvatar.Image != Globale.Player.getAvatar())
            {
                Globale.Player.setAvatar(pbAvatar.Image);
            }
            if(tbEmail.Text != Globale.Player.getEmail())
            {
                Globale.Player.setEmail(tbEmail.Text);
            }
            if (tbPseudo.Text != Globale.Player.getPseudo())
            {
                Globale.Player.setPseudo(tbPseudo.Text);
            }
            MessageBox.Show("Enregistrement effectué");
        }
        private void pbAvatar_Click(object sender, EventArgs e)
        {

        }

        private void pbRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbNiveau_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbEmail.Enabled = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbPseudo.Enabled = true;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
