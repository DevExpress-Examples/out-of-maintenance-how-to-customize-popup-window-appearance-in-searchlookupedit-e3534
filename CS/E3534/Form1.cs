using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraLayout;
using DevExpress.Utils.Win;

namespace E3534
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchLookUpEdit1_Popup(object sender, EventArgs e)
        {
            Control window = (sender as IPopupControl).PopupWindow;
            //Direct reference to the LayoutControl. It could be changed in future versions.
            //LayoutControl lc = (sender as IPopupControl).PopupWindow.Controls[2].Controls[0] as LayoutControl;
            LayoutControl lc = SearchForLayout(window);
            LayoutControlGroup lcgroup = lc.Items[0] as LayoutControlGroup;
            lcgroup.AppearanceGroup.BackColor = Color.CadetBlue;
        }

        LayoutControl SearchForLayout (Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is LayoutControl)
                    return control as LayoutControl;
                LayoutControl lc = SearchForLayout(control);
                if (lc != null)
                    return lc;
            }
            return null;
        }
    }
}