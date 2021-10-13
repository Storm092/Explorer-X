using Explorer_X.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer_X.Source.Forms
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
        }

        private void SettingsControl_Load(object sender, EventArgs e)
        {
            label3.Text = Settings.Default.customThemeName;

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            UI.isLightCurrDefTheme = false;
            UI.isNordCurrDefTheme = false;
            UI.hasClicked = true;
        }

        private void siticoneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (siticoneComboBox1.Text == "Nord")
            {
                UI.isNordCurrDefTheme = true;
                UI.isLightCurrDefTheme = false;
            }
            if (siticoneComboBox1.Text == "Light")
            {
                UI.isNordCurrDefTheme = false;
                UI.isLightCurrDefTheme = true;
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Settings.Default.customThemeName = "";
            Settings.Default.Save();
            Application.Restart();
        }
    }
}
