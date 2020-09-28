using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsSalarie
{
    class CheckedListBoxChoix : CheckedListBox
    {
        private GroupBox[] tabBoxLie;

        public GroupBox[] TabBoxLie { get => tabBoxLie; set => tabBoxLie = value; }

        public void Active (ItemCheckEventArgs e , GroupBox[] tabBox)
        {
            if ( e.NewValue == CheckState.Checked )
            {
                tabBox[e.Index].Enabled = true;
                tabBox[e.Index].Visible = true;
            }
            else
            {
                tabBox[e.Index].Enabled = false;
                tabBox[e.Index].Visible = false;
            }
        }
    }
}
