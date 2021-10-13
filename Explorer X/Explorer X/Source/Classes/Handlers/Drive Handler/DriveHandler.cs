using Siticone.UI.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer_X.Source.Classes.Handlers.Drive_Handler
{
    class DriveHandler
    {
        public void Handle(SiticoneComboBox box)
        {
            foreach (var drives in Directory.GetLogicalDrives())
            {
                box.Items.Add(drives);
            }
        }

        // Select Index Changed Event
        public void Handle2(SiticoneComboBox box, SiticoneRoundedTextBox text, TreeView view)
        {
            view.Nodes.Clear();
            text.Text = box.Text;
        }
    }
}
