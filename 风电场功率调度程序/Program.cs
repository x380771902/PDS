using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 风电场功率调度程序
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
           // Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
             

            Login frm = new Login();
            Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine((System.ComponentModel.Component)frm);
            skin.SkinFile = Application.StartupPath + @"/Skins/Emerald.ssk"; // 指定皮肤文件
            skin.TitleFont = new System.Drawing.Font("微软雅黑", 10F);// 指定标题栏的Font。
            Application.Run(frm);

            //Application.Run(new Login());
        }
    }
}
