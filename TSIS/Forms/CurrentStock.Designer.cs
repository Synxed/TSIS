namespace TSIS
{
    partial class CurrentStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentStock));
            this.label1 = new System.Windows.Forms.Label();
            this.WrenchesLabel = new System.Windows.Forms.Label();
            this.RatchetsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SocketsLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PliersLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HammersLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.StockChecker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wrenches:";
            // 
            // WrenchesLabel
            // 
            this.WrenchesLabel.AutoSize = true;
            this.WrenchesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrenchesLabel.Location = new System.Drawing.Point(13, 26);
            this.WrenchesLabel.Name = "WrenchesLabel";
            this.WrenchesLabel.Size = new System.Drawing.Size(16, 17);
            this.WrenchesLabel.TabIndex = 2;
            this.WrenchesLabel.Text = "0";
            // 
            // RatchetsLabel
            // 
            this.RatchetsLabel.AutoSize = true;
            this.RatchetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatchetsLabel.Location = new System.Drawing.Point(13, 66);
            this.RatchetsLabel.Name = "RatchetsLabel";
            this.RatchetsLabel.Size = new System.Drawing.Size(16, 17);
            this.RatchetsLabel.TabIndex = 5;
            this.RatchetsLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ratchets:";
            // 
            // SocketsLabel
            // 
            this.SocketsLabel.AutoSize = true;
            this.SocketsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SocketsLabel.Location = new System.Drawing.Point(115, 26);
            this.SocketsLabel.Name = "SocketsLabel";
            this.SocketsLabel.Size = new System.Drawing.Size(16, 17);
            this.SocketsLabel.TabIndex = 9;
            this.SocketsLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Sockets:";
            // 
            // PliersLabel
            // 
            this.PliersLabel.AutoSize = true;
            this.PliersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PliersLabel.Location = new System.Drawing.Point(115, 66);
            this.PliersLabel.Name = "PliersLabel";
            this.PliersLabel.Size = new System.Drawing.Size(16, 17);
            this.PliersLabel.TabIndex = 11;
            this.PliersLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pliers:";
            // 
            // HammersLabel
            // 
            this.HammersLabel.AutoSize = true;
            this.HammersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HammersLabel.Location = new System.Drawing.Point(13, 105);
            this.HammersLabel.Name = "HammersLabel";
            this.HammersLabel.Size = new System.Drawing.Size(16, 17);
            this.HammersLabel.TabIndex = 13;
            this.HammersLabel.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Hammers:";
            // 
            // StockChecker
            // 
            this.StockChecker.Enabled = true;
            this.StockChecker.Tick += new System.EventHandler(this.StockChecker_Tick);
            // 
            // CurrentStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 132);
            this.Controls.Add(this.HammersLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PliersLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SocketsLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RatchetsLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WrenchesLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CurrentStock";
            this.Text = "Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WrenchesLabel;
        private System.Windows.Forms.Label RatchetsLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SocketsLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PliersLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label HammersLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer StockChecker;
    }
}