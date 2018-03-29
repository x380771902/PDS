using System; 
using System.Drawing; 
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
        private ImageAnimator imaa;

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
                        this.BackColor = Color.GreenYellow;
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

                toolTip1.SetToolTip(this.p1, "当前有功功率：" + this.label8.Text);

                this.p1.Height = (int)(ActivePower / 2000 * this.Height);
                this.p1.Location = new Point(159, (int)((1.0d - ActivePower / 2000)  * this.Height)-2);
                 
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
                   this.panel1.BackColor = Color.WhiteSmoke;
                  toolTip1.SetToolTip(this.panel1, "当前控制状态：本地");
                }
                else
                { 
                   this.panel1.BackColor = Color.Green;
                  toolTip1.SetToolTip(this.panel1, "当前控制状态：远程");
                }
                localOrRemote = value;
            }
        }


        /// <summary>
        /// 有功使能
        /// </summary>
        public bool PwrAtEnable
        {
            set
            {
                if (value)
                {
                    this.panel2.BackColor = Color.Green;
                    toolTip1.SetToolTip(this.panel2, "有功使能信号：开启");
                }
                else
                {
                    this.panel2.BackColor = Color.WhiteSmoke;
                    toolTip1.SetToolTip(this.panel2, "有功使能信号：关闭");
                } 
            }
        }

        /// <summary>
        /// 无功功使能
        /// </summary>
        public bool PwrRtEnable
        {
            set
            {
                if (value)
                {
                    this.panel3.BackColor = Color.Green;
                    toolTip1.SetToolTip(this.panel3, "无功使能信号：开启");
                }
                else
                {
                    this.panel3.BackColor = Color.WhiteSmoke;
                    toolTip1.SetToolTip(this.panel3, "无功使能信号：关闭");
                } 
            }
        }

        /// <summary>
        /// 通讯状态
        /// </summary>
        public string ConnectState
        {
            set
            {
                if (value=="192")
                {
                    this.panel5.BackColor = Color.Green;
                    toolTip1.SetToolTip(this.panel5, "通讯状态：正常");
                }
                else
                {
                    this.panel5.BackColor = Color.WhiteSmoke;
                    toolTip1.SetToolTip(this.panel5, "通讯状态：异常");
                }
            }
        }


        /// <summary>
        /// 非样板机
        /// </summary>
        public bool IsSample
        {
            set
            {
                if (value)
                {
                    this.panel4.BackColor = Color.WhiteSmoke;
                    toolTip1.SetToolTip(this.panel4, "样板机：是");
                }
                else
                {
                    this.panel4.BackColor = Color.Green;
                    toolTip1.SetToolTip(this.panel4, "样板机：否");
                }
            }
        }

    }
}