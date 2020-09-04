using System;
using System.Windows.Forms;
using CSSParserWindowsFormsApp.Presenters;
using CSSParserWindowsFormsApp.Models;

namespace CSSParserWindowsFormsApp.Views
{
    public partial class ShowAndUpdateForm : Form, IShowAndUpdateForm
    {
        SelectorProperty selectorProperty = new SelectorProperty();
        ShowAndUpdatePresenter showAndUpdatePresenter = new ShowAndUpdatePresenter();
        public static string selectorText;
        public static string attributeText;
        public static string valueText;

        public ShowAndUpdateForm()
        {
            InitializeComponent();
        }

        private void ButtonCancle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "My First Application",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }

        private void ShowAndUpdate_Load(object sender, EventArgs e)
        {
            selectorProperty.List = CSSParserForm.selectorProperty.List;
            PopulateSelectorList();
        }

        private void PopulateSelectorList()
        {
            string[] array = showAndUpdatePresenter.ChooseSelectorSet(selectorProperty);
            ListViewItem item = new ListViewItem();
            foreach(string selector in array)
            {
                listViewSelector.Items.Add(selector);
            }
            listViewSelector.Items[0].Selected = true;
            PopulateSubSelectorList(listViewSelector.Items[0].Text);
        }

        private void PopulateSubSelectorList(string selector)
        {
            listViewSubSelector.Items.Add(selector, 0);
            foreach (SelectorProperty obj in selectorProperty.List)
            {
                if (obj.Selector.Contains(selector) && !obj.Selector.Equals(selector))
                {
                    listViewSubSelector.Items.Add(obj.Selector, 1);
                }
            }
            listViewSubSelector.Items[0].Selected = true;
            selectorText = listViewSubSelector.Items[0].Text;
            PopulateKeyValueList(listViewSubSelector.Items[0].Text);
        }

        private void ListViewSelector_MouseClick(object sender, MouseEventArgs e)
        {
            if(listViewSelector.Items.Count > 0)
            {
                for(int i=0;i<listViewSelector.Items.Count;i++)
                {
                    if (listViewSelector.Items[i].Selected)
                    {
                        listViewSubSelector.Items.Clear();
                        listViewKeyValue.Items.Clear();
                        selectorText = listViewSelector.Items[i].Text;
                        PopulateSubSelectorList(listViewSelector.Items[i].Text);
                    }
                }
            }
        }

        private void ListViewSubSelector_MouseClick(object sender, MouseEventArgs e)
        {
            if(listViewSubSelector.Items.Count > 0)
            {
                for (int i = 0; i < listViewSubSelector.Items.Count; i++)
                {
                    if (listViewSubSelector.Items[i].Selected)
                    {
                        listViewKeyValue.Items.Clear();
                        selectorText = listViewSubSelector.Items[i].Text;
                        PopulateKeyValueList(listViewSubSelector.Items[i].Text);
                    }
                }
            }
        }

        private void PopulateKeyValueList(string text)
        {
            foreach(SelectorProperty obj in selectorProperty.List)
            {
                if (obj.Selector.Equals(text))
                {
                    ListViewItem item1 = new ListViewItem(obj.Key);
                    item1.SubItems.Add(obj.ValuePair);
                    listViewKeyValue.Items.Add(item1);
                }
            }
            this.Controls.Add(listViewKeyValue);
        }

        private void ButtonUpdateFile_Click(object sender, EventArgs e)
        {
            FileIO io = new FileIO
            {
                InputFilePath = CSSParserForm.inputPath,
                OutputFilePath = CSSParserForm.outputPath
            };
            if (showAndUpdatePresenter.CreateAndWriteFile(selectorProperty.List,io))
            {
                MessageBox.Show("File written successful\n Path location: "+CSSParserForm.outputPath+"\\output.css");
                Application.Exit();
            }
        }

        private void ListViewSubSelector_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewSubSelector.Items.Count > 0)
            {
                for (int i = 0; i < listViewSubSelector.Items.Count; i++)
                {
                    if (listViewSubSelector.Items[i].Selected)
                    {
                        selectorText = listViewSubSelector.Items[i].Text;
                        using (PopupUpdateForm popupUpdateForm = new PopupUpdateForm())
                        {
                            popupUpdateForm.ControlSelector();
                            if (popupUpdateForm.ShowDialog() == DialogResult.OK)
                            {
                                string updatedSelector = PopupUpdateForm.selectorTextUp;
                                if (!showAndUpdatePresenter.UpdateSelector(selectorText, updatedSelector, selectorProperty.List))
                                {
                                    MessageBox.Show("Unable to update data try again!");
                                }
                                else
                                {
                                    listViewSelector.Items.Clear();
                                    PopulateSelectorList();
                                    listViewSubSelector.Items.Clear();
                                    if(updatedSelector.Contains(" "))
                                    {
                                        int index = updatedSelector.IndexOf(" ");
                                        PopulateSubSelectorList(PopupUpdateForm.selectorTextUp.Substring(0, index));
                                    }
                                    else
                                    {
                                        PopulateSubSelectorList(PopupUpdateForm.selectorTextUp);
                                    }
                                    listViewKeyValue.Items.Clear();
                                    PopulateKeyValueList(PopupUpdateForm.selectorTextUp);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void listViewKeyValue_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listViewKeyValue.Items.Count > 0)
            {
                for(int i = 0; i < listViewKeyValue.Items.Count; i++)
                {
                    if(listViewKeyValue.Items[i].Selected)
                    {
                        attributeText = listViewKeyValue.Items[i].Text;
                        valueText = listViewKeyValue.Items[i].SubItems[1].Text;
                        using (PopupUpdateForm popupUpdateForm = new PopupUpdateForm())
                        {
                            popupUpdateForm.ControlKeyValue();
                            if (popupUpdateForm.ShowDialog() == DialogResult.OK)
                            {
                                if (!showAndUpdatePresenter.UpdateKeyAndValue(selectorText, selectorProperty.List, attributeText, PopupUpdateForm.attributeTextUp, PopupUpdateForm.valueTextUp))
                                {
                                    MessageBox.Show("Unable to update data try again!");
                                }
                                else
                                {
                                    listViewKeyValue.Items.Clear();
                                    PopulateKeyValueList(selectorText);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
