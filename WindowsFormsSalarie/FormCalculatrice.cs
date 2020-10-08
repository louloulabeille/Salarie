using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsSalarie
{
    public partial class FormCalculatrice : Form
    {
        private int _somme;

        public int Somme { get => _somme; set => _somme = value; }

        public FormCalculatrice()
        {
            InitializeComponent();
            this._somme = 0;
        }

        private void EventFormClosedMessage(object sender, FormClosedEventArgs e)
        {
            // event lors de la fermeture du formulaire
            Debug.WriteLine("Fin de l'application Additionneur.");

        }

        private void EventButton0(object sender, EventArgs e)
        {
            this.textBoxAffichage.Text += "0";
        }

        /// <summary>
        /// event pour la gestion des boutons auter que le 0
        /// ajoute le chiffre et le "+" dans le textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventButtonAutre(object sender, EventArgs e)
        {
            Button b = sender as Button;
            StringBuilder sBulder = new StringBuilder();
            if ( this.textBoxAffichage.Text != null)
            {
                sBulder.Append(this.textBoxAffichage.Text);
            }
            sBulder.Append(b.Text);
            sBulder.Append("+");
            this.textBoxAffichage.Text = sBulder.ToString();
            this._somme += int.Parse(b.Text);
        }

        /// <summary>
        /// Méthode de Event pour vider le textBoxAffichage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventButtonVider(object sender, EventArgs e )
        {
            // vide le textBoxAffichage
            this.textBoxAffichage.ResetText();
            this._somme = 0;
        }

        /// <summary>
        /// méthode de Event qui va calculer les additions
        /// et va afficher le résultat en affichant le résultat et "+"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventButtonCalculer(object sender, EventArgs e)
        {
            this.textBoxAffichage.Text += "=" + this._somme.ToString() + "+";
        }

    }
}
