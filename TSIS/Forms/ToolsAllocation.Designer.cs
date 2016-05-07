namespace TSIS
{
    partial class ToolsAllocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolsAllocation));
            this.MRNComboBox = new System.Windows.Forms.ComboBox();
            this.AllocateButton = new System.Windows.Forms.Button();
            this.ReportTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MRNComboBox
            // 
            this.MRNComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MRNComboBox.FormattingEnabled = true;
            this.MRNComboBox.Location = new System.Drawing.Point(12, 12);
            this.MRNComboBox.Name = "MRNComboBox";
            this.MRNComboBox.Size = new System.Drawing.Size(260, 21);
            this.MRNComboBox.TabIndex = 0;
            // 
            // AllocateButton
            // 
            this.AllocateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllocateButton.Location = new System.Drawing.Point(278, 12);
            this.AllocateButton.Name = "AllocateButton";
            this.AllocateButton.Size = new System.Drawing.Size(75, 23);
            this.AllocateButton.TabIndex = 1;
            this.AllocateButton.Text = "Allocate";
            this.AllocateButton.UseVisualStyleBackColor = true;
            this.AllocateButton.Click += new System.EventHandler(this.AllocateButton_Click);
            // 
            // ReportTextBox
            // 
            this.ReportTextBox.Location = new System.Drawing.Point(12, 39);
            this.ReportTextBox.Multiline = true;
            this.ReportTextBox.Name = "ReportTextBox";
            this.ReportTextBox.ReadOnly = true;
            this.ReportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ReportTextBox.Size = new System.Drawing.Size(339, 211);
            this.ReportTextBox.TabIndex = 2;
            this.ReportTextBox.TabStop = false;
            this.ReportTextBox.DoubleClick += new System.EventHandler(this.ReportTextBox_DoubleClick);
            // 
            // ToolsAllocation
            // 
            this.AcceptButton = this.AllocateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 262);
            this.Controls.Add(this.ReportTextBox);
            this.Controls.Add(this.AllocateButton);
            this.Controls.Add(this.MRNComboBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ToolsAllocation";
            this.Text = "Tools Allocation";
            this.Load += new System.EventHandler(this.ToolsAllocation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MRNComboBox;
        private System.Windows.Forms.Button AllocateButton;
        private System.Windows.Forms.TextBox ReportTextBox;
    }
}