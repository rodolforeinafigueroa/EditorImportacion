using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorImportacion
{
    public partial class frmScript : Form
    {
        public frmScript(string pvStrScript)
        {
            InitializeComponent();
            richTextBox1.Text = pvStrScript;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
