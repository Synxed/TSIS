using System;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using TSIS.Properties;

namespace TSIS
{
    public partial class MRN : Form
    {
        public MRN()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (UnitNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter a valid Unit Name.", "Invalid Unit Name", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (OleDbConnection connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();
                    var command =
                        "INSERT INTO MRN (UnitName, RequestDate, Wrenches, Ratchets, Hammers, Sockets, Pliers, Processed)" +
                        "Values (@UnitName, @RequestDate, @Wrenches, @Ratchets, @Hammers, @Sockets, @Pliers, @Processed)";

                    using (var newMRNCommand = new OleDbCommand(command, connection))
                    {
                        newMRNCommand.Parameters.AddWithValue("@UnitName", UnitNameTextBox.Text);
                        newMRNCommand.Parameters.AddWithValue("@RequestDate", DateTime.Today.ToString("G"));
                        newMRNCommand.Parameters.AddWithValue("@Wrenches", WrenchesNumericBox.Value);
                        newMRNCommand.Parameters.AddWithValue("@Ratchets", RatchetsNumericBox.Value);
                        newMRNCommand.Parameters.AddWithValue("@Hammers", HammersNumericBox.Value);
                        newMRNCommand.Parameters.AddWithValue("@Sockets", SocketsNumericBox.Value);
                        newMRNCommand.Parameters.AddWithValue("@Pliers", PliersNumericBox.Value);
                        newMRNCommand.Parameters.AddWithValue("@Processed", false);

                        newMRNCommand.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("The MRN has been successfully generated and added to the database.",
                    "MRN Generation Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Report.Writer = $"{DateTime.Now.ToShortTimeString()}: (MRN Generated) " +
                                $"{UnitNameTextBox.Text} | {DateTime.Today.ToString("d")} - " +
                                $"{WrenchesNumericBox.Value} Wrenches, {RatchetsNumericBox.Value} Ratchets, " +
                                $"{HammersNumericBox.Value} Hammers, {SocketsNumericBox.Value} Sockets, " +
                                $"{PliersNumericBox.Value} Pliers";
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            UnitNameTextBox.Clear();
            foreach (var numericBox in RequiredToolsGroupBox.Controls.OfType<NumericUpDown>())
                numericBox.Value = numericBox.Minimum;
        }
    }
}
