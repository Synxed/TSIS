using System;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TSIS.Properties;

namespace TSIS
{
    public partial class UpdateStocks : Form
    {
        public UpdateStocks()
        {
            InitializeComponent();
        }

        private void UpdateStocks_Load(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();
                    using (var fetchMRNCommand = new OleDbCommand("SELECT * FROM Reorders WHERE Processed = 0", connection))
                    using (var reader = fetchMRNCommand.ExecuteReader())
                    {
                        while (reader != null && reader.Read())
                        {
                            var item = new StringBuilder();
                            item.Append(reader["ReorderTime"] + " - ");
                            if (int.Parse(reader["Wrenches"].ToString()) > 0) item.Append($"W{reader["Wrenches"]} ");
                            if (int.Parse(reader["Ratchets"].ToString()) > 0) item.Append($"R{reader["Ratchets"]} ");
                            if (int.Parse(reader["Hammers"].ToString()) > 0) item.Append($"H{reader["Hammers"]} ");
                            if (int.Parse(reader["Sockets"].ToString()) > 0) item.Append($"S{reader["Sockets"]} ");
                            if (int.Parse(reader["Pliers"].ToString()) > 0) item.Append($"P{reader["Pliers"]}");

                            ReorderComboBox.Items.Add(item.ToString().Trim());
                        }        
                    }

                    CheckReorderAvailability();
                    ReorderComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            if (ProcessReorder(ReorderComboBox.SelectedItem.ToString().Split('-')[0].Trim()))
            {
                ReorderComboBox.Items.RemoveAt(ReorderComboBox.SelectedIndex);
                if (CheckReorderAvailability())
                    ReorderComboBox.SelectedIndex = 0;

                MessageBox.Show("The Reorder has been successfully processed!", "Reorder Processed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ProcessAllButton_Click(object sender, EventArgs e)
        {
            if (ReorderComboBox.Items.Cast<string>().Any(reorder => !ProcessReorder(reorder.Split('-')[0].Trim())))
            {
                return;
            } 

            ReorderComboBox.Items.Clear();
            CheckReorderAvailability();

            MessageBox.Show("All reorders have been successfully processed.", "Reorders Processed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RestockButton_Click(object sender, EventArgs e)
        {
            try
            {
                Stock.Restock((int)WrenchesNumericBox.Value,
                               (int)RatchetsNumericBox.Value,
                               (int)HammersNumericBox.Value,
                               (int)SocketsNumericBox.Value,
                               (int)PliersNumericBox.Value);

                MessageBox.Show("Successfully Restocked!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            foreach (var numericBox in ManualRestockGroupBox.Controls.OfType<NumericUpDown>())
                numericBox.Value = numericBox.Minimum;
        }

        private bool ProcessReorder(string time)
        {
            try
            {
                using (var connection = new OleDbConnection(Resources.ConnectionString))
                {
                    connection.Open();
                    using (var fetchReorderData = new OleDbCommand($"SELECT * FROM Reorders WHERE ReorderTime = '{time}'", connection))
                    using (var reader = fetchReorderData.ExecuteReader())
                    {
                        if (reader == null) return false;
                        reader.Read();
                        
                        Stock.Restock(int.Parse(reader["Wrenches"].ToString()),
                            int.Parse(reader["Ratchets"].ToString()),
                            int.Parse(reader["Hammers"].ToString()),
                            int.Parse(reader["Sockets"].ToString()),
                            int.Parse(reader["Pliers"].ToString()));
                    }

                    using (var processRowCommand = new OleDbCommand("UPDATE Reorders SET Processed = @processed WHERE ReorderTime = @time", connection))
                    {
                        processRowCommand.Parameters.AddWithValue("@processed", true);
                        processRowCommand.Parameters.AddWithValue("@time", time);

                        processRowCommand.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occured!" + Environment.NewLine + Environment.NewLine + exception.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        private bool CheckReorderAvailability()
        {
            if (ReorderComboBox.Items.Count != 0) return true;

            ReorderComboBox.Items.Add("No Unprocessed Reorder Avalaible");
            ReorderComboBox.SelectedIndex = 0;
            ReorderGroupBox.Enabled = false;
            return false;
        }
    }
}
