namespace 风电场功率调度程序
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FLP1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.实时图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPC通讯测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.控制测率ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑控制策略ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.指令记录报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.风场功率调度报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.产品注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labTotalActivePower = new System.Windows.Forms.Label();
            this.labAws = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnableLimitActivePower = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nudLimit = new System.Windows.Forms.NumericUpDown();
            this.btnDisableLimitActivePower = new System.Windows.Forms.Button();
            this.lbxStopList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labTheoreticalPower = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbxStartList = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSetActivePowerLimitValue = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FLP1
            // 
            this.FLP1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLP1.AutoScroll = true;
            this.FLP1.Location = new System.Drawing.Point(128, 30);
            this.FLP1.Name = "FLP1";
            this.FLP1.Size = new System.Drawing.Size(966, 483);
            this.FLP1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.控制测率ToolStripMenuItem,
            this.系统报表ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.实时图ToolStripMenuItem,
            this.oPC通讯测试ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // 实时图ToolStripMenuItem
            // 
            this.实时图ToolStripMenuItem.Name = "实时图ToolStripMenuItem";
            this.实时图ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.实时图ToolStripMenuItem.Text = "实时图(&R)";
            this.实时图ToolStripMenuItem.Click += new System.EventHandler(this.实时图ToolStripMenuItem_Click);
            // 
            // oPC通讯测试ToolStripMenuItem
            // 
            this.oPC通讯测试ToolStripMenuItem.Name = "oPC通讯测试ToolStripMenuItem";
            this.oPC通讯测试ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.oPC通讯测试ToolStripMenuItem.Text = "通讯测试(&C)";
            this.oPC通讯测试ToolStripMenuItem.Click += new System.EventHandler(this.oPC通讯测试ToolStripMenuItem_Click);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.关闭ToolStripMenuItem.Text = "关闭(&X)";
            // 
            // 控制测率ToolStripMenuItem
            // 
            this.控制测率ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑控制策略ToolStripMenuItem});
            this.控制测率ToolStripMenuItem.Name = "控制测率ToolStripMenuItem";
            this.控制测率ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.控制测率ToolStripMenuItem.Text = "控制策略(&D)";
            // 
            // 编辑控制策略ToolStripMenuItem
            // 
            this.编辑控制策略ToolStripMenuItem.Name = "编辑控制策略ToolStripMenuItem";
            this.编辑控制策略ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.编辑控制策略ToolStripMenuItem.Text = "编辑控制策略(&P)";
            // 
            // 系统报表ToolStripMenuItem
            // 
            this.系统报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.指令记录报表ToolStripMenuItem,
            this.风场功率调度报表ToolStripMenuItem});
            this.系统报表ToolStripMenuItem.Name = "系统报表ToolStripMenuItem";
            this.系统报表ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.系统报表ToolStripMenuItem.Text = "系统报表(&S)";
            // 
            // 指令记录报表ToolStripMenuItem
            // 
            this.指令记录报表ToolStripMenuItem.Name = "指令记录报表ToolStripMenuItem";
            this.指令记录报表ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.指令记录报表ToolStripMenuItem.Text = "指令记录报表";
            // 
            // 风场功率调度报表ToolStripMenuItem
            // 
            this.风场功率调度报表ToolStripMenuItem.Name = "风场功率调度报表ToolStripMenuItem";
            this.风场功率调度报表ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.风场功率调度报表ToolStripMenuItem.Text = "风场功率调度报表";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助文档ToolStripMenuItem,
            this.产品注册ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 帮助文档ToolStripMenuItem
            // 
            this.帮助文档ToolStripMenuItem.Name = "帮助文档ToolStripMenuItem";
            this.帮助文档ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.帮助文档ToolStripMenuItem.Text = "帮助文档(&V)";
            // 
            // 产品注册ToolStripMenuItem
            // 
            this.产品注册ToolStripMenuItem.Name = "产品注册ToolStripMenuItem";
            this.产品注册ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.产品注册ToolStripMenuItem.Text = "产品注册(&T)";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于ToolStripMenuItem.Text = "关于(&A)";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "总功率：";
            // 
            // labTotalActivePower
            // 
            this.labTotalActivePower.AutoSize = true;
            this.labTotalActivePower.Location = new System.Drawing.Point(66, 80);
            this.labTotalActivePower.Name = "labTotalActivePower";
            this.labTotalActivePower.Size = new System.Drawing.Size(53, 12);
            this.labTotalActivePower.TabIndex = 3;
            this.labTotalActivePower.Text = "未初始化";
            // 
            // labAws
            // 
            this.labAws.AutoSize = true;
            this.labAws.Location = new System.Drawing.Point(66, 33);
            this.labAws.Name = "labAws";
            this.labAws.Size = new System.Drawing.Size(53, 12);
            this.labAws.TabIndex = 9;
            this.labAws.Text = "未初始化";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "平均风速：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "功率限定值：";
            // 
            // btnEnableLimitActivePower
            // 
            this.btnEnableLimitActivePower.Location = new System.Drawing.Point(7, 205);
            this.btnEnableLimitActivePower.Name = "btnEnableLimitActivePower";
            this.btnEnableLimitActivePower.Size = new System.Drawing.Size(75, 23);
            this.btnEnableLimitActivePower.TabIndex = 12;
            this.btnEnableLimitActivePower.Text = "设置限定值";
            this.btnEnableLimitActivePower.UseVisualStyleBackColor = true;
            this.btnEnableLimitActivePower.Click += new System.EventHandler(this.btnEnableLimitActivePower_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "kW";
            // 
            // nudLimit
            // 
            this.nudLimit.Location = new System.Drawing.Point(8, 134);
            this.nudLimit.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudLimit.Name = "nudLimit";
            this.nudLimit.Size = new System.Drawing.Size(87, 21);
            this.nudLimit.TabIndex = 14;
            this.nudLimit.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // btnDisableLimitActivePower
            // 
            this.btnDisableLimitActivePower.Location = new System.Drawing.Point(7, 234);
            this.btnDisableLimitActivePower.Name = "btnDisableLimitActivePower";
            this.btnDisableLimitActivePower.Size = new System.Drawing.Size(75, 23);
            this.btnDisableLimitActivePower.TabIndex = 15;
            this.btnDisableLimitActivePower.Text = "解除限定值";
            this.btnDisableLimitActivePower.UseVisualStyleBackColor = true;
            this.btnDisableLimitActivePower.Click += new System.EventHandler(this.btnDisableLimitActivePower_Click);
            // 
            // lbxStopList
            // 
            this.lbxStopList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxStopList.FormattingEnabled = true;
            this.lbxStopList.ItemHeight = 12;
            this.lbxStopList.Location = new System.Drawing.Point(8, 544);
            this.lbxStopList.Name = "lbxStopList";
            this.lbxStopList.Size = new System.Drawing.Size(87, 184);
            this.lbxStopList.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "启机队列：";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "停机队列：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 731);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1106, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "系统时间：";
            // 
            // labTheoreticalPower
            // 
            this.labTheoreticalPower.AutoSize = true;
            this.labTheoreticalPower.Location = new System.Drawing.Point(66, 56);
            this.labTheoreticalPower.Name = "labTheoreticalPower";
            this.labTheoreticalPower.Size = new System.Drawing.Size(53, 12);
            this.labTheoreticalPower.TabIndex = 22;
            this.labTheoreticalPower.Text = "未初始化";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "理论功率：";
            // 
            // lbxStartList
            // 
            this.lbxStartList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxStartList.FormattingEnabled = true;
            this.lbxStartList.ItemHeight = 12;
            this.lbxStartList.Location = new System.Drawing.Point(8, 341);
            this.lbxStartList.Name = "lbxStartList";
            this.lbxStartList.Size = new System.Drawing.Size(87, 172);
            this.lbxStartList.TabIndex = 23;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(128, 544);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(966, 181);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "日志消息：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabel2.Text = "时间";
            // 
            // btnSetActivePowerLimitValue
            // 
            this.btnSetActivePowerLimitValue.Location = new System.Drawing.Point(8, 164);
            this.btnSetActivePowerLimitValue.Name = "btnSetActivePowerLimitValue";
            this.btnSetActivePowerLimitValue.Size = new System.Drawing.Size(75, 23);
            this.btnSetActivePowerLimitValue.TabIndex = 26;
            this.btnSetActivePowerLimitValue.Text = "修改限定值";
            this.btnSetActivePowerLimitValue.UseVisualStyleBackColor = true;
            this.btnSetActivePowerLimitValue.Click += new System.EventHandler(this.btnSetActivePowerLimitValue_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 753);
            this.Controls.Add(this.btnSetActivePowerLimitValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbxStartList);
            this.Controls.Add(this.labTheoreticalPower);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbxStopList);
            this.Controls.Add(this.btnDisableLimitActivePower);
            this.Controls.Add(this.nudLimit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEnableLimitActivePower);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labAws);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labTotalActivePower);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FLP1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "风电场功率调度程序";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLP1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labTotalActivePower;
        private System.Windows.Forms.Label labAws;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnableLimitActivePower;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudLimit;
        private System.Windows.Forms.Button btnDisableLimitActivePower;
        private System.Windows.Forms.ListBox lbxStopList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label labTheoreticalPower;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbxStartList;
        private System.Windows.Forms.ToolStripMenuItem 实时图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPC通讯测试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 控制测率ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑控制策略ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 指令记录报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 风场功率调度报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 产品注册ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btnSetActivePowerLimitValue;
    }
}

