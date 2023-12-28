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
            Tbx_Input.Text = main.RandomNumber(
                int.Parse(Tbx_Count.Text),
                int.Parse(Tbx_Distance_First.Text),
                int.Parse(Tbx_Distance_End.Text),
                Chb_NR.Checked
                );
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

        private void Btn_Find_Click(object sender, EventArgs e)
        {
            main.SetAlgorithmType = Cmb_Algorithm_Type_Find.Text;
            Tbx_Output_Find.Text = main.Search(Tbx_Input_find.Text, int.Parse(Tbx_Input_Search.Text));
            Lbl_Time_Find.Text = Convert.ToString(main.GetAlgorithmTime);
        }

        private void Chb_Fill_Random_CheckedChanged(object sender, EventArgs e)
        {
            if (Chb_Fill_Random.Checked == true)
            {
                Chb_Out_Range.Enabled = true;
            }
            else
            {
                Chb_Out_Range.Enabled = false;
            }
        }

        private void Btn_Generate_Find_Click(object sender, EventArgs e)
        {
            int counter = 1;

            if (Chb_Fill_Random.Checked == true)
            {
                counter = 2;
            }

            string[] str = new string[counter];

            str = main.RandomSearch(
                int.Parse(Tbx_Count_Find.Text),
                int.Parse(Tbx_From_Find.Text),
                int.Parse(Tbx_To_Find.Text),
                Chb_Reapet.Checked,
                Chb_Fill_Random.Checked,
                Chb_Out_Range.Checked
                );

            if (Chb_Fill_Random.Checked == true)
            {
                Tbx_Input_find.Text = str[0];
                Tbx_Input_Search.Text = str[1];
            }
            else
            {
                Tbx_Input_find.Text = str[0];
            }


        }
    }
}
