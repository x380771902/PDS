using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 风电场功率调度程序
{
    public partial class TurbineControlUI : UserControl
    {

        public TurbineControlUI(Turbine t)
        {

            InitializeComponent();
            Ts = t.RunState;
            this.label2.Text = t.TurbineName.ToString();
            this.WSpeedNac = t.WSpeedNac;
            this.activePower = t.ActivePower;
            this.activePowerLimit = (int)t.LimitActivePower;
            this.p1.Height = (int)(ActivePower / 2000 * this.Height);

        }

        public TurbineControlUI()
        {
            InitializeComponent();

        }


        private Turbine.turbineStatu ts;
        private float wSpeedNac;
        private float activePower;
        private int activePowerLimit;
        private DateTime lastStopDatetime;

        public Turbine.turbineStatu Ts
        {
            get { return this.ts; }

            set
            {
                ts = value;
                switch (ts)
                {
                    case Turbine.turbineStatu.standby:
                        this.BackColor = Color.BlueViolet;
                        this.label1.Text = "待风";
                        break;
                    case Turbine.turbineStatu.stop:
                        this.BackColor = Color.Gray;
                        this.label1.Text = "正常停机";
                        break;
                    case Turbine.turbineStatu.running:
                        this.BackColor = Color.ForestGreen;
                        this.label1.Text = "正常运行";
                        break;
                    case Turbine.turbineStatu.error:
                        this.BackColor = Color.Red;
                        this.label1.Text = "故障停机";
                        break;
                    case Turbine.turbineStatu.limitedPowerRunning:
                        this.BackColor = Color.Tomato;
                        this.label1.Text = "限定运行";
                        break;
                    case Turbine.turbineStatu.limitedPowerStop:
                        this.BackColor = Color.SlateGray;
                        this.label1.Text = "限定停机";
                        break;
                    default:
                        this.BackColor = Color.Gray;
                        this.label1.Text = "未知";
                        break;
                }
            }
        }

        public float WSpeedNac
        {
            get { return this.wSpeedNac; }
            set
            {
                this.wSpeedNac = value;
                this.label6.Text = Math.Round(wSpeedNac, 1).ToString() + "m/s";
            }
        }

        public float ActivePower
        {
            get
            {
                return activePower;
            }
            set
            {
                this.activePower = value;
                this.label8.Text = Math.Round(activePower, 2).ToString() + "kW";
                this.p1.Height = (int)(ActivePower / 2000 * this.Height);
            }
        }

        public int ActivePowerLimitValue
        {
            get
            {
                return activePowerLimit;
            }
            set
            {
                activePowerLimit = value;
                this.labLimitActPower.Text = activePowerLimit.ToString() + " kW";
            }
        }

        public DateTime LastDateTime
        {
            get { return lastStopDatetime; }
            set
            {
                lastStopDatetime = value;
            }
        }

        private void TurbineControlUI_MouseHover(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void TurbineControlUI_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        private bool localOrRemote;
        public bool LocalOrRemote
        { 
            set
            { 
                if (value)
                {
                   this.panel3.BackColor = Color.YellowGreen;
                   
                }
                else
                { 
                   this.panel3.BackColor = Color.Green;
                }
                localOrRemote = value;
            }
        }
    }
}