using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TSIS
{
    public partial class MainForm : Form
    {
        private bool _isAdmin;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            CredentialGroupBox.Enabled = false;

            if (UsernameTextBox.Text == "Admin" && PasswordTextBox.Text == "Password")
            {
                OperationsGroupBox.Enabled = true;
                _isAdmin = true;
            }
            else
            {
                OperationsGroupBox.Enabled = true;
                foreach (Control control in OperationsGroupBox.Controls.Cast<Control>().Where(control => control.Tag.ToString() != "UserAccess"))
                    control.Enabled = false;
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            var selectedOperation = OperationsGroupBox.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            switch (selectedOperation.Name)
            {
                case "MRNGeneratorRadioButton":
                    new MRN().Show();
                    break;

                case "ToolsAllocationRadioButton":
                    new ToolsAllocation().Show();
                    break;

                case "UpdateStocksRadioButton":
                    new UpdateStocks().Show();
                    break;

                case "ChangeReorderRadioButton":
                    new ChangeReorderLevel().Show();
                    break;

                case "CheckStockRadioButton":
                    new CurrentStock().Show();
                    break;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            LoginButton.Enabled = !(UsernameTextBox.Text == string.Empty || PasswordTextBox.Text == string.Empty);
        }

        private void AboutStatusStripLabel_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var currentStock = Stock.GetCurrentStock();

            Report.Writer = "Report of Tool Stores Inventory System";
            Report.Writer = new string('=', "Report of Tool Stores Inventory System".Length) + Environment.NewLine;
            Report.Writer = $"Date: {DateTime.Today.ToString("D")}" + Environment.NewLine;
            Report.Writer = $"Stock: {currentStock[0]} Wrenches, " +
                            $"{currentStock[1]} Ratchets, {currentStock[2]} Hammers," +
                            $"{currentStock[3]} Sockets, {currentStock[4]} Pliers{Environment.NewLine}";

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isAdmin) return;

            var saveReport = MessageBox.Show("Export session report?", "Session Report",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (saveReport == DialogResult.Yes)
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text File (*.txt)|*.txt";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var currentStock = Stock.GetCurrentStock();

                        Report.Writer = $"{Environment.NewLine}Final Stock: {currentStock[0]} Wrenches, " +
                            $"{currentStock[1]} Ratchets, {currentStock[2]} Hammers," +
                            $"{currentStock[3]} Sockets, {currentStock[4]} Pliers";

                        File.WriteAllText(saveFileDialog.FileName, Report.Writer);
                        MessageBox.Show("Report successfully exported to " + saveFileDialog.FileName,
                            "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
