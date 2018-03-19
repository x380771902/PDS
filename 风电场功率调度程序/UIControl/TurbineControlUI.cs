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
        private int p1width=0;
        public TurbineControlUI(Turbine t)
        {
          
            InitializeComponent();
            Ts = t.RunState;
            this.label2.Text = t.TurbineID.ToString();
            this.WSpeedNac = t.WSpeedNac;
            this.ActivePower = t.ActivePower;
            p1width = this.p1.Width;
            this.p1.Width = (int)(ActivePower/2000*p1width);
            this.labLastStopDatatime.Text = t.LastDateTime.ToShortDateString() +" " + t.LastDateTime.ToShortTimeString() ;
        }

        public TurbineControlUI()
        {
            InitializeComponent();

        }


        private Turbine.turbineStatu ts;
        private float wSpeedNac;
        private float activePower;
        private int activePowerLimit;
        private DateTime lastStopDatetime ;

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
                        this.label1.Text = "为初始化";
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
            { this.activePower = value ;
             
                this.label8.Text = Math.Round(activePower,2).ToString()+ "kW";
                this.p1.Width = (int)(ActivePower / 2000 * this.panel1.Width);
            }
             

        }

        public int ActivePowerLimitValue
        {
            get
            {
               return  activePowerLimit;
            } 
            set
            {
                activePowerLimit = value; 
                this.labLimitActPower.Text = activePowerLimit.ToString() + " kW";
                 ;
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
    }
}