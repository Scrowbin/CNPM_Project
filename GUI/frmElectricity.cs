using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class frmElectricity : Form
    {
        private List<DienNuoc> Dien;
        public frmElectricity()
        {
            InitializeComponent();
        }
        public void FormLoad()
        {
            Dien = new List<DienNuoc>
            {
                new DienNuoc
                {
                    Range = 1,
                    Amount = 50,
                    AmountRange = "0-50",
                    Unit = "kWh",
                    Price = 1806
                },
                new DienNuoc
                {
                    Range = 2,
                    Amount = 50,
                    AmountRange = "51-100",
                    Unit = "kWh",
                    Price = 1866
                },
                new DienNuoc
                {
                    Range = 3,
                    Amount = 100,
                    AmountRange = "101-200",
                    Unit = "kWh",
                    Price = 2167
                },
                new DienNuoc
                {
                    Range = 4,
                    Amount = 100,
                    AmountRange = "201-300",
                    Unit = "kWh",
                    Price = 2729
                },
                new DienNuoc
                {
                    Range = 5,
                    Amount = 100,
                    AmountRange = "301-400",
                    Unit = "kWh",
                    Price = 3050
                },
                new DienNuoc
                {
                    Range = 6,
                    Amount = int.MaxValue, // or set to 0 if you handle this differently
                    AmountRange = "Trên 400",
                    Unit = "kWh",
                    Price = 3151
                }
            };



        }

        private void frmElectricity_Load(object sender, EventArgs e)
        {

        }
    }
}
