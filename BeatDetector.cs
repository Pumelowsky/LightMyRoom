using System;
using System.Collections.Generic;
using System.Text;

namespace FFT.External
{
    public class BeatDetector
    {
        private static int _evalLength = 0;
        private static List<double> bassHis;

        public static void InitDetector(int evaluateLength)
        {
            _evalLength = evaluateLength;
            bassHis = new List<double>(evaluateLength);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data">Must be transformed data (DFT/FFT)</param>
        public static bool Scan(double[] data,int from,int to,ref double outAccumBass,ref double outCurBass)
        {
            double newBass = 0;
            for (int i = from; i <= to; i++)
            {
                newBass += data[i];
            }            
            double accumBass = 0;
            bool beatDetected = false;
            if (bassHis.Count < _evalLength)
                bassHis.Add(newBass);
            else
            {
                foreach(var item in bassHis)
                {
                    accumBass+=item;
                }
                double aveBass= accumBass / bassHis.Count;
                if(newBass > aveBass*1.3d)
                    beatDetected = true;
                bassHis.RemoveAt(0);
                bassHis.Add(newBass);
            }
            outAccumBass = accumBass;
            outCurBass = newBass;
            return beatDetected;
        }
    }
}
