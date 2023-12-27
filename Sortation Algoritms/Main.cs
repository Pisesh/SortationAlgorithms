using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortation_Algoritms
{
    class Main
    {
        private string sortBy;
        private long algorithmTime;
        private string algorithmType;

        RandomManager Mrm = new RandomManager();
        SortManager Msm = new SortManager();
        Spliter Msp = new Spliter();

        public string SetSortBy
        {
            set
            {
                sortBy = value;
            }
        }

        public long GetAlgorithmTime
        {
            get
            {
                return algorithmTime;
            }
        }

        public string SetAlgorithmType
        {
            set
            {
                algorithmType = value;
            }
        }


        // Sort
        public string Sort(string inputString)
        {
            Msm.SetSortBy = sortBy;
            Msm.SetAlgorithmType = algorithmType;

            string final = Msm.Sort(inputString);
            algorithmTime = Msm.GetAlgorithmTime;

            return final;
        }

        public string RandomNumber(int count, int first, int end, bool nonReapit)
        {
            return Mrm.RandomNumber(count, first, end, nonReapit);
        }



    }
}
