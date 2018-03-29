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
    public partial class CommandListForm : Form
    {

        BindingSource bs = new BindingSource();
        public CommandListForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.bitbug_favicon;
            this.dateTimePicker1.Value = DateTime.Now.AddDays(-1);
            this.dateTimePicker2.Value = DateTime.Now;
            try
            {
                bs.DataSource = MysqlDBHelper.GetDataSet("select * from writecommand order by TagTimestamp desc limit 100");
                this.dataGridView1.DataSource = bs;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            } 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                bs.DataSource = MysqlDBHelper.GetDataSet(string.Format("select * from writecommand where TagTimestamp>= '{0}' and TagTimestamp<= '{1}' order by TagTimestamp desc limit 10000", this.dateTimePicker1.Value.ToUniversalTime().ToString(),
                this.dateTimePicker2.Value.ToUniversalTime().ToString()));
                this.dataGridView1.DataSource = bs;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            } 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
