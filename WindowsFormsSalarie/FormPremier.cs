using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSalarie
{
    public partial class FormPremier : Form
    {
        public FormPremier()
        {
            InitializeComponent();
        }

        private void EventButtRecopier(object sender, EventArgs e)
        {
            // évènement de recopie
            this.labelCopie.Text = this.textBoxMessage.Text;
        }

        private void EventButtEffacer(object sender, EventArgs e)
        {
            // évènement de effacer
            this.labelCopie.ResetText();
            this.textBoxMessage.ResetText();
        }

        private void EventButtQuitter(object sender, EventArgs e)
        {
            //évènement  du bouton quitter
            this.Close();
        }

    }

}
