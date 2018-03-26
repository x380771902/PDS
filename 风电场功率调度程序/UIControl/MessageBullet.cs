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
    public partial class MessageBullet : UserControl
    {
        public MessageBullet()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.Transparent; 
        }

        public MessageBullet(string message)
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.Transparent;
            this.labmessage.Text = message;

        }

    }
}
