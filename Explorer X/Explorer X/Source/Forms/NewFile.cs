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
    public partial class NewFile : Form
    {
        public NewFile()
        {
            InitializeComponent();
            path.Text = "C:\\Users\\" + Environment.UserName + "\\Desktop\\";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneRoundedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            File.WriteAllText($"{path.Text}{siticoneRoundedTextBox1.Text}{siticoneRoundedTextBox3.Text}", "");
            Hide();
        }
    }
}
