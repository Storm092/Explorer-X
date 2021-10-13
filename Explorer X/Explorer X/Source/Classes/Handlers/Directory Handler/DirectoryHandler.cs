using Siticone.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer_X.Source.Classes.Handlers.Directory_Handler
{
    class DirectoryHandler
    {
        // That'll handle the most stuff. One thing that we could handle here but I didnt want to is the event.
        // Even though it could've worked, I would do it the more chill way.
        // You can put it in here if you want to.
        string NULL = "";
        public void Handle(SiticoneRoundedTextBox box, TreeView treeView1)
        {
            treeView1.ForeColor = Color.White;
            if (Directory.Exists(box.Text.ToString()))
            {
                foreach (var dirs in Directory.GetDirectories(box.Text))
                {
                    DirectoryInfo DirInfo = new DirectoryInfo(dirs);
                    var nodes = treeView1.Nodes.Add(DirInfo.Name, DirInfo.Name, 0);
                    nodes.Tag = DirInfo;
                }
                foreach (var Files in Directory.GetFiles(box.Text))
                {
                    FileInfo fileInfo = new FileInfo(Files);
                    var nodes = treeView1.Nodes.Add(fileInfo.Name, fileInfo.Name, 1);
                    nodes.Tag = fileInfo;
                }
            }

            // If the path is NULL we'll remove all files / directories from the list since the user cleared them.
            if (box.Text == NULL)
            {
                treeView1.Nodes.Clear();
            }
        }
    }
}
