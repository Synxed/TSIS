namespace TSIS
{
    partial class ChangeReorderLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeReorderLevel));
            this.PliersNumericBoxP = new System.Windows.Forms.NumericUpDown();
            this.SocketsNumericBox = new System.Windows.Forms.NumericUpDown();
            this.HammersNumericBox = new System.Windows.Forms.NumericUpDown();
            this.RatchetsNumericBox = new System.Windows.Forms.NumericUpDown();
            this.WrenchesNumericBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DefaultButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PliersNumericBoxP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SocketsNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HammersNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RatchetsNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WrenchesNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PliersNumericBoxP
            // 
            this.PliersNumericBoxP.Location = new System.Drawing.Point(77, 124);
            this.PliersNumericBoxP.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.PliersNumericBoxP.Name = "PliersNumericBoxP";
            this.PliersNumericBoxP.Size = new System.Drawing.Size(181, 22);
            this.PliersNumericBoxP.TabIndex = 27;
            // 
            // SocketsNumericBox
            // 
            this.SocketsNumericBox.Location = new System.Drawing.Point(77, 96);
            this.SocketsNumericBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.SocketsNumericBox.Name = "SocketsNumericBox";
            this.SocketsNumericBox.Size = new System.Drawing.Size(181, 22);
            this.SocketsNumericBox.TabIndex = 26;
            // 
            // HammersNumericBox
            // 
            this.HammersNumericBox.Location = new System.Drawing.Point(77, 68);
            this.HammersNumericBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.HammersNumericBox.Name = "HammersNumericBox";
            this.HammersNumericBox.Size = new System.Drawing.Size(181, 22);
            this.HammersNumericBox.TabIndex = 25;
            // 
            // RatchetsNumericBox
            // 
            this.RatchetsNumericBox.Location = new System.Drawing.Point(77, 40);
            this.RatchetsNumericBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.RatchetsNumericBox.Name = "RatchetsNumericBox";
            this.RatchetsNumericBox.Size = new System.Drawing.Size(181, 22);
            this.RatchetsNumericBox.TabIndex = 24;
            // 
            // WrenchesNumericBox
            // 
            this.WrenchesNumericBox.Location = new System.Drawing.Point(77, 12);
            this.WrenchesNumericBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.WrenchesNumericBox.Name = "WrenchesNumericBox";
            this.WrenchesNumericBox.Size = new System.Drawing.Size(181, 22);
            this.WrenchesNumericBox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Hammers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Pliers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sockets:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ratchets:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Wrenches:";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.Location = new System.Drawing.Point(13, 152);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 28;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DefaultButton
            // 
            this.DefaultButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DefaultButton.Location = new System.Drawing.Point(183, 152);
            this.DefaultButton.Name = "DefaultButton";
            this.DefaultButton.Size = new System.Drawing.Size(75, 23);
            this.DefaultButton.TabIndex = 29;
            this.DefaultButton.Text = "Default";
            this.DefaultButton.UseVisualStyleBackColor = true;
            this.DefaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            // 
            // ChangeReorderLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 183);
            this.Controls.Add(this.DefaultButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.PliersNumericBoxP);
            this.Controls.Add(this.SocketsNumericBox);
            this.Controls.Add(this.HammersNumericBox);
            this.Controls.Add(this.RatchetsNumericBox);
            this.Controls.Add(this.WrenchesNumericBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangeReorderLevel";
            this.Text = "Change Reorder Level";
            this.Load += new System.EventHandler(this.ChangeReorderLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PliersNumericBoxP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SocketsNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HammersNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RatchetsNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WrenchesNumericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown PliersNumericBoxP;
        private System.Windows.Forms.NumericUpDown SocketsNumericBox;
        private System.Windows.Forms.NumericUpDown HammersNumericBox;
        private System.Windows.Forms.NumericUpDown RatchetsNumericBox;
        private System.Windows.Forms.NumericUpDown WrenchesNumericBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DefaultButton;
    }
}