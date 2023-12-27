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
        public event EventHandler CalculationCompleted;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rdb_Ascending.Select();
            Cmb_Algorithm.SelectedIndex = 0;
            Cmb_Algorithm_Type_Find.SelectedIndex = 0;
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

        protected virtual void OnCalculationCompleted()
        {
            CalculationCompleted?.Invoke(this, EventArgs.Empty);
        }

        private void Btn_Genrate_Click(object sender, EventArgs e)
        {
            Tbx_Input.Text = main.RandomNumber(int.Parse(Tbx_Count.Text), int.Parse(Tbx_Distance_First.Text), int.Parse(Tbx_Distance_End.Text), Chb_NR.Checked);
        }

        private void Btn_Sort_Find_Click(object sender, EventArgs e)
        {
            Tbx_Input.Text = Tbx_Input_find.Text;
            tabControl.SelectedTab = Tbp_Sort;
        }

        private void Btn_Find_Sort_Click(object sender, EventArgs e)
        {
            Tbx_Input_find.Text = Tbx_Output.Text;
            tabControl.SelectedTab = Tbp_Find;
        }

        private void Cmb_Algorithm_Type_Find_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Algorithm_Type_Find.SelectedIndex == 1)
            {
                Panel_Sort.Visible = true;
            }
            else
            {
                Panel_Sort.Visible = false;
            }
        }
    }
}
