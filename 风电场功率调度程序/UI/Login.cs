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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        MainForm f;
        private void btnLogin_Click(object sender, EventArgs e)
        {

              f = new MainForm();
            this.Hide();
            f.ShowDialog();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(f != null)
            { f.Dispose(); } 
            GC.Collect();
            this.Close();
            
        }
    }
}
