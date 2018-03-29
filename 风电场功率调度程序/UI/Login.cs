using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            this.Icon = Properties.Resources.bitbug_favicon;
            InitializeComponent();


            //GraphicsPath oPath = new GraphicsPath();
            //int x = 0;
            //int y = 0;
            //int thisWidth = this.Width;
            //int thisHeight = this.Height;
            //int angle = 10;
            //System.Drawing.Graphics g = CreateGraphics();
            //oPath.AddArc(x, y, angle, angle, 180, 90);                                 // 左上角
            //oPath.AddArc(thisWidth - angle, y, angle, angle, 270, 90);                 // 右上角
            //oPath.AddArc(thisWidth - angle, thisHeight - angle, angle, angle, 0, 90);  // 右下角
            //oPath.AddArc(x, thisHeight - angle, angle, angle, 90, 90);                 // 左下角
            //oPath.CloseAllFigures();
            //Region = new System.Drawing.Region(oPath);

            //// -----------------------------------------------------------------------------------------------

            //this.Region = Region;

        }

        MainForm f;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = this.textBox1.Text.Trim();
            user.UserPassword = Common.MD5ToString(Common.MD5ToString(this.textBox2.Text.Trim()));

            try
            {
                string sqlstring = "select * from user where username = '" + user.UserName + "' and userpassword = '" + user.UserPassword + "' and Isdelete = 0";
                var result = MysqlDBHelper.GetDataSet(sqlstring);
                if (result != null & result.Rows.Count > 0)
                {
                    user.UserType = int.Parse(result.Rows[0]["userType"].ToString());
                    WindFarmMessage.AddOperateMessage("用户登录成功！", user.UserName);
                    f = new MainForm(user);
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    WindFarmMessage.AddOperateMessage("用户登录失败！", user.UserName);
                    MessageBox.Show("登录失败，用户名或密码错误！");
                }
            }
            catch  
            {
                MessageBox.Show("连接服务器失败，请联系管理员或者技术支持人员！");
            } 
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
