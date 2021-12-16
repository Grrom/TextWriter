using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextWriter
{

    public partial class FrmFileName : Form
    {
        public string content;
        public FrmFileName(string content)
        {
            this.content = content;
            InitializeComponent();
        }

        private async void okay_Click(object sender, EventArgs e)
        {
            await File.WriteAllTextAsync(fileName.Text + ".txt", content);
            Close();
        }
    }
}
