using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsSalarie
{
    public partial class FormBoutonRadio : Form
    {
        public FormBoutonRadio()
        {
            InitializeComponent();
        }

        private void EventEcriture(object sender, EventArgs e)
        {
            //affichage dans le label
            TextBox b = sender as TextBox;
            this.labelAffichage.Text = b.Text;
        }

        private void EventChoixMenu(object sender, EventArgs e)
        {
            // dégrise
            Label b = sender as Label;
            if ( b.Text.Length == 0 )
            {
                this.checkedListBoxChoix.Enabled = false;
            }
            else
            {
                this.checkedListBoxChoix.Enabled = true;
            }
        }
    }
}
