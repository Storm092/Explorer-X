using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer_X.Source.Forms
{
    public partial class NewDirectory : Form
    {
        public NewDirectory()
        {
            InitializeComponent();
            path.Text = $"C:\\Users\\{Environment.UserName}\\Desktop\\";
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(path.Text+siticoneRoundedTextBox1.Text);
            Hide();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
