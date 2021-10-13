using Explorer_X.Properties;
using Explorer_X.Source.Classes.Handlers.Directory_Handler;
using Explorer_X.Source.Classes.Handlers.Drive_Handler;
using Explorer_X.Source.Classes.Theme_Handler;
using Explorer_X.Source.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer_X
{
    public partial class UI : Form
    {
        public static bool hasClicked = false;
        public static bool isNordCurrDefTheme = false;
        public static bool isLightCurrDefTheme = false;

        /* 
                                       CREDITS
                                Icons - https://www.iconsdb.com
                                Customized Color Theme - https://www.nordtheme.com/
                                Inspired By - Microsoft Windows (https://microsoft.com)
                                
                                
         */
        public UI()
        {
            InitializeComponent();
            ThemeHandler theme = new ThemeHandler();
            theme.SetTheme("Nord", siticoneCustomGradientPanel1, siticoneRoundedTextBox1, treeView1, panel1, panel2, panel3, panel4, panel5, panel6);
            if (Settings.Default.customThemeName != "")
            {
                // Load our beautiful custom theme if it isn't NULL.
                theme.HandleCustomTheme(siticoneCustomGradientPanel1, siticoneRoundedTextBox1, treeView1, panel1, panel2, panel3, panel4, panel5, panel6);
            }
            DriveHandler handler = new DriveHandler();
            handler.Handle(siticoneComboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedTextBox1_TextChanged(object sender, EventArgs e)
        {
            DirectoryHandler handler = new DirectoryHandler();
            handler.Handle(siticoneRoundedTextBox1, treeView1);
        }

        private void siticoneCustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null)
            {
                // do nothing
            }
            else if (e.Node.Tag.GetType() == typeof(DirectoryInfo))
            {
                // Opens the folder
                e.Node.Nodes.Clear();
                foreach (var dirs in Directory.GetDirectories(((DirectoryInfo)e.Node.Tag).FullName))
                {
                    DirectoryInfo DirInfo = new DirectoryInfo(dirs);
                    var nodes = e.Node.Nodes.Add(DirInfo.Name);
                    nodes.Tag = DirInfo;
                }
                foreach (var dirs in Directory.GetFiles(((DirectoryInfo)e.Node.Tag).FullName))
                {
                    FileInfo DirInfo = new FileInfo(dirs);
                    var nodes = e.Node.Nodes.Add(DirInfo.Name);
                    nodes.Tag = DirInfo;
                }
            }
            else
            {
                Process.Start(((FileInfo)e.Node.Tag).FullName);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            siticoneRoundedTextBox1.Text = $"C:\\Users\\{Environment.UserName}\\Desktop";
            settingsControl1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            siticoneRoundedTextBox1.Text = $"C:\\Users\\{Environment.UserName}\\Desktop";
            settingsControl1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            siticoneRoundedTextBox1.Text = $"C:\\Users\\{Environment.UserName}\\Desktop";
            settingsControl1.Visible = false;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            siticoneRoundedTextBox1.Text = $"C:\\Users\\{Environment.UserName}\\Downloads";
            settingsControl1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            siticoneRoundedTextBox1.Text = $"C:\\Users\\{Environment.UserName}\\Downloads";
            settingsControl1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            siticoneRoundedTextBox1.Text = $"C:\\Users\\{Environment.UserName}\\Downloads";
            settingsControl1.Visible = false;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            siticoneRoundedTextBox1.Text = $"C:\\Users\\{Environment.UserName}\\Pictures";
            settingsControl1.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            siticoneRoundedTextBox1.Text = $"C:\\Users\\{Environment.UserName}\\Pictures";
            settingsControl1.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            siticoneRoundedTextBox1.Text = $"C:\\Users\\{Environment.UserName}\\Pictures";
            settingsControl1.Visible = false;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            siticoneRoundedTextBox1.Text = $"C:\\Users\\{Environment.UserName}\\Documents";
            settingsControl1.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            siticoneRoundedTextBox1.Text = $"C:\\Users\\{Environment.UserName}\\Documents";
            settingsControl1.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            siticoneRoundedTextBox1.Text = $"C:\\Users\\{Environment.UserName}\\Documents";
            settingsControl1.Visible = false;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            siticoneRoundedTextBox1.Text = $"C:\\Users\\{Environment.UserName}\\Music";
            settingsControl1.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            siticoneRoundedTextBox1.Text = $"C:\\Users\\{Environment.UserName}\\Music";
            settingsControl1.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            siticoneRoundedTextBox1.Text = $"C:\\Users\\{Environment.UserName}\\Music";
            settingsControl1.Visible = false;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            siticoneRoundedTextBox1.Text = $"C:\\Users\\{Environment.UserName}\\Videos";
            settingsControl1.Visible = false;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            siticoneRoundedTextBox1.Text = $"C:\\Users\\{Environment.UserName}\\Videos";
            settingsControl1.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            siticoneRoundedTextBox1.Text = $"C:\\Users\\{Environment.UserName}\\Videos";
            settingsControl1.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            settingsControl1.Visible = true;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            settingsControl1.Visible = true;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hasClicked == true)
            {
                timer1.Enabled = false;
                ThemeHandler handler = new ThemeHandler();
                handler.HandleCustomTheme(siticoneCustomGradientPanel1, siticoneRoundedTextBox1, treeView1, panel1, panel2, panel3, panel4, panel5, panel6);
                MessageBox.Show("Successfully Imported Custom Theme!", "Import sucedeed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (isNordCurrDefTheme == true)
            {
                ThemeHandler handler = new ThemeHandler();
                handler.SetTheme("Nord", siticoneCustomGradientPanel1, siticoneRoundedTextBox1, treeView1, panel1, panel2, panel3, panel4, panel5, panel6);
            }
            if (isLightCurrDefTheme == true)
            {
                ThemeHandler handler = new ThemeHandler();
                handler.SetTheme("Light", siticoneCustomGradientPanel1, siticoneRoundedTextBox1, treeView1, panel1, panel2, panel3, panel4, panel5, panel6);
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriveHandler handler = new DriveHandler();
            handler.Handle2(siticoneComboBox1, siticoneRoundedTextBox1, treeView1);
        }

        private void treeView1_KeyUp(object sender, KeyEventArgs e)
        {
            new NewFile().Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                                       Credits\n                                Icons - https://www.iconsdb.com\n                                Color Theme - https://nordtheme.com\n                                Inspired By - Microsoft Explorer (Windows)", "Project Explorer X", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start("https://github.com/Storm99999");
        }
    }
}
