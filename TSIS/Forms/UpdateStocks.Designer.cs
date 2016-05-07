namespace TSIS
{
    partial class UpdateStocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStocks));
            this.ReorderGroupBox = new System.Windows.Forms.GroupBox();
            this.ProcessAllButton = new System.Windows.Forms.Button();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.ReorderComboBox = new System.Windows.Forms.ComboBox();
            this.WrenchesNumericBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ManualRestockGroupBox = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.RestockButton = new System.Windows.Forms.Button();
            this.PliersNumericBox = new System.Windows.Forms.NumericUpDown();
            this.SocketsNumericBox = new System.Windows.Forms.NumericUpDown();
            this.HammersNumericBox = new System.Windows.Forms.NumericUpDown();
            this.RatchetsNumericBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReorderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WrenchesNumericBox)).BeginInit();
            this.ManualRestockGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PliersNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SocketsNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HammersNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RatchetsNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ReorderGroupBox
            // 
            this.ReorderGroupBox.Controls.Add(this.ProcessAllButton);
            this.ReorderGroupBox.Controls.Add(this.ProcessButton);
            this.ReorderGroupBox.Controls.Add(this.ReorderComboBox);
            this.ReorderGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ReorderGroupBox.Name = "ReorderGroupBox";
            this.ReorderGroupBox.Size = new System.Drawing.Size(260, 78);
            this.ReorderGroupBox.TabIndex = 0;
            this.ReorderGroupBox.TabStop = false;
            this.ReorderGroupBox.Text = "Reorders";
            // 
            // ProcessAllButton
            // 
            this.ProcessAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProcessAllButton.Location = new System.Drawing.Point(179, 48);
            this.ProcessAllButton.Name = "ProcessAllButton";
            this.ProcessAllButton.Size = new System.Drawing.Size(75, 23);
            this.ProcessAllButton.TabIndex = 2;
            this.ProcessAllButton.Text = "Process All";
            this.ProcessAllButton.UseVisualStyleBackColor = true;
            this.ProcessAllButton.Click += new System.EventHandler(this.ProcessAllButton_Click);
            // 
            // ProcessButton
            // 
            this.ProcessButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProcessButton.Location = new System.Drawing.Point(6, 48);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(75, 23);
            this.ProcessButton.TabIndex = 1;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // ReorderComboBox
            // 
            this.ReorderComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReorderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReorderComboBox.FormattingEnabled = true;
            this.ReorderComboBox.Location = new System.Drawing.Point(7, 21);
            this.ReorderComboBox.Name = "ReorderComboBox";
            this.ReorderComboBox.Size = new System.Drawing.Size(247, 21);
            this.ReorderComboBox.TabIndex = 0;
            // 
            // WrenchesNumericBox
            // 
            this.WrenchesNumericBox.Location = new System.Drawing.Point(73, 22);
            this.WrenchesNumericBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.WrenchesNumericBox.Name = "WrenchesNumericBox";
            this.WrenchesNumericBox.Size = new System.Drawing.Size(181, 22);
            this.WrenchesNumericBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wrenches:";
            // 
            // ManualRestockGroupBox
            // 
            this.ManualRestockGroupBox.Controls.Add(this.ResetButton);
            this.ManualRestockGroupBox.Controls.Add(this.RestockButton);
            this.ManualRestockGroupBox.Controls.Add(this.PliersNumericBox);
            this.ManualRestockGroupBox.Controls.Add(this.SocketsNumericBox);
            this.ManualRestockGroupBox.Controls.Add(this.HammersNumericBox);
            this.ManualRestockGroupBox.Controls.Add(this.RatchetsNumericBox);
            this.ManualRestockGroupBox.Controls.Add(this.WrenchesNumericBox);
            this.ManualRestockGroupBox.Controls.Add(this.label6);
            this.ManualRestockGroupBox.Controls.Add(this.label5);
            this.ManualRestockGroupBox.Controls.Add(this.label4);
            this.ManualRestockGroupBox.Controls.Add(this.label3);
            this.ManualRestockGroupBox.Controls.Add(this.label2);
            this.ManualRestockGroupBox.Location = new System.Drawing.Point(12, 96);
            this.ManualRestockGroupBox.Name = "ManualRestockGroupBox";
            this.ManualRestockGroupBox.Size = new System.Drawing.Size(260, 191);
            this.ManualRestockGroupBox.TabIndex = 3;
            this.ManualRestockGroupBox.TabStop = false;
            this.ManualRestockGroupBox.Text = "Manual Restock";
            // 
            // ResetButton
            // 
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Location = new System.Drawing.Point(179, 162);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 19;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // RestockButton
            // 
            this.RestockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestockButton.Location = new System.Drawing.Point(6, 162);
            this.RestockButton.Name = "RestockButton";
            this.RestockButton.Size = new System.Drawing.Size(75, 23);
            this.RestockButton.TabIndex = 18;
            this.RestockButton.Text = "Restock";
            this.RestockButton.UseVisualStyleBackColor = true;
            this.RestockButton.Click += new System.EventHandler(this.RestockButton_Click);
            // 
            // PliersNumericBox
            // 
            this.PliersNumericBox.Location = new System.Drawing.Point(73, 134);
            this.PliersNumericBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.PliersNumericBox.Name = "PliersNumericBox";
            this.PliersNumericBox.Size = new System.Drawing.Size(181, 22);
            this.PliersNumericBox.TabIndex = 17;
            // 
            // SocketsNumericBox
            // 
            this.SocketsNumericBox.Location = new System.Drawing.Point(73, 106);
            this.SocketsNumericBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SocketsNumericBox.Name = "SocketsNumericBox";
            this.SocketsNumericBox.Size = new System.Drawing.Size(181, 22);
            this.SocketsNumericBox.TabIndex = 16;
            // 
            // HammersNumericBox
            // 
            this.HammersNumericBox.Location = new System.Drawing.Point(73, 78);
            this.HammersNumericBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.HammersNumericBox.Name = "HammersNumericBox";
            this.HammersNumericBox.Size = new System.Drawing.Size(181, 22);
            this.HammersNumericBox.TabIndex = 15;
            // 
            // RatchetsNumericBox
            // 
            this.RatchetsNumericBox.Location = new System.Drawing.Point(73, 50);
            this.RatchetsNumericBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.RatchetsNumericBox.Name = "RatchetsNumericBox";
            this.RatchetsNumericBox.Size = new System.Drawing.Size(181, 22);
            this.RatchetsNumericBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hammers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pliers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sockets:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ratchets:";
            // 
            // UpdateStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 293);
            this.Controls.Add(this.ManualRestockGroupBox);
            this.Controls.Add(this.ReorderGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdateStocks";
            this.Text = "Update Stocks";
            this.Load += new System.EventHandler(this.UpdateStocks_Load);
            this.ReorderGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WrenchesNumericBox)).EndInit();
            this.ManualRestockGroupBox.ResumeLayout(false);
            this.ManualRestockGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PliersNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SocketsNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HammersNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RatchetsNumericBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ReorderGroupBox;
        private System.Windows.Forms.Button ProcessAllButton;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.ComboBox ReorderComboBox;
        private System.Windows.Forms.NumericUpDown WrenchesNumericBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox ManualRestockGroupBox;
        private System.Windows.Forms.Button RestockButton;
        private System.Windows.Forms.NumericUpDown PliersNumericBox;
        private System.Windows.Forms.NumericUpDown SocketsNumericBox;
        private System.Windows.Forms.NumericUpDown HammersNumericBox;
        private System.Windows.Forms.NumericUpDown RatchetsNumericBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ResetButton;
    }
}