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
    public partial class menu : Form
    {
       
        
        public menu()
        {
            InitializeComponent();

        }
        private void menu_Load(object sender, EventArgs e)
        {
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            
        }

        private void btProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void time_Tick(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nouveauCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.MdiParent = this;
            account.Show();
        }

        private void voirMonProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globale.Player != null)
            {
                Profile profile = new Profile();
                profile.MdiParent = this;
                profile.Show();
            }
            else
                MessageBox.Show("Veuillez d'abord vous identifier");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Game1 game = new Game1();
            game.Run();
        }

        private void btRules_Click(object sender, EventArgs e)
        {
            rules rules = new rules();
            rules.MdiParent = this;
            rules.Show();
        }
    }
}
