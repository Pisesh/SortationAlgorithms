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
        Main main = new Main();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rdb_Ascending.Select();
            Cmb_Algorithm.Text = "Bubble Sort";

        }

        private void Btn_Sort_Click(object sender, EventArgs e)
        {
            main.SetAlgorithmType = Cmb_Algorithm.Text;
            if (Rdb_Ascending.Checked)
            {
                main.SetSortBy = "Asc";
            }
            else
            {
                main.SetSortBy = "Dec";
            }

            Tbx_Output.Text = main.Sort(Tbx_Input.Text);
            Lbl_SortTime.Text = (Convert.ToString(main.GetAlgorithmTime));
            Lbl_SortTime.Text = Lbl_SortTime.Text + " MS";
            
        }
    }
}
