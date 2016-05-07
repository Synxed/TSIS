using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using TSIS.Properties;

namespace TSIS
{
    static class Stock
    {
        public static void Restock(int wrenches, int ratchets, int hammers, int sockets, int pliers)
        {
            AddToStock(wrenches, ratchets, hammers, sockets, pliers);
        }

        public static void Update(int wrenches, int ratchets, int hammers, int sockets, int pliers)
        {
            UpdateStock(wrenches, ratchets, hammers, sockets, pliers);
        }

        public static void Reorder()
        {
            var currentStock = GetCurrentStock();
            var toolsToRestock = new List<int> {0, 0, 0, 0, 0};

            if (currentStock[0] < Settings.Default.WrenchsReorderLevel) toolsToRestock[0] = 5000;
            if (currentStock[1] < Settings.Default.RatchetsReorderLevel) toolsToRestock[1] = 5000;
            if (currentStock[2] < Settings.Default.HammersReorderLevel) toolsToRestock[2] = 5000;
            if (currentStock[3] < Settings.Default.SocketsReorderLevel) toolsToRestock[3] = 25000;
            if (currentStock[4] < Settings.Default.PliersReorderLevel) toolsToRestock[4] = 5000;

            if (!toolsToRestock.Any(tool => tool > 0)) return;

            using (OleDbConnection connection = new OleDbConnection(Resources.ConnectionString))
            {
                connection.Open();
                var command =
                    "INSERT INTO Reorders (ReorderTime, Wrenches, Ratchets, Hammers, Sockets, Pliers, Processed)" +
                    "Values (@ReorderTime, @Wrenches, @Ratchets, @Hammers, @Sockets, @Pliers, @Processed)";

                using (var addQueryCommand = new OleDbCommand(command, connection))
                {
                    addQueryCommand.Parameters.AddWithValue("@RequestDate", DateTime.Today.ToString("G"));
                    addQueryCommand.Parameters.AddWithValue("@Wrenches", toolsToRestock[0]);
                    addQueryCommand.Parameters.AddWithValue("@Ratchets", toolsToRestock[1]);
                    addQueryCommand.Parameters.AddWithValue("@Hammers", toolsToRestock[2]);
                    addQueryCommand.Parameters.AddWithValue("@Sockets", toolsToRestock[3]);
                    addQueryCommand.Parameters.AddWithValue("@Pliers", toolsToRestock[4]);
                    addQueryCommand.Parameters.AddWithValue("@Processed", false);

                    addQueryCommand.ExecuteNonQuery();
                }
            }

            Report.Writer = $"{DateTime.Now.ToShortTimeString()}: (Reorder Request Created) " +
                            $"{toolsToRestock[0]} Wrenches, {toolsToRestock[1]} Ratchets, " +
                            $"{toolsToRestock[2]} Hammers, {toolsToRestock[3]} Sockets, " +
                            $"{toolsToRestock[4]} Pliers";
        }

        public static void UpdateReorderLevel(int wrenches, int ratchets, int hammers, int sockets, int pliers)
        {
            Settings.Default.WrenchsReorderLevel = wrenches;
            Settings.Default.RatchetsReorderLevel = ratchets;
            Settings.Default.HammersReorderLevel = hammers;
            Settings.Default.SocketsReorderLevel = sockets;
            Settings.Default.PliersReorderLevel = pliers;
            Settings.Default.Save();
        }

        public static List<int> GetCurrentStock()
        {
            var stockQuantities = new List<int>();

            using (var connection = new OleDbConnection(Resources.ConnectionString))
            {
                connection.Open();
                using (var fetchData = new OleDbCommand("SELECT * FROM Stock", connection))
                using (var reader = fetchData.ExecuteReader())
                {
                    while (reader != null && reader.Read())
                    {
                        stockQuantities.Add(int.Parse(reader["Wrenches"].ToString()));
                        stockQuantities.Add(int.Parse(reader["Ratchets"].ToString()));
                        stockQuantities.Add(int.Parse(reader["Hammers"].ToString()));
                        stockQuantities.Add(int.Parse(reader["Sockets"].ToString()));
                        stockQuantities.Add(int.Parse(reader["Pliers"].ToString()));
                    }
                }
            }

            return stockQuantities;
        }

        private static void AddToStock(int wrenches = 0, int ratchets = 0, int hammers = 0, int sockets = 0,
            int pliers = 0)
        {
            var currentStock = GetCurrentStock();
            var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"Database.accdb\"";

            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                var command = "UPDATE Stock SET Wrenches=?, Ratchets=?, Hammers=?, Sockets=?, Pliers=?";
                using (var updateStock = new OleDbCommand(command, connection))
                {
                    updateStock.Parameters.Add("@wrenches", OleDbType.VarChar).Value = currentStock[0] + wrenches;
                    updateStock.Parameters.Add("@ratchets", OleDbType.VarChar).Value = currentStock[1] + ratchets;
                    updateStock.Parameters.Add("@hammers", OleDbType.VarChar).Value = currentStock[2] + hammers;
                    updateStock.Parameters.Add("@sockets", OleDbType.VarChar).Value = currentStock[3] + sockets;
                    updateStock.Parameters.Add("@pliers", OleDbType.VarChar).Value = currentStock[4] + pliers;

                    updateStock.ExecuteNonQuery();
                }
            }

            Report.Writer = $"{DateTime.Now.ToShortTimeString()}: (Restock) " +
                            $"{wrenches} Wrenches, {ratchets} Ratchets, {hammers} Hammers," +
                            $"{sockets} Sockets, {pliers} Pliers";
        }

        private static void UpdateStock(int wrenches, int ratchets, int hammers, int sockets, int pliers)
        {
            using (var connection = new OleDbConnection(Resources.ConnectionString))
            {
                connection.Open();

                var command = "UPDATE Stock SET Wrenches=?, Ratchets=?, Hammers=?, Sockets=?, Pliers=?";
                using (var updateStock = new OleDbCommand(command, connection))
                {
                    updateStock.Parameters.Add("@wrenches", OleDbType.VarChar).Value = wrenches;
                    updateStock.Parameters.Add("@ratchets", OleDbType.VarChar).Value = ratchets;
                    updateStock.Parameters.Add("@hammers", OleDbType.VarChar).Value = hammers;
                    updateStock.Parameters.Add("@sockets", OleDbType.VarChar).Value = sockets;
                    updateStock.Parameters.Add("@pliers", OleDbType.VarChar).Value = pliers;

                    updateStock.ExecuteNonQuery();
                }
            }

            Report.Writer = $"{DateTime.Now.ToShortTimeString()}: (Stock Updated) " +
                            $"{wrenches} Wrenches, {ratchets} Ratchets, {hammers} Hammers," +
                            $"{sockets} Sockets, {pliers} Pliers";
        }
    }
}
