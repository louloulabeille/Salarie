using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace ClassLibraryFormSalarie
{
    

    namespace WindowsFormsSalarie
    {
        class CheckedListBoxChoix : CheckedListBox
        {
            public void Active(ItemCheckEventArgs e, GroupBox[] listBox)
            {
                switch (e.Index)
                {
                    case 0:
                        if (e.CurrentValue == CheckState.Unchecked)
                        {
                            listBox[0].Enabled = true;
                            listBox[0].Visible = true;
                        }
                        else
                        {
                            listBox[0].Enabled = false;
                            listBox[0].Visible = false;
                        }
                        break;
                    case 1:
                        if (e.CurrentValue == CheckState.Unchecked)
                        {
                            listBox[1].Enabled = true;
                            listBox[1].Visible = true;
                        }
                        else
                        {
                            listBox[1].Enabled = false;
                            listBox[1].Visible = false;
                        }
                        break;
                    case 2:
                        if (e.CurrentValue == CheckState.Unchecked)
                        {
                            listBox[2].Enabled = true;
                            listBox[2].Visible = true;
                        }
                        else
                        {
                            listBox[2].Enabled = false;
                            listBox[2].Visible = false;
                        }
                        break;
                }

            }

        }
    }

}
