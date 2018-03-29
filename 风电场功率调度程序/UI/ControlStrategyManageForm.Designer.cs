namespace 风电场功率调度程序
{
    partial class ControlStrategyManageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboxstartturbine = new System.Windows.Forms.CheckBox();
            this.cboxstopturbine = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnControlStrategy1 = new System.Windows.Forms.RadioButton();
            this.rbtnControlStrategy2 = new System.Windows.Forms.RadioButton();
            this.cboxIgnoreSample = new System.Windows.Forms.CheckBox();
            this.rbtnControlStrategy3 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.cboxLimitActivePowerSpeed = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtnReactiveControlStrategy2 = new System.Windows.Forms.RadioButton();
            this.rbtnReactiveControlStrategy1 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(318, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(399, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cboxstartturbine
            // 
            this.cboxstartturbine.AutoSize = true;
            this.cboxstartturbine.Location = new System.Drawing.Point(133, 202);
            this.cboxstartturbine.Name = "cboxstartturbine";
            this.cboxstartturbine.Size = new System.Drawing.Size(96, 16);
            this.cboxstartturbine.TabIndex = 2;
            this.cboxstartturbine.Text = "启用自动切机";
            this.cboxstartturbine.UseVisualStyleBackColor = true;
            // 
            // cboxstopturbine
            // 
            this.cboxstopturbine.AutoSize = true;
            this.cboxstopturbine.Location = new System.Drawing.Point(133, 234);
            this.cboxstopturbine.Name = "cboxstopturbine";
            this.cboxstopturbine.Size = new System.Drawing.Size(96, 16);
            this.cboxstopturbine.TabIndex = 3;
            this.cboxstopturbine.Text = "启用自动启机";
            this.cboxstopturbine.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "风机状态判定：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "有功分配模式：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "切机策略：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "启机策略：";
            // 
            // rbtnControlStrategy1
            // 
            this.rbtnControlStrategy1.AutoSize = true;
            this.rbtnControlStrategy1.Location = new System.Drawing.Point(4, 3);
            this.rbtnControlStrategy1.Name = "rbtnControlStrategy1";
            this.rbtnControlStrategy1.Size = new System.Drawing.Size(83, 16);
            this.rbtnControlStrategy1.TabIndex = 12;
            this.rbtnControlStrategy1.TabStop = true;
            this.rbtnControlStrategy1.Text = "等比例分配";
            this.rbtnControlStrategy1.UseVisualStyleBackColor = true;
            // 
            // rbtnControlStrategy2
            // 
            this.rbtnControlStrategy2.AutoSize = true;
            this.rbtnControlStrategy2.Location = new System.Drawing.Point(105, 3);
            this.rbtnControlStrategy2.Name = "rbtnControlStrategy2";
            this.rbtnControlStrategy2.Size = new System.Drawing.Size(71, 16);
            this.rbtnControlStrategy2.TabIndex = 12;
            this.rbtnControlStrategy2.TabStop = true;
            this.rbtnControlStrategy2.Text = "均衡分配";
            this.rbtnControlStrategy2.UseVisualStyleBackColor = true;
            // 
            // cboxIgnoreSample
            // 
            this.cboxIgnoreSample.AutoSize = true;
            this.cboxIgnoreSample.Location = new System.Drawing.Point(133, 25);
            this.cboxIgnoreSample.Name = "cboxIgnoreSample";
            this.cboxIgnoreSample.Size = new System.Drawing.Size(108, 16);
            this.cboxIgnoreSample.TabIndex = 13;
            this.cboxIgnoreSample.Text = "是否忽略样板机";
            this.cboxIgnoreSample.UseVisualStyleBackColor = true;
            // 
            // rbtnControlStrategy3
            // 
            this.rbtnControlStrategy3.AutoSize = true;
            this.rbtnControlStrategy3.Location = new System.Drawing.Point(188, 3);
            this.rbtnControlStrategy3.Name = "rbtnControlStrategy3";
            this.rbtnControlStrategy3.Size = new System.Drawing.Size(119, 16);
            this.rbtnControlStrategy3.TabIndex = 16;
            this.rbtnControlStrategy3.TabStop = true;
            this.rbtnControlStrategy3.Text = "理论功率加权分配";
            this.rbtnControlStrategy3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "斜率模式：";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 3;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown1.Location = new System.Drawing.Point(133, 164);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 21);
            this.numericUpDown1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "十分钟速率限制：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "一分钟速率限制：";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 3;
            this.numericUpDown2.Location = new System.Drawing.Point(344, 164);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(76, 21);
            this.numericUpDown2.TabIndex = 20;
            // 
            // cboxLimitActivePowerSpeed
            // 
            this.cboxLimitActivePowerSpeed.AutoSize = true;
            this.cboxLimitActivePowerSpeed.Location = new System.Drawing.Point(133, 135);
            this.cboxLimitActivePowerSpeed.Name = "cboxLimitActivePowerSpeed";
            this.cboxLimitActivePowerSpeed.Size = new System.Drawing.Size(120, 16);
            this.cboxLimitActivePowerSpeed.TabIndex = 22;
            this.cboxLimitActivePowerSpeed.Text = "是否启用速度限制";
            this.cboxLimitActivePowerSpeed.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(426, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 24;
            this.label9.Text = "%";
            // 
            // rbtnReactiveControlStrategy2
            // 
            this.rbtnReactiveControlStrategy2.AutoSize = true;
            this.rbtnReactiveControlStrategy2.Location = new System.Drawing.Point(105, 7);
            this.rbtnReactiveControlStrategy2.Name = "rbtnReactiveControlStrategy2";
            this.rbtnReactiveControlStrategy2.Size = new System.Drawing.Size(71, 16);
            this.rbtnReactiveControlStrategy2.TabIndex = 26;
            this.rbtnReactiveControlStrategy2.TabStop = true;
            this.rbtnReactiveControlStrategy2.Text = "均衡分配";
            this.rbtnReactiveControlStrategy2.UseVisualStyleBackColor = true;
            // 
            // rbtnReactiveControlStrategy1
            // 
            this.rbtnReactiveControlStrategy1.AutoSize = true;
            this.rbtnReactiveControlStrategy1.Location = new System.Drawing.Point(4, 7);
            this.rbtnReactiveControlStrategy1.Name = "rbtnReactiveControlStrategy1";
            this.rbtnReactiveControlStrategy1.Size = new System.Drawing.Size(83, 16);
            this.rbtnReactiveControlStrategy1.TabIndex = 27;
            this.rbtnReactiveControlStrategy1.TabStop = true;
            this.rbtnReactiveControlStrategy1.Text = "等比例分配";
            this.rbtnReactiveControlStrategy1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "无功分配模式：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnControlStrategy1);
            this.panel1.Controls.Add(this.rbtnControlStrategy2);
            this.panel1.Controls.Add(this.rbtnControlStrategy3);
            this.panel1.Location = new System.Drawing.Point(133, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 25);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnReactiveControlStrategy1);
            this.panel2.Controls.Add(this.rbtnReactiveControlStrategy2);
            this.panel2.Location = new System.Drawing.Point(133, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 26);
            this.panel2.TabIndex = 29;
            // 
            // ControlStrategyManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 288);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboxLimitActivePowerSpeed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboxIgnoreSample);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxstopturbine);
            this.Controls.Add(this.cboxstartturbine);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Name = "ControlStrategyManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "控制策略管理界面";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cboxstartturbine;
        private System.Windows.Forms.CheckBox cboxstopturbine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnControlStrategy1;
        private System.Windows.Forms.RadioButton rbtnControlStrategy2;
        private System.Windows.Forms.CheckBox cboxIgnoreSample;
        private System.Windows.Forms.RadioButton rbtnControlStrategy3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox cboxLimitActivePowerSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbtnReactiveControlStrategy2;
        private System.Windows.Forms.RadioButton rbtnReactiveControlStrategy1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}