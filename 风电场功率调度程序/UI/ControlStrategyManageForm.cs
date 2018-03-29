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
    public partial class ControlStrategyManageForm : Form
    {
        public ControlStrategyManageForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.bitbug_favicon;
        }
         
        public ControlStrategyManageForm(Windfarm wf)
        { 
            InitializeComponent(); 
            this.numericUpDown1.Value  = Convert.ToDecimal( wf.ActivePower10MinitueMaxRate ); 
            this.numericUpDown2.Value = Convert.ToDecimal(wf.ActivePower1MinitueMaxRate);
            
            
            this.cboxIgnoreSample.Checked = wf.IsIgnoreSample;
            this.cboxLimitActivePowerSpeed.Checked = wf.EnableLimitActivePowerSpeed;
            this.cboxstartturbine.Checked = wf.EnableAutoStartTurbine;
            this.cboxstopturbine.Checked = wf.EnableAutoStopTurbine;
            switch (wf.ControlStrategy)
            {
                case 1: this.rbtnControlStrategy1.Checked = true;break;
                case 2: this.rbtnControlStrategy2.Checked = true; break; 
                case 3: this.rbtnControlStrategy3.Checked = true; break; 
                default:
                    break;
            }
            switch (wf.ReactiveControlStrategy)
            {
                case 1: this.rbtnReactiveControlStrategy1.Checked = true; break;
                case 2: this.rbtnReactiveControlStrategy2.Checked = true; break; 
                default:
                    break;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
