using System;
using System.Windows.Forms;

namespace TSIS
{
    public partial class CurrentStock : Form
    {
        public CurrentStock()
        {
            InitializeComponent();
        }

        private void StockChecker_Tick(object sender, EventArgs e)
        {
            var currentStock = Stock.GetCurrentStock();

            WrenchesLabel.Text = currentStock[0].ToString();
            RatchetsLabel.Text = currentStock[1].ToString();
            HammersLabel.Text = currentStock[2].ToString();
            SocketsLabel.Text = currentStock[3].ToString();
            PliersLabel.Text = currentStock[4].ToString();
        }
    }
}
