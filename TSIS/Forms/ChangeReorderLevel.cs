using System.Windows.Forms;
using TSIS.Properties;

namespace TSIS
{
    public partial class ChangeReorderLevel : Form
    {
        public ChangeReorderLevel()
        {
            InitializeComponent();
        }

        private void ChangeReorderLevel_Load(object sender, System.EventArgs e)
        {
            WrenchesNumericBox.Value = Settings.Default.WrenchsReorderLevel;
            RatchetsNumericBox.Value = Settings.Default.RatchetsReorderLevel;
            HammersNumericBox.Value = Settings.Default.HammersReorderLevel;
            SocketsNumericBox.Value = Settings.Default.SocketsReorderLevel;
            PliersNumericBoxP.Value = Settings.Default.PliersReorderLevel;
        }

        private void UpdateButton_Click(object sender, System.EventArgs e)
        {
            Settings.Default.WrenchsReorderLevel = (int)WrenchesNumericBox.Value;
            Settings.Default.RatchetsReorderLevel = (int)RatchetsNumericBox.Value;
            Settings.Default.HammersReorderLevel = (int)HammersNumericBox.Value;
            Settings.Default.SocketsReorderLevel = (int)SocketsNumericBox.Value;
            Settings.Default.PliersReorderLevel = (int)PliersNumericBoxP.Value;

            Settings.Default.Save();
        }

        private void DefaultButton_Click(object sender, System.EventArgs e)
        {
            WrenchesNumericBox.Value = 5000;
            RatchetsNumericBox.Value = 5000;
            HammersNumericBox.Value = 5000;
            SocketsNumericBox.Value = 25000;
            PliersNumericBoxP.Value = 5000;

            UpdateButton_Click(sender, e);
        }
    }
}
