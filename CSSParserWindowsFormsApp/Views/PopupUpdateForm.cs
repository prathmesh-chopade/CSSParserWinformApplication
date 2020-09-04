using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSParserWindowsFormsApp.Views
{
    public partial class PopupUpdateForm : Form
    {
        public static string selectorTextUp;
        public static string attributeTextUp;
        public static string valueTextUp;

        public PopupUpdateForm()
        {
            InitializeComponent();
        }

        public void ControlSelector()
        {
            textBoxSelectorUp.Text = ShowAndUpdateForm.selectorText;
            labelSelectorUp.Enabled = true;
            textBoxSelectorUp.Enabled = true;
            labelAttributeUp.Enabled = false;
            textBoxAttributeUp.Enabled = false;
            labelValueUp.Enabled = false;
            textBoxValueUp.Enabled = false;
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            selectorTextUp = textBoxSelectorUp.Text;
            attributeTextUp = textBoxAttributeUp.Text;
            valueTextUp = textBoxValueUp.Text;
        }

        internal void ControlKeyValue()
        {
            textBoxAttributeUp.Text = ShowAndUpdateForm.attributeText;
            textBoxValueUp.Text = ShowAndUpdateForm.valueText;
            labelSelectorUp.Enabled = false;
            textBoxSelectorUp.Enabled = false;
            labelAttributeUp.Enabled = true;
            textBoxAttributeUp.Enabled = true;
            labelValueUp.Enabled = true;
            textBoxValueUp.Enabled = true;
        }
    }
}
