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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rdb_Assending.Select();
            Cmb_Algorithm.Text = "Bubble Sort";

        }

        private void Btn_Sort_Click(object sender, EventArgs e)
        {
            
        }
    }
}
