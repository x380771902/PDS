using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 风电场功率调度程序
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent(); 
        }

        private Windfarm wf = null;

        public Chart(Windfarm wf)
        {
            InitializeComponent();
            this.Icon = Properties.Resources.bitbug_favicon;
            this.wf = wf;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.AddXY(DateTime.Now.ToLongTimeString(), wf.TatolActivePower);
            this.chart1.Series[1].Points.AddXY(DateTime.Now.ToLongTimeString(), wf.LimitActivePower);
            this.chart1.Series[2].Points.AddXY(DateTime.Now.ToLongTimeString(), wf.TheoreticalPower);


            if (this.chart1.Series[0].Points.Count >30)
            {
                this.chart1.Series[0].Points.RemoveAt(0);
                this.chart1.Series[1].Points.RemoveAt(0);
                this.chart1.Series[2].Points.RemoveAt(0);

            }
        }

    }
}
