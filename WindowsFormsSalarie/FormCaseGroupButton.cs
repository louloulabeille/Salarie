using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsSalarie
{
    public partial class FormCaseGroupButton : Form
    {
        public FormCaseGroupButton()
        {
            InitializeComponent();
        }

        private void EventTextBoxSaisie(object sender, EventArgs e)
        {
            if (this.textBoxSaisie.Text.Length > 0 )
            {
                this.labelAffichage.Text = this.textBoxSaisie.Text;
                this.groupBox1.Enabled = true;
            }
            else
            {
                this.groupBox1.Enabled = false;
                this.groupBox1.Refresh();
            }
        }

        private void EventitemCheckChange(object sender, ItemCheckEventArgs e)
        {
            CheckedListBoxChoix c = sender as CheckedListBoxChoix;
            GroupBox[] tab = new GroupBox[] { groupBox2, groupBox3, groupBox4 };
            c.Active(e,tab);
            
        }

        private void EventRadioButtonChange(object sender, EventArgs e)
        {
            RadioButton b = sender as RadioButton;
            if ( b.Checked )
            {
                switch (b.Name)
                {
                    case "radioButtonFondRed" :
                        //this.labelAffichage.BackColor = Color.Red;
                        //break;
                    case "radioButtonFondGreen":
                        //this.labelAffichage.BackColor = Color.Green;
                        //break;
                    case "radioButtonFondBlue":
                        this.labelAffichage.BackColor = Color.FromName(b.Tag.ToString());
                        break;
                    case "radioButtonCaractBlack":
                        //this.labelAffichage.ForeColor = Color.Black;
                        //break;
                    case "radioButtonCaractWhite":
                        //this.labelAffichage.ForeColor = Color.White;
                        //break;
                    case "radioButtonCaractRed":
                        this.labelAffichage.ForeColor = Color.FromName(b.Tag.ToString());
                        break;
                    case "radioButtonMajuscule":
                        this.labelAffichage.Text = this.labelAffichage.Text.ToUpper();
                        break;
                    case "radioButtonMinuscule":
                        this.labelAffichage.Text = this.labelAffichage.Text.ToLower();
                        break;
                }
                
            }
        }
    }
}
