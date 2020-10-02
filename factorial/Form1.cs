using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            UInt64 num = Convert.ToUInt64(tbInNum.Text);
            UInt64 outfac = 1;
            for (int x = 1; x <= (int)num; x++)
            {
                outfac *= (UInt64)x;
            }
            tbOutFac.Text = Convert.ToString(outfac);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
