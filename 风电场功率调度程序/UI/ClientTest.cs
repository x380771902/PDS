using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackExchange.Redis;
using Newtonsoft.Json;


namespace 风电场功率调度程序
{
    public partial class ClientTest : Form
    {
        public ClientTest(Config config)
        {
            this.c = config;
            InitializeComponent();
            this.Icon = Properties.Resources.bitbug_favicon;
        }
        Config c ;
        string[] itemList = null;
        string[] itemDataTypeList = null; 

        private RedisHelper redisHelper = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                redisHelper = new RedisHelper(1, "127.0.0.1");
                //opchelper = new OPCHelper("10.128.2.1", "CSharpServer",200);
              
                itemList = c.ItemList.ToArray();
                itemDataTypeList = c.ItemTypeList.ToArray();
           
                this.timer1.Enabled = true;
                
            }
            catch (NullReferenceException ex)
            { 
                MessageBox.Show(ex.Message);
            }
         
        }

        BindingSource bs = new BindingSource();
        Dictionary<string, Tag> ta = new Dictionary<string, Tag>();
        private void timer1_Tick(object sender, EventArgs e)
        {
            var result = redisHelper.StringGet<Dictionary<string, Tag>>("RealTimeData:");
       
            //var result = opchelper.GetItemValues(itemList);
            // this.labtagcount.Text = result.Values.Count.ToString();
            // this.GoodCount.Text = result.Values.Count(c => c.TagQuality == "192").ToString();

            
             bs.DataSource = result.Values;
             this.dataGridView1.DataSource = bs;
             this.dataGridView1.ClearSelection();
             DgvRowColor(dataGridView1);


            // 强制显示当前行





        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false; 
             
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                
                dataGridView1.FirstDisplayedScrollingRowIndex = selectRowIndex;
            }
        }

        int selectRowIndex = 0; 
        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            selectRowIndex = dataGridView1.FirstDisplayedScrollingRowIndex;
        }


        /// <summary>
        /// 隔行变色
        /// </summary>
        /// <param name="dgv">传入DataGridView控件名称</param>
        public static void DgvRowColor(System.Windows.Forms.DataGridView dgv)
        {

            if (dgv.Rows.Count != 0)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if ((i + 1) % 2 == 0)
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                    }
                    else
                    {
                        dgv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 254, 254);
                    }
                }
            }
        }

    }
}
