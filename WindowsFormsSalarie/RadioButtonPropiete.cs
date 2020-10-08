using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsSalarie
{
    class RadioButtonPropiete : RadioButton
    {
        private typeRadio _type;
        private proprieteRadio _propriete;

        public RadioButtonPropiete(typeRadio type,proprieteRadio propriete)
        {
            _type = type;
            _propriete = propriete;
        }


        internal typeRadio Type { get => _type; set => _type = value; }
        internal proprieteRadio Propriete { get => _propriete; set => _propriete = value; }

        public void ChangeForm( object sender )
        {
            Label e = sender as Label;
            switch (this._type)
            {
                case typeRadio.blue:
                    if ( this._propriete == proprieteRadio.BlackColor )
                    {
                        e.BackColor = Color.Blue;
                    }
                    else
                    {
                        e.ForeColor = Color.Blue;
                    }
                    break;
                case typeRadio.green:
                    if (this._propriete == proprieteRadio.BlackColor)
                    {
                        e.BackColor = Color.Green;
                    }
                    else
                    {
                        e.ForeColor = Color.Green;
                    }
                    break;
                case typeRadio.red:
                    if (this._propriete == proprieteRadio.BlackColor)
                    {
                        e.BackColor = Color.Red;
                    }
                    else
                    {
                        e.ForeColor = Color.Red;
                    }
                    break;
                default:
                    if (this._type == typeRadio.masjuscule)
                    {
                        e.Text = e.Text.ToUpper();
                    }
                    else
                    {
                        e.Text = e.Text.ToLower();
                    }
                    break;
            }
        }


    }

    enum typeRadio
    {
        red = 0,
        green = 1,
        blue = 2,
        minuscule = 3,
        masjuscule = 4,
    }

    enum proprieteRadio
    {
        BlackColor = 0,
        ForeColor = 1,
        Case = 2,
    }
}
