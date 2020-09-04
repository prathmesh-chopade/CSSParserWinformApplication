namespace CSSParserWindowsFormsApp.Views
{
    partial class PopupUpdateForm
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
            this.textBoxSelectorUp = new System.Windows.Forms.TextBox();
            this.textBoxAttributeUp = new System.Windows.Forms.TextBox();
            this.textBoxValueUp = new System.Windows.Forms.TextBox();
            this.labelSelectorUp = new System.Windows.Forms.Label();
            this.labelAttributeUp = new System.Windows.Forms.Label();
            this.labelValueUp = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSelectorUp
            // 
            this.textBoxSelectorUp.Location = new System.Drawing.Point(98, 14);
            this.textBoxSelectorUp.Name = "textBoxSelectorUp";
            this.textBoxSelectorUp.Size = new System.Drawing.Size(147, 20);
            this.textBoxSelectorUp.TabIndex = 0;
            // 
            // textBoxAttributeUp
            // 
            this.textBoxAttributeUp.Location = new System.Drawing.Point(98, 52);
            this.textBoxAttributeUp.Name = "textBoxAttributeUp";
            this.textBoxAttributeUp.Size = new System.Drawing.Size(147, 20);
            this.textBoxAttributeUp.TabIndex = 1;
            // 
            // textBoxValueUp
            // 
            this.textBoxValueUp.Location = new System.Drawing.Point(98, 93);
            this.textBoxValueUp.Name = "textBoxValueUp";
            this.textBoxValueUp.Size = new System.Drawing.Size(147, 20);
            this.textBoxValueUp.TabIndex = 2;
            // 
            // labelSelectorUp
            // 
            this.labelSelectorUp.AutoSize = true;
            this.labelSelectorUp.Location = new System.Drawing.Point(26, 17);
            this.labelSelectorUp.Name = "labelSelectorUp";
            this.labelSelectorUp.Size = new System.Drawing.Size(46, 13);
            this.labelSelectorUp.TabIndex = 3;
            this.labelSelectorUp.Text = "Selector";
            // 
            // labelAttributeUp
            // 
            this.labelAttributeUp.AutoSize = true;
            this.labelAttributeUp.Location = new System.Drawing.Point(26, 55);
            this.labelAttributeUp.Name = "labelAttributeUp";
            this.labelAttributeUp.Size = new System.Drawing.Size(49, 13);
            this.labelAttributeUp.TabIndex = 4;
            this.labelAttributeUp.Text = "Attributte";
            // 
            // labelValueUp
            // 
            this.labelValueUp.AutoSize = true;
            this.labelValueUp.Location = new System.Drawing.Point(26, 96);
            this.labelValueUp.Name = "labelValueUp";
            this.labelValueUp.Size = new System.Drawing.Size(34, 13);
            this.labelValueUp.TabIndex = 5;
            this.labelValueUp.Text = "Value";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonUpdate.Location = new System.Drawing.Point(170, 126);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // PopupUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelValueUp);
            this.Controls.Add(this.labelAttributeUp);
            this.Controls.Add(this.labelSelectorUp);
            this.Controls.Add(this.textBoxValueUp);
            this.Controls.Add(this.textBoxAttributeUp);
            this.Controls.Add(this.textBoxSelectorUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PopupUpdateForm";
            this.Text = "Update Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSelectorUp;
        private System.Windows.Forms.TextBox textBoxAttributeUp;
        private System.Windows.Forms.TextBox textBoxValueUp;
        private System.Windows.Forms.Label labelSelectorUp;
        private System.Windows.Forms.Label labelAttributeUp;
        private System.Windows.Forms.Label labelValueUp;
        private System.Windows.Forms.Button buttonUpdate;
    }
}