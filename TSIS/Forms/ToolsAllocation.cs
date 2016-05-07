using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TSIS.Properties;

namespace TSIS
{
    public partial class ToolsAllocation : Form
    {
        public ToolsAllocation()
        {
            InitializeComponent();
        }

        private void ToolsAllocation_Load(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();
                    using (var fetchMRNCommand = new OleDbCommand("SELECT * FROM MRN WHERE Processed = 0", connection))
                    using (var reader = fetchMRNCommand.ExecuteReader())
                    {
                        while (reader != null && reader.Read())
                            MRNComboBox.Items.Add($"{reader["UnitName"]} - {reader["RequestDate"]}");
                    }

                    CheckMRNAvailability();
                    MRNComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AllocateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var unitName = MRNComboBox.SelectedItem.ToString().Split('-')[0].Trim();
                var requestDate = MRNComboBox.SelectedItem.ToString().Split('-')[1].Trim();
                var requiredToolsQuantities = new List<int>();

                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();
                    using (var fetchData = new OleDbCommand("SELECT * FROM MRN", connection))
                    using (var reader = fetchData.ExecuteReader())
                    {
                        while (reader != null && reader.Read())
                        {
                            if (reader["UnitName"].ToString() == unitName &&
                                reader["RequestDate"].ToString() == requestDate &&
                                bool.Parse(reader["Processed"].ToString()) == false)
                            {
                                requiredToolsQuantities.Add(int.Parse(reader["Wrenches"].ToString()));
                                requiredToolsQuantities.Add(int.Parse(reader["Ratchets"].ToString()));
                                requiredToolsQuantities.Add(int.Parse(reader["Hammers"].ToString()));
                                requiredToolsQuantities.Add(int.Parse(reader["Sockets"].ToString()));
                                requiredToolsQuantities.Add(int.Parse(reader["Pliers"].ToString()));
                            }
                        }              
                    }

                    CreateReport(Stock.GetCurrentStock(), requiredToolsQuantities, unitName, requestDate);
                }

                CheckMRNAvailability();
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReportTextBox_DoubleClick(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text File (*.txt)|*.txt";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, ReportTextBox.Text);
                    MessageBox.Show("Report successfully exported to " + saveFileDialog.FileName,
                        "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }      
            }
        }

        private void CreateReport(List<int> stock, List<int> required , string unitName, string requestDate)
        {
            var reportWriter = new StringBuilder();

            reportWriter.AppendLine("Material Request Note (MRN) Report");
            reportWriter.AppendLine(new string('=', "Material Request Note (MRN) Report".Length) + Environment.NewLine);
            reportWriter.AppendLine("Requested By: " + unitName);
            reportWriter.AppendLine("Requested On: " + requestDate + Environment.NewLine);

            reportWriter.AppendLine("Required Tools:");
            reportWriter.AppendLine(new string('-', "Required Tools:".Length) + Environment.NewLine);
            reportWriter.AppendLine("Wrenches: " + required[0]);
            reportWriter.AppendLine("Ratchets: " + required[1]);
            reportWriter.AppendLine("Hammers: " + required[2]);
            reportWriter.AppendLine("Sockets: " + required[3]);
            reportWriter.AppendLine("Pliers: " + required[4] + Environment.NewLine);

            reportWriter.AppendLine("Avalaible in Stock:");
            reportWriter.AppendLine(new string('-', "Avalaible in Stock:".Length) + Environment.NewLine);
            reportWriter.AppendLine("Wrenches: " + stock[0]);
            reportWriter.AppendLine("Ratchets: " + stock[1]);
            reportWriter.AppendLine("Hammers: " + stock[2]);
            reportWriter.AppendLine("Sockets: " + stock[3]);
            reportWriter.AppendLine("Pliers: " + stock[4] + Environment.NewLine);

            if (IsSufficient(stock, required))
            {
                reportWriter.AppendLine("The request cannot be processed due to the following insufficient tools:" + Environment.NewLine);
                if (required[0] > stock[0]) reportWriter.AppendLine($"Wrenches: {required[0] - stock[0]} Lacking");
                if (required[1] > stock[1]) reportWriter.AppendLine($"Ratchets: {required[1] - stock[1]} Lacking");
                if (required[2] > stock[2]) reportWriter.AppendLine($"Hammers: {required[2] - stock[2]} Lacking");
                if (required[3] > stock[3]) reportWriter.AppendLine($"Sockets: {required[3] - stock[3]} Lacking");
                if (required[4] > stock[4]) reportWriter.AppendLine($"Pliers: {required[4] - stock[4]} Lacking");  
            }
            else
            {
                reportWriter.AppendLine("The request has been processed!" + Environment.NewLine);
                List<int> difference = GetDifference(stock, required);
                Stock.Update(difference[0], difference[1], difference[2], difference[3], difference[4]);
                stock = Stock.GetCurrentStock();

                reportWriter.AppendLine("Current Stock:");
                reportWriter.AppendLine(new string('-', "Avalaible in Stock:".Length) + Environment.NewLine);
                reportWriter.AppendLine("Wrenches: " + stock[0]);
                reportWriter.AppendLine("Ratchets: " + stock[1]);
                reportWriter.AppendLine("Hammers: " + stock[2]);
                reportWriter.AppendLine("Sockets: " + stock[3]);
                reportWriter.AppendLine("Pliers: " + stock[4] + Environment.NewLine);

                RemoveProcessedMRN(unitName, requestDate);
                if (CheckMRNAvailability())
                    MRNComboBox.SelectedIndex = 0;
                Stock.Reorder();
            }

            ReportTextBox.Text = reportWriter.ToString();
        }

        private static bool IsSufficient(List<int> stock, List<int> required)
        {
            return stock.Where((t, index) => t < required[index]).Any();
        }

        private static List<int> GetDifference(List<int> stock, List<int> required)
        {
            return stock.Select((t, index) => t - required[index]).ToList();
        }

        private void RemoveProcessedMRN(string unitName, string requestDate)
        {
            using (var connection = new OleDbConnection(Resources.ConnectionString))
            {
                connection.Open();
                var command = "UPDATE MRN SET Processed = @processed WHERE UnitName = @name AND RequestDate = @date";
                using (var processRowCommand = new OleDbCommand(command, connection))
                {
                    processRowCommand.Parameters.AddWithValue("@processed", true);
                    processRowCommand.Parameters.AddWithValue("@name", unitName);
                    processRowCommand.Parameters.AddWithValue("@date", requestDate);

                    processRowCommand.ExecuteNonQuery();
                }
            }
            MRNComboBox.Items.RemoveAt(MRNComboBox.SelectedIndex);
        }

        private bool CheckMRNAvailability()
        {
            if (MRNComboBox.Items.Count != 0) return true;

            MRNComboBox.Items.Add("No Unprocessed MRN Avalaible");
            MRNComboBox.SelectedIndex = 0;
            MRNComboBox.Enabled = false;
            AllocateButton.Enabled = false;
            return false;
        }
    }
}