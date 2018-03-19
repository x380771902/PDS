using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 风电场功率调度程序.UI
{
    public partial class RealtimeDateVisual : Form
    {
        public RealtimeDateVisual()
        {
            InitializeComponent();
            RedisHelper redishelper = new RedisHelper(1, "127.0.0.1");
            //redishelper.StringGet 
        }
    }
}
