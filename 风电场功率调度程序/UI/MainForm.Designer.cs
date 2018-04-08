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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.nudLimitAp = new System.Windows.Forms.NumericUpDown();
            this.btnDisableLimitActivePower = new System.Windows.Forms.Button();
            this.lbxStopList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labTheoreticalPower = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbxStartList = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetActivePowerLimitValue = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.labControlStrategy = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labTotalActivePowerSp = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labTotalReactivePowerSp = new System.Windows.Forms.Label();
            this.btnSetReActivePowerLimitValue = new System.Windows.Forms.Button();
            this.nudLimitRap = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labTotalReactivePower = new System.Windows.Forms.Label();
            this.操作日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitAp)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitRap)).BeginInit();
            this.SuspendLayout();
            // 
            // FLP1
            // 
            this.FLP1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLP1.AutoScroll = true;
            this.FLP1.Location = new System.Drawing.Point(171, 30);
            this.FLP1.Name = "FLP1";
            this.FLP1.Size = new System.Drawing.Size(923, 483);
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
            this.编辑控制策略ToolStripMenuItem.Click += new System.EventHandler(this.编辑控制策略ToolStripMenuItem_Click);
            // 
            // 系统报表ToolStripMenuItem
            // 
            this.系统报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.指令记录报表ToolStripMenuItem,
            this.风场功率调度报表ToolStripMenuItem,
            this.操作日志ToolStripMenuItem});
            this.系统报表ToolStripMenuItem.Name = "系统报表ToolStripMenuItem";
            this.系统报表ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.系统报表ToolStripMenuItem.Text = "系统报表(&S)";
            // 
            // 指令记录报表ToolStripMenuItem
            // 
            this.指令记录报表ToolStripMenuItem.Name = "指令记录报表ToolStripMenuItem";
            this.指令记录报表ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.指令记录报表ToolStripMenuItem.Text = "指令记录报表";
            this.指令记录报表ToolStripMenuItem.Click += new System.EventHandler(this.指令记录报表ToolStripMenuItem_Click);
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
            this.帮助文档ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.帮助文档ToolStripMenuItem.Text = "帮助文档(&V)";
            // 
            // 产品注册ToolStripMenuItem
            // 
            this.产品注册ToolStripMenuItem.Name = "产品注册ToolStripMenuItem";
            this.产品注册ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.产品注册ToolStripMenuItem.Text = "产品注册(&T)";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.关于ToolStripMenuItem.Text = "关于(&A)";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "总有功反馈：";
            // 
            // labTotalActivePower
            // 
            this.labTotalActivePower.AutoSize = true;
            this.labTotalActivePower.Location = new System.Drawing.Point(85, 76);
            this.labTotalActivePower.Name = "labTotalActivePower";
            this.labTotalActivePower.Size = new System.Drawing.Size(53, 12);
            this.labTotalActivePower.TabIndex = 3;
            this.labTotalActivePower.Text = "未初始化";
            // 
            // labAws
            // 
            this.labAws.AutoSize = true;
            this.labAws.Location = new System.Drawing.Point(85, 34);
            this.labAws.Name = "labAws";
            this.labAws.Size = new System.Drawing.Size(53, 12);
            this.labAws.TabIndex = 9;
            this.labAws.Text = "未初始化";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "平均风速：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "有功限定值：";
            // 
            // btnEnableLimitActivePower
            // 
            this.btnEnableLimitActivePower.Location = new System.Drawing.Point(10, 300);
            this.btnEnableLimitActivePower.Name = "btnEnableLimitActivePower";
            this.btnEnableLimitActivePower.Size = new System.Drawing.Size(88, 23);
            this.btnEnableLimitActivePower.TabIndex = 12;
            this.btnEnableLimitActivePower.Text = "启用功率调度";
            this.btnEnableLimitActivePower.UseVisualStyleBackColor = true;
            this.btnEnableLimitActivePower.Click += new System.EventHandler(this.btnEnableLimitActivePower_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "kW";
            // 
            // nudLimitAp
            // 
            this.nudLimitAp.Enabled = false;
            this.nudLimitAp.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudLimitAp.Location = new System.Drawing.Point(8, 200);
            this.nudLimitAp.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudLimitAp.Name = "nudLimitAp";
            this.nudLimitAp.Size = new System.Drawing.Size(65, 21);
            this.nudLimitAp.TabIndex = 14;
            this.nudLimitAp.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // btnDisableLimitActivePower
            // 
            this.btnDisableLimitActivePower.Enabled = false;
            this.btnDisableLimitActivePower.Location = new System.Drawing.Point(10, 329);
            this.btnDisableLimitActivePower.Name = "btnDisableLimitActivePower";
            this.btnDisableLimitActivePower.Size = new System.Drawing.Size(88, 23);
            this.btnDisableLimitActivePower.TabIndex = 15;
            this.btnDisableLimitActivePower.Text = "解除功率调度";
            this.btnDisableLimitActivePower.UseVisualStyleBackColor = true;
            this.btnDisableLimitActivePower.Click += new System.EventHandler(this.btnDisableLimitActivePower_Click);
            // 
            // lbxStopList
            // 
            this.lbxStopList.FormattingEnabled = true;
            this.lbxStopList.ItemHeight = 12;
            this.lbxStopList.Location = new System.Drawing.Point(8, 559);
            this.lbxStopList.Name = "lbxStopList";
            this.lbxStopList.Size = new System.Drawing.Size(137, 112);
            this.lbxStopList.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "启机队列：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 534);
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
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabel2.Text = "时间";
            // 
            // labTheoreticalPower
            // 
            this.labTheoreticalPower.AutoSize = true;
            this.labTheoreticalPower.Location = new System.Drawing.Point(85, 56);
            this.labTheoreticalPower.Name = "labTheoreticalPower";
            this.labTheoreticalPower.Size = new System.Drawing.Size(53, 12);
            this.labTheoreticalPower.TabIndex = 22;
            this.labTheoreticalPower.Text = "未初始化";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "理论有功：";
            // 
            // lbxStartList
            // 
            this.lbxStartList.FormattingEnabled = true;
            this.lbxStartList.ItemHeight = 12;
            this.lbxStartList.Location = new System.Drawing.Point(8, 405);
            this.lbxStartList.Name = "lbxStartList";
            this.lbxStartList.Size = new System.Drawing.Size(137, 112);
            this.lbxStartList.TabIndex = 23;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(765, 544);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(329, 174);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(763, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "日志消息：";
            // 
            // btnSetActivePowerLimitValue
            // 
            this.btnSetActivePowerLimitValue.Enabled = false;
            this.btnSetActivePowerLimitValue.Location = new System.Drawing.Point(80, 198);
            this.btnSetActivePowerLimitValue.Name = "btnSetActivePowerLimitValue";
            this.btnSetActivePowerLimitValue.Size = new System.Drawing.Size(66, 23);
            this.btnSetActivePowerLimitValue.TabIndex = 26;
            this.btnSetActivePowerLimitValue.Text = "给定有功";
            this.btnSetActivePowerLimitValue.UseVisualStyleBackColor = true;
            this.btnSetActivePowerLimitValue.Click += new System.EventHandler(this.btnSetActivePowerLimitValue_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45)));
            chartArea1.AxisY.LabelStyle.Angle = -45;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisY.Maximum = 50000D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 76.67067F;
            chartArea1.InnerPlotPosition.Width = 88.42284F;
            chartArea1.InnerPlotPosition.X = 6F;
            chartArea1.InnerPlotPosition.Y = 1F;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(171, 542);
            this.chart1.Name = "chart1";
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkUpwardDiagonal;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.LabelForeColor = System.Drawing.SystemColors.Control;
            series1.Name = "实时功率";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Name = "限定功率";
            series2.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(588, 211);
            this.chart1.TabIndex = 27;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.实时图ToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "实时曲线：";
            // 
            // labControlStrategy
            // 
            this.labControlStrategy.AutoSize = true;
            this.labControlStrategy.Location = new System.Drawing.Point(85, 121);
            this.labControlStrategy.Name = "labControlStrategy";
            this.labControlStrategy.Size = new System.Drawing.Size(53, 12);
            this.labControlStrategy.TabIndex = 30;
            this.labControlStrategy.Text = "未初始化";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 29;
            this.label11.Text = "调控模式：";
            // 
            // labTotalActivePowerSp
            // 
            this.labTotalActivePowerSp.AutoSize = true;
            this.labTotalActivePowerSp.Location = new System.Drawing.Point(85, 178);
            this.labTotalActivePowerSp.Name = "labTotalActivePowerSp";
            this.labTotalActivePowerSp.Size = new System.Drawing.Size(53, 12);
            this.labTotalActivePowerSp.TabIndex = 34;
            this.labTotalActivePowerSp.Text = "未初始化";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 33;
            this.label14.Text = "总无功反馈：";
            // 
            // labTotalReactivePowerSp
            // 
            this.labTotalReactivePowerSp.AutoSize = true;
            this.labTotalReactivePowerSp.Location = new System.Drawing.Point(85, 226);
            this.labTotalReactivePowerSp.Name = "labTotalReactivePowerSp";
            this.labTotalReactivePowerSp.Size = new System.Drawing.Size(53, 12);
            this.labTotalReactivePowerSp.TabIndex = 39;
            this.labTotalReactivePowerSp.Text = "未初始化";
            // 
            // btnSetReActivePowerLimitValue
            // 
            this.btnSetReActivePowerLimitValue.Enabled = false;
            this.btnSetReActivePowerLimitValue.Location = new System.Drawing.Point(80, 246);
            this.btnSetReActivePowerLimitValue.Name = "btnSetReActivePowerLimitValue";
            this.btnSetReActivePowerLimitValue.Size = new System.Drawing.Size(66, 23);
            this.btnSetReActivePowerLimitValue.TabIndex = 38;
            this.btnSetReActivePowerLimitValue.Text = "给定无功";
            this.btnSetReActivePowerLimitValue.UseVisualStyleBackColor = true;
            this.btnSetReActivePowerLimitValue.Click += new System.EventHandler(this.btnSetReActivePowerLimitValue_Click);
            // 
            // nudLimitRap
            // 
            this.nudLimitRap.Enabled = false;
            this.nudLimitRap.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudLimitRap.Location = new System.Drawing.Point(8, 248);
            this.nudLimitRap.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudLimitRap.Name = "nudLimitRap";
            this.nudLimitRap.Size = new System.Drawing.Size(65, 21);
            this.nudLimitRap.TabIndex = 37;
            this.nudLimitRap.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 36;
            this.label12.Text = "kW";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 35;
            this.label15.Text = "无功限定值：";
            // 
            // labTotalReactivePower
            // 
            this.labTotalReactivePower.AutoSize = true;
            this.labTotalReactivePower.Location = new System.Drawing.Point(85, 98);
            this.labTotalReactivePower.Name = "labTotalReactivePower";
            this.labTotalReactivePower.Size = new System.Drawing.Size(53, 12);
            this.labTotalReactivePower.TabIndex = 40;
            this.labTotalReactivePower.Text = "未初始化";
            // 
            // 操作日志ToolStripMenuItem
            // 
            this.操作日志ToolStripMenuItem.Name = "操作日志ToolStripMenuItem";
            this.操作日志ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.操作日志ToolStripMenuItem.Text = "操作日志";
            this.操作日志ToolStripMenuItem.Click += new System.EventHandler(this.操作日志ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 753);
            this.Controls.Add(this.labTotalReactivePower);
            this.Controls.Add(this.labTotalReactivePowerSp);
            this.Controls.Add(this.btnSetReActivePowerLimitValue);
            this.Controls.Add(this.nudLimitRap);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labTotalActivePowerSp);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labControlStrategy);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSetActivePowerLimitValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbxStartList);
            this.Controls.Add(this.labTheoreticalPower);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDisableLimitActivePower);
            this.Controls.Add(this.nudLimitAp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEnableLimitActivePower);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labAws);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labTotalActivePower);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FLP1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lbxStopList);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "风电场功率调度程序";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitAp)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitRap)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudLimitAp;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labControlStrategy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labTotalActivePowerSp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labTotalReactivePowerSp;
        private System.Windows.Forms.Button btnSetReActivePowerLimitValue;
        private System.Windows.Forms.NumericUpDown nudLimitRap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labTotalReactivePower;
        private System.Windows.Forms.ToolStripMenuItem 操作日志ToolStripMenuItem;
    }
}

