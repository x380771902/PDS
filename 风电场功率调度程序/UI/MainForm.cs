using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 风电场功率调度程序
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent(); 
            initData();
        }

        private Windfarm wf = null;
        private Random rd = new Random();
        private Config config = null;
        private User CurrendUser = new User();
        WindFarm_Manager WFM = null;
        BindingSource bs1 = null;
        BindingSource bs2 = null;
        System.Timers.Timer SetLimitActivePowerValueTime = new System.Timers.Timer();
        int LimitActivePower = 0;

        BackgroundWorker BWMain = new BackgroundWorker();

        void initData()
        {
            this.Icon = Properties.Resources.bitbug_favicon;
            config = new Config();
            WFM = new WindFarm_Manager();
            wf = WFM.ConfigWindfarm;
            //初始化风电场信息

            for (int i = 0; i < wf.ListTurbines.Count; i++)
            {
                TurbineControlUI turc = new TurbineControlUI(wf.ListTurbines[i]);
                FLP1.Controls.Add(turc);
            }
            SetLimitActivePowerValueTime.Interval = wf.SettingCycle;
            SetLimitActivePowerValueTime.Elapsed += SetLimitActivePowerValueTime_Elapsed;
            LimitActivePower = (int)this.nudLimit.Value;
            
            BWMain.DoWork += BWMain_DoWork;
            BWMain.ProgressChanged += BWMain_ProgressChanged;
            BWMain.WorkerReportsProgress = true;
            BWMain.RunWorkerAsync();
        }

        private void BWMain_ProgressChanged(object sender, ProgressChangedEventArgs e)
        { 
            for (int i = 0; i < wf.ListTurbines.Count; i++)
            {
                var a = FLP1.Controls[i] as TurbineControlUI;
                a.WSpeedNac = wf.ListTurbines[i].WSpeedNac;
                a.ActivePower = wf.ListTurbines[i].ActivePower;
                a.Ts = wf.ListTurbines[i].RunState;
                a.ActivePowerLimitValue = (int)wf.ListTurbines[i].LimitActivePower;
                a.LastDateTime = wf.ListTurbines[i].LastDateTime;
                a.LocalOrRemote = wf.ListTurbines[i].LocalOrRemote;
            }
            this.labTotalActivePower.Text = wf.TatolActivePower.ToString() + " kW";
            this.labAws.Text = Math.Round(wf.AvgWindSpeed, 1).ToString() + " m/s ";
            this.labTheoreticalPower.Text = wf.TheoreticalPower.ToString() + " kW";
        }

        private void BWMain_DoWork(object sender, DoWorkEventArgs e)
        { 
            try
            {
                int i = 0;
                BackgroundWorker bw = sender as BackgroundWorker;
                while (true)
                {
                    if (i == 10)
                        i = 0;
                    bw.ReportProgress(++i);
                    Thread.Sleep(4000);
                }
            }
            catch (Exception ex )
            {

                throw ex;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             
            
        }


        private void setMessage(string MessageText, RichTextBox mb ,User user )
        { 

            
           mb.Text =   mb.Text.Insert(0, "用户：" + user.UserName + " 时间： " + DateTime.Now + "  " + MessageText + Environment.NewLine);
            mb.Update();
        }

        /// <summary>
        /// 生成设置范围内的Double的随机数
        /// eg:_random.NextDouble(1.5, 2.5)
        /// </summary>
        /// <param name="random">Random</param>
        /// <param name="miniDouble">生成随机数的最大值</param>
        /// <param name="maxiDouble">生成随机数的最小值</param>
        /// <returns>当Random等于NULL的时候返回0;</returns>
        private double NextDouble(Random random, double miniDouble, double maxiDouble)
        {
            if (random != null)
            {
                return random.NextDouble() * (maxiDouble - miniDouble) + miniDouble;
            }
            else
            {
                return 0.0d;
            }
        }

        private void btnEnableLimitActivePower_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("启用功率系统有功控制?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.SetLimitActivePowerValueTime.Elapsed += SetLimitActivePowerValueTime_Elapsed;
                this.SetLimitActivePowerValueTime.Start();
                this.btnEnableLimitActivePower.Enabled = false;
                this.btnDisableLimitActivePower.Enabled = true;
                btnSetActivePowerLimitValue.Enabled = true;
                setMessage("启用功率系统有功控制", this.richTextBox1, CurrendUser);
            }
             
        }
        
        private void btnDisableLimitActivePower_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("解除功率系统有功控制?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                wf.LimitActivePower = wf.GridCapacity;
                this.SetLimitActivePowerValueTime.Stop();
                this.SetLimitActivePowerValueTime.Elapsed -= SetLimitActivePowerValueTime_Elapsed;
                this.btnEnableLimitActivePower.Enabled = true;
                this.btnDisableLimitActivePower.Enabled = false;
                btnSetActivePowerLimitValue.Enabled = false;
                setMessage("解除功率系统有功控制", this.richTextBox1, CurrendUser);　
            }
            　　
        }

        List<MessageBullet> listmb = new List<MessageBullet>();
        private void btnSetActivePowerLimitValue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否修改限定值为:"+ this.nudLimit.Value.ToString() + "?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {　
                setMessage("限定值已被修改为：" + this.nudLimit.Value.ToString() + "kW", this.richTextBox1, CurrendUser);
                this.LimitActivePower = (int)this.nudLimit.Value;　
            } 
        }
        private void SetLimitActivePowerValueTime_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            wf.LimitActivePower = LimitActivePower;
        } 

        private  void startOrStopturbine()
        { 
            if (wf.LimitActivePower > wf.TatolActivePower && Math.Abs((wf.LimitActivePower - wf.TatolActivePower)) >= 200)
            {
              //  wf.StartLimitTurbine(); 
              
            }
            if (wf.LimitActivePower < wf.TatolActivePower && Math.Abs((wf.LimitActivePower - wf.TatolActivePower))>= 200)
            {
              //  wf.StopLimitTurbine();  
            }

            bs1 = new BindingSource();
            bs1.DataSource = wf.startQueue;
            this.lbxStartList.DataSource = bs1;
            this.lbxStartList.DisplayMember = "TutbineID";
            this.lbxStartList.ValueMember = "TutbineID";

            bs2 = new BindingSource();
            bs2.DataSource = wf.stopQueue;
            this.lbxStopList.DataSource = bs2;
            this.lbxStopList.DisplayMember = "TutbineID";
            this.lbxStopList.ValueMember = "TutbineID";
            
        }


        #region 菜单栏事件
        private void 实时图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chart c = new Chart(wf);
            c.Show();
        }

        private void oPC通讯测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientTest ct = new ClientTest(config);
            ct.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否继续关闭系统?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Thread.Sleep(500);
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            } 
        }


        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void 编辑控制策略ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            WindFarmMessage.AddOperateMessage("打开控制策略管理面板", CurrendUser.UserName);
            setMessage("打开控制策略管理面板", this.richTextBox1, CurrendUser);
            ControlStrategyManageForm csmf = new ControlStrategyManageForm(wf);
            csmf.ShowDialog();
           
        }

        private void 指令记录报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommandListForm clfp = new CommandListForm(); 
            clfp.Show();

                }
    }
    #endregion


}
