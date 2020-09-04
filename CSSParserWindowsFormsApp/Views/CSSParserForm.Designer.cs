namespace CSSParserWindowsFormsApp
{
    partial class CSSParserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelnputFile = new System.Windows.Forms.Label();
            this.textBoxInputFile = new System.Windows.Forms.TextBox();
            this.textBoxOutputFile = new System.Windows.Forms.TextBox();
            this.labelOutputFile = new System.Windows.Forms.Label();
            this.buttonInputFile = new System.Windows.Forms.Button();
            this.buttonOutputFile = new System.Windows.Forms.Button();
            this.openFileDialogInput = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogOutput = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonParseCSS = new System.Windows.Forms.Button();
            this.buttonCancle = new System.Windows.Forms.Button();
            this.progressBarInputFile = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelnputFile
            // 
            this.labelnputFile.AutoSize = true;
            this.labelnputFile.Location = new System.Drawing.Point(23, 108);
            this.labelnputFile.Name = "labelnputFile";
            this.labelnputFile.Size = new System.Drawing.Size(50, 13);
            this.labelnputFile.TabIndex = 0;
            this.labelnputFile.Text = "Input File";
            // 
            // textBoxInputFile
            // 
            this.textBoxInputFile.Location = new System.Drawing.Point(133, 105);
            this.textBoxInputFile.Name = "textBoxInputFile";
            this.textBoxInputFile.Size = new System.Drawing.Size(370, 20);
            this.textBoxInputFile.TabIndex = 1;
            // 
            // textBoxOutputFile
            // 
            this.textBoxOutputFile.Location = new System.Drawing.Point(133, 153);
            this.textBoxOutputFile.Name = "textBoxOutputFile";
            this.textBoxOutputFile.Size = new System.Drawing.Size(370, 20);
            this.textBoxOutputFile.TabIndex = 3;
            // 
            // labelOutputFile
            // 
            this.labelOutputFile.AutoSize = true;
            this.labelOutputFile.Location = new System.Drawing.Point(23, 156);
            this.labelOutputFile.Name = "labelOutputFile";
            this.labelOutputFile.Size = new System.Drawing.Size(86, 13);
            this.labelOutputFile.TabIndex = 2;
            this.labelOutputFile.Text = "Store Output File";
            // 
            // buttonInputFile
            // 
            this.buttonInputFile.Location = new System.Drawing.Point(509, 101);
            this.buttonInputFile.Name = "buttonInputFile";
            this.buttonInputFile.Size = new System.Drawing.Size(26, 26);
            this.buttonInputFile.TabIndex = 4;
            this.buttonInputFile.Text = "...";
            this.buttonInputFile.UseVisualStyleBackColor = true;
            this.buttonInputFile.Click += new System.EventHandler(this.ButtonInputFile_Click);
            // 
            // buttonOutputFile
            // 
            this.buttonOutputFile.Location = new System.Drawing.Point(509, 149);
            this.buttonOutputFile.Name = "buttonOutputFile";
            this.buttonOutputFile.Size = new System.Drawing.Size(26, 26);
            this.buttonOutputFile.TabIndex = 5;
            this.buttonOutputFile.Text = "...";
            this.buttonOutputFile.UseVisualStyleBackColor = true;
            this.buttonOutputFile.Click += new System.EventHandler(this.ButtonOutputFile_Click);
            // 
            // openFileDialogInput
            // 
            this.openFileDialogInput.DefaultExt = "css";
            this.openFileDialogInput.Filter = "CSS files (css)|*.css";
            this.openFileDialogInput.InitialDirectory = "C:\\Users\\Hp\\Desktop";
            // 
            // folderBrowserDialogOutput
            // 
            this.folderBrowserDialogOutput.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // buttonParseCSS
            // 
            this.buttonParseCSS.Location = new System.Drawing.Point(119, 309);
            this.buttonParseCSS.Name = "buttonParseCSS";
            this.buttonParseCSS.Size = new System.Drawing.Size(124, 34);
            this.buttonParseCSS.TabIndex = 6;
            this.buttonParseCSS.Text = "Parse CSS file";
            this.buttonParseCSS.UseVisualStyleBackColor = true;
            this.buttonParseCSS.Click += new System.EventHandler(this.ButtonParseCSS_Click);
            // 
            // buttonCancle
            // 
            this.buttonCancle.Location = new System.Drawing.Point(372, 309);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(75, 34);
            this.buttonCancle.TabIndex = 7;
            this.buttonCancle.Text = "Cancel";
            this.buttonCancle.UseVisualStyleBackColor = true;
            this.buttonCancle.Click += new System.EventHandler(this.ButtonCancle_Click);
            // 
            // progressBarInputFile
            // 
            this.progressBarInputFile.BackColor = System.Drawing.Color.Lime;
            this.progressBarInputFile.Location = new System.Drawing.Point(73, 236);
            this.progressBarInputFile.Name = "progressBarInputFile";
            this.progressBarInputFile.Size = new System.Drawing.Size(430, 23);
            this.progressBarInputFile.TabIndex = 9;
            this.progressBarInputFile.UseWaitCursor = true;
            this.progressBarInputFile.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelError.Location = new System.Drawing.Point(163, 250);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 19);
            this.labelError.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "CSS Parser";
            // 
            // CSSParserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(566, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.progressBarInputFile);
            this.Controls.Add(this.buttonCancle);
            this.Controls.Add(this.buttonParseCSS);
            this.Controls.Add(this.buttonOutputFile);
            this.Controls.Add(this.buttonInputFile);
            this.Controls.Add(this.textBoxOutputFile);
            this.Controls.Add(this.labelOutputFile);
            this.Controls.Add(this.textBoxInputFile);
            this.Controls.Add(this.labelnputFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CSSParserForm";
            this.Text = "CSS Parser";
            this.Load += new System.EventHandler(this.CSSParserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnputFile;
        private System.Windows.Forms.TextBox textBoxInputFile;
        private System.Windows.Forms.TextBox textBoxOutputFile;
        private System.Windows.Forms.Label labelOutputFile;
        private System.Windows.Forms.Button buttonInputFile;
        private System.Windows.Forms.Button buttonOutputFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogInput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOutput;
        private System.Windows.Forms.Button buttonParseCSS;
        private System.Windows.Forms.Button buttonCancle;
        private System.Windows.Forms.ProgressBar progressBarInputFile;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label1;
    }
}

