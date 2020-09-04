namespace CSSParserWindowsFormsApp.Views
{
    partial class ShowAndUpdateForm
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
            this.buttonCancle = new System.Windows.Forms.Button();
            this.listViewSelector = new System.Windows.Forms.ListView();
            this.Selector = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewSubSelector = new System.Windows.Forms.ListView();
            this.subAndSelector = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewKeyValue = new System.Windows.Forms.ListView();
            this.Key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonUpdateFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCancle
            // 
            this.buttonCancle.Location = new System.Drawing.Point(459, 368);
            this.buttonCancle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(63, 26);
            this.buttonCancle.TabIndex = 0;
            this.buttonCancle.Text = "Cancel";
            this.buttonCancle.UseVisualStyleBackColor = true;
            this.buttonCancle.Click += new System.EventHandler(this.ButtonCancle_Click);
            // 
            // listViewSelector
            // 
            this.listViewSelector.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Selector});
            this.listViewSelector.GridLines = true;
            this.listViewSelector.HideSelection = false;
            this.listViewSelector.Location = new System.Drawing.Point(11, 12);
            this.listViewSelector.Margin = new System.Windows.Forms.Padding(2);
            this.listViewSelector.Name = "listViewSelector";
            this.listViewSelector.Size = new System.Drawing.Size(164, 340);
            this.listViewSelector.TabIndex = 1;
            this.listViewSelector.UseCompatibleStateImageBehavior = false;
            this.listViewSelector.View = System.Windows.Forms.View.Details;
            this.listViewSelector.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewSelector_MouseClick);
            // 
            // Selector
            // 
            this.Selector.Text = "Selector";
            this.Selector.Width = 160;
            // 
            // listViewSubSelector
            // 
            this.listViewSubSelector.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.subAndSelector});
            this.listViewSubSelector.GridLines = true;
            this.listViewSubSelector.HideSelection = false;
            this.listViewSubSelector.Location = new System.Drawing.Point(183, 12);
            this.listViewSubSelector.Name = "listViewSubSelector";
            this.listViewSubSelector.Size = new System.Drawing.Size(166, 340);
            this.listViewSubSelector.TabIndex = 2;
            this.listViewSubSelector.UseCompatibleStateImageBehavior = false;
            this.listViewSubSelector.View = System.Windows.Forms.View.Details;
            this.listViewSubSelector.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewSubSelector_MouseClick);
            this.listViewSubSelector.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewSubSelector_MouseDoubleClick);
            // 
            // subAndSelector
            // 
            this.subAndSelector.Text = "Selector & Sub-Selector";
            this.subAndSelector.Width = 160;
            // 
            // listViewKeyValue
            // 
            this.listViewKeyValue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Key,
            this.Value});
            this.listViewKeyValue.GridLines = true;
            this.listViewKeyValue.HideSelection = false;
            this.listViewKeyValue.Location = new System.Drawing.Point(355, 11);
            this.listViewKeyValue.Name = "listViewKeyValue";
            this.listViewKeyValue.Size = new System.Drawing.Size(201, 340);
            this.listViewKeyValue.TabIndex = 3;
            this.listViewKeyValue.UseCompatibleStateImageBehavior = false;
            this.listViewKeyValue.View = System.Windows.Forms.View.Details;
            this.listViewKeyValue.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewKeyValue_MouseDoubleClick);
            // 
            // Key
            // 
            this.Key.Text = "Attribute";
            this.Key.Width = 90;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 105;
            // 
            // buttonUpdateFile
            // 
            this.buttonUpdateFile.Location = new System.Drawing.Point(367, 368);
            this.buttonUpdateFile.Name = "buttonUpdateFile";
            this.buttonUpdateFile.Size = new System.Drawing.Size(75, 26);
            this.buttonUpdateFile.TabIndex = 4;
            this.buttonUpdateFile.Text = "Print File";
            this.buttonUpdateFile.UseVisualStyleBackColor = true;
            this.buttonUpdateFile.Click += new System.EventHandler(this.ButtonUpdateFile_Click);
            // 
            // ShowAndUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 405);
            this.Controls.Add(this.buttonUpdateFile);
            this.Controls.Add(this.listViewKeyValue);
            this.Controls.Add(this.listViewSubSelector);
            this.Controls.Add(this.listViewSelector);
            this.Controls.Add(this.buttonCancle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowAndUpdateForm";
            this.Text = "CSS Parser";
            this.Load += new System.EventHandler(this.ShowAndUpdate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancle;
        private System.Windows.Forms.ListView listViewSelector;
        private System.Windows.Forms.ColumnHeader Selector;
        private System.Windows.Forms.ListView listViewSubSelector;
        private System.Windows.Forms.ColumnHeader subAndSelector;
        private System.Windows.Forms.ListView listViewKeyValue;
        private System.Windows.Forms.ColumnHeader Key;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.Button buttonUpdateFile;
    }
}