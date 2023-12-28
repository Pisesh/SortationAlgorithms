using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortation_Algoritms
{
    public partial class LoadForm : Form
    {
        string OP;

        public LoadForm(string opForm1)
        {
            InitializeComponent();
            OP = opForm1;
        }

        private void LoadForm_Load(object sender, EventArgs e)
        { 
            Lbl_Show.Text = OP + " please wait ...";
        }
    }
}
