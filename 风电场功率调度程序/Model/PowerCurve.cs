using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 风电场功率调度程序 { 
   public class PowerCurve
    {

        public PowerCurve(float[] Windspeed, float[] ActivePower)
        {
            double[] ws = Array.ConvertAll(Windspeed, d => (double)d);
            double[] ap = Array.ConvertAll(ActivePower, d => (double)d); 
            this.Windspeed = PowerCurve.Interpolation(ws, 2000);
            this.ActivePower = PowerCurve.Interpolation(ap, 2000);
        }
        public double[] Windspeed { get; set; }
         
        public double[] ActivePower { get; set; }
         
        /// <summary> 
        /// 分段线性插值，将一组数插值为所需点数 
        /// </summary> 
        /// <param name="dataIn">待插值的数据数组</param> 
        /// <param name="n">插值点数</param> 
        /// <returns>插值后的数据数组</returns> 
        public static double[] Interpolation(double[] dataIn, int n)
        {
            double[] dataOut = new double[n];
            int lenIn = dataIn.Length;
            double[] a = new double[lenIn];
            double[] divIn = new double[lenIn];
            double[] divOut = new double[n];
            divIn[0] = 0;
            for (int i = 1; i < lenIn; i++)
            {
                divIn[i] = divIn[i - 1] + 1;
            }
            divOut[0] = 0;
            for (int i = 1; i < n; i++)
            {
                divOut[i] = divOut[i - 1] + lenIn / Convert.ToDouble(n);
            }
            int k = 0;
            for (int i = k; i < n; i++)
            {

                for (int j = 0; j < lenIn - 1; j++)
                {
                    if (divOut[i] >= divIn[j] && divOut[i] < divIn[j + 1])
                    {
                        dataOut[i] = (dataIn[j + 1] - dataIn[j]) * (divOut[i] - divIn[j]) / (divIn[j + 1] - divIn[j]) +
                                     dataIn[j];
                        k = i;
                    }
                }
            }
            return dataOut;
        }


    }
}
