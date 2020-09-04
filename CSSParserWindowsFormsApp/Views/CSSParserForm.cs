using System;
using System.Windows.Forms;
using CSSParserWindowsFormsApp.Views;
using CSSParserWindowsFormsApp.Presenters;
using CSSParserWindowsFormsApp.Models;

namespace CSSParserWindowsFormsApp
{
    public partial class CSSParserForm : Form, ICSSParserForm
    {

        public static SelectorProperty selectorProperty = new SelectorProperty();
        public static string inputPath = "";
        public static string outputPath = "";

        public CSSParserForm()
        {
            InitializeComponent();
        }

        public string InputFilePathText { get { return textBoxInputFile.Text; } set { textBoxInputFile.Text = value; } }
        public string OutputFilePathText { get { return textBoxOutputFile.Text; } set { textBoxOutputFile.Text = value; } }

        private void CSSParserForm_Load(object sender, EventArgs e)
        {
            progressBarInputFile.Visible = false;
        }

        private void ButtonInputFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogInput.ShowDialog() == DialogResult.OK)
            {
                InputFilePathText = openFileDialogInput.FileName;
            }
        }

        private void ButtonOutputFile_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialogOutput.ShowDialog() == DialogResult.OK)
            {
                OutputFilePathText = folderBrowserDialogOutput.SelectedPath;
            }
        }

        private void ButtonCancle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?", "My First Application",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBarInputFile.Value += 10;
            if (progressBarInputFile.Value > 99)
            {
                ShowAndUpdateForm showAndUpdate = new ShowAndUpdateForm();
                showAndUpdate.Show();
                this.Hide();
                timer1.Enabled = false;
            }
        }

        private void ButtonParseCSS_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(InputFilePathText) && !string.IsNullOrEmpty(OutputFilePathText))
            {
                /*using (ResXResourceWriter writer = new ResXResourceWriter(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName.Replace("\\bin", "\\Properties\\Resources.resx")))
                {
                    writer.AddResource("inputFilePath", InputFilePathText);
                    writer.AddResource("outputFilePath", OutputFilePathText);
                    writer.Generate();
                }*/
                labelError.Text = "";
                inputPath = InputFilePathText;
                outputPath = OutputFilePathText;
                progressBarInputFile.Visible = true;
                timer1.Enabled = true;
                CSSParserPresenter cSSParserPresenter = new CSSParserPresenter(this);
                selectorProperty.List =  cSSParserPresenter.Parser();
            }
            else
            {
                labelError.Text = "Please browse valid .css file or output file directory.";
            }
        }

    }
}