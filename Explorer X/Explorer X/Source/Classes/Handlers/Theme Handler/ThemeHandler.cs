using Explorer_X.Properties;
using Siticone.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer_X.Source.Classes.Theme_Handler
{
    class ThemeHandler
    {
        public void SetTheme(string theme, SiticoneCustomGradientPanel panel, SiticoneRoundedTextBox box, TreeView view, Panel panel1, Panel panel2, Panel panel3, Panel panel4, Panel panel5, Panel panel6)
        {
            // I won't be adding much themes since you can make them on your own.
            // You may noticed you only can do 1 color in a theme, that's because i was too lazy to make 12 red, green, blue files.
            if (theme == "Nord")
            {
                panel.FillColor = Color.FromArgb(46, 52, 64);
                panel.FillColor2 = Color.FromArgb(59, 66, 82);
                panel.FillColor3 = Color.FromArgb(67, 76, 94);
                panel.FillColor4 = Color.FromArgb(76, 86, 106);
                box.FillColor = Color.FromArgb(46, 52, 64);
                view.BackColor = Color.FromArgb(46, 52, 64);
                panel1.BackColor = Color.FromArgb(46, 52, 64);
                panel2.BackColor = Color.FromArgb(46, 52, 64);
                panel3.BackColor = Color.FromArgb(46, 52, 64);
                panel4.BackColor = Color.FromArgb(46, 52, 64);
                panel5.BackColor = Color.FromArgb(46, 52, 64);
                panel6.BackColor = Color.FromArgb(46, 52, 64);
            }
            if (theme == "Light")
            {
                panel.FillColor = Color.White;
                panel.FillColor2 = Color.White;
                panel.FillColor3 = Color.White;
                panel.FillColor4 = Color.White;
                box.FillColor = Color.White;
                view.BackColor = Color.White;
                panel1.BackColor = Color.White;
                panel2.BackColor = Color.White;
                panel3.BackColor = Color.White;
                panel4.BackColor = Color.White;
                panel5.BackColor = Color.White;
                panel6.BackColor = Color.White;
            }
        }
        // Worst Idea, but works and that is what really matters.
        public void HandleCustomTheme(SiticoneCustomGradientPanel panel, SiticoneRoundedTextBox box, TreeView view, Panel panel1, Panel panel2, Panel panel3, Panel panel4, Panel panel5, Panel panel6)
        {
            // Read the name of the theme.
            if (File.ReadAllText(Environment.CurrentDirectory + "\\Extensions\\Themes\\theme.ex") == "")
            {
                // C# NullpointerException: Brain not defined
                MessageBox.Show("Could not find any theme in the theme extension file. \n\n Error: ExtensionContextNotFoundException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Settings.Default.customThemeName = File.ReadAllText(Environment.CurrentDirectory + "\\Extensions\\Themes\\theme.ex");
                Settings.Default.Save();


                if (File.Exists(Environment.CurrentDirectory + "\\Extensions\\Themes\\Data\\red.themedata"))
                {
                    Settings.Default.red = File.ReadAllText(Environment.CurrentDirectory + "\\Extensions\\Themes\\Data\\red.themedata");
                    Settings.Default.Save();
                    if (File.Exists(Environment.CurrentDirectory + "\\Extensions\\Themes\\Data\\green.themedata"))
                    {
                        Settings.Default.green = File.ReadAllText(Environment.CurrentDirectory + "\\Extensions\\Themes\\Data\\green.themedata");
                        if (File.Exists(Environment.CurrentDirectory + "\\Extensions\\Themes\\Data\\blue.themedata"))
                        {
                            Settings.Default.blue = File.ReadAllText(Environment.CurrentDirectory + "\\Extensions\\Themes\\Data\\blue.themedata");
                            Settings.Default.Save();
                            // Convert To Int
                            int red = Convert.ToInt32(Settings.Default.red);
                            int green = Convert.ToInt32(Settings.Default.green);
                            int blue = Convert.ToInt32(Settings.Default.blue);
                            panel.FillColor = Color.FromArgb(red, green, blue);
                            panel.FillColor2 = Color.FromArgb(red, green, blue);
                            panel.FillColor3 = Color.FromArgb(red, green, blue);
                            panel.FillColor4 = Color.FromArgb(red, green, blue);
                            box.FillColor = Color.FromArgb(red, green, blue);
                            view.BackColor = Color.FromArgb(red, green, blue);
                            panel1.BackColor = Color.FromArgb(red, green, blue);
                            panel2.BackColor = Color.FromArgb(red, green, blue);
                            panel3.BackColor = Color.FromArgb(red, green, blue);
                            panel4.BackColor = Color.FromArgb(red, green, blue);
                            panel5.BackColor = Color.FromArgb(red, green, blue);
                            panel6.BackColor = Color.FromArgb(red, green, blue);
                        }
                        else
                        {
                            MessageBox.Show("Could not find any blue in the theme data file. \n\n Error: NullPointerException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Could not find any green in the theme data file. \n\n Error: NullPointerException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Could not find any red in the theme data file. \n\n Error: NullPointerException", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
